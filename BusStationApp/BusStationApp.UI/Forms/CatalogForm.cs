using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BusStationApp.BLL.Services;
using BusStationApp.Common.Enums;
using BusStationApp.DAL.Contexts;

namespace BusStationApp.UI.Forms
{
    public class CatalogForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        private readonly CartService _cartService = new CartService();
        private readonly int _userId;
        private readonly UserRole _role;
        private DataGridView dgvCatalog;

        public CatalogForm(int userId, UserRole role)
        {
            _userId = userId;
            _role = role;
            Text = "Каталог";
            Width = 900;
            Height = 500;
            Init();
            LoadCatalog();
        }

        private void Init()
        {
            dgvCatalog = new DataGridView { Dock = DockStyle.Top, Height = 380, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            dgvCatalog.CellFormatting += DgvCatalog_CellFormatting;
            var btnAddToCart = new Button { Top = 400, Left = 20, Width = 170, Text = "Добавить в корзину" };
            var btnUploadImage = new Button { Top = 400, Left = 210, Width = 170, Text = "Загрузить изображение" };

            btnAddToCart.Click += BtnAddToCart_Click;
            btnUploadImage.Click += BtnUploadImage_Click;

            Controls.Add(dgvCatalog);
            Controls.Add(btnAddToCart);
            Controls.Add(btnUploadImage);
        }

        private void LoadCatalog()
        {
            var data = _productService.GetCatalog()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Category.Name,
                    x.OldPrice,
                    x.Discount,
                    Price = _productService.CalculateTotalPrice(x.Price, x.Discount),
                    x.ImagePath
                })
                .ToList();

            dgvCatalog.DataSource = data;

            foreach (DataGridViewRow row in dgvCatalog.Rows)
            {
                if (row.Cells["Price"].Value is decimal price && price > 1000)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
            }
        }

        private void DgvCatalog_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCatalog.Columns[e.ColumnIndex].Name != "OldPrice")
            {
                return;
            }

            var discount = Convert.ToDecimal(dgvCatalog.Rows[e.RowIndex].Cells["Discount"].Value);
            if (discount > 0)
            {
                e.CellStyle.Font = new Font(dgvCatalog.Font, FontStyle.Strikeout);
                e.CellStyle.ForeColor = Color.DarkRed;
            }
        }

        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvCatalog.CurrentRow == null)
            {
                return;
            }

            var productId = Convert.ToInt32(dgvCatalog.CurrentRow.Cells["Id"].Value);
            _cartService.AddToCart(_userId, productId, 1);
            MessageBox.Show("Добавлено в корзину.");
        }

        private void BtnUploadImage_Click(object sender, EventArgs e)
        {
            if (dgvCatalog.CurrentRow == null || (_role != UserRole.Admin && _role != UserRole.Manager))
            {
                MessageBox.Show("Требуются права менеджера или администратора.");
                return;
            }

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var fileName = Path.GetFileName(dialog.FileName);
                var targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProductImages");
                Directory.CreateDirectory(targetDirectory);

                var targetPath = Path.Combine(targetDirectory, fileName);
                var relativePath = Path.Combine("ProductImages", fileName);
                File.Copy(dialog.FileName, targetPath, true);
                var productId = Convert.ToInt32(dgvCatalog.CurrentRow.Cells["Id"].Value);

                using (var context = new BusStationDbContext())
                {
                    var product = context.Products.Find(productId);
                    if (product != null)
                    {
                        product.ImagePath = relativePath;
                        context.SaveChanges();
                    }
                }

                MessageBox.Show($"Изображение сохранено: {relativePath}");
                LoadCatalog();
            }
        }
    }
}
