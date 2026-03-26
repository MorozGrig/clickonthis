using System.Drawing;
using System.Windows.Forms;

namespace BusStationApp.UI.Helpers
{
    public static class UiTheme
    {
        public static readonly Color Background = Color.FromArgb(245, 245, 245);
        public static readonly Color Surface = Color.White;
        public static readonly Color Accent = Color.FromArgb(46, 125, 50);
        public static readonly Color AccentDark = Color.FromArgb(27, 94, 32);
        public static readonly Color TextPrimary = Color.FromArgb(33, 33, 33);
        public static readonly Color Border = Color.FromArgb(224, 224, 224);

        public static Button CreatePrimaryButton(string text, int width = 180)
        {
            var btn = new Button
            {
                Text = text,
                Width = width,
                Height = 38
            };

            ApplyPrimaryButtonStyle(btn);
            return btn;
        }

        public static void ApplyPrimaryButtonStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Accent;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter -= HandlePrimaryButtonMouseEnter;
            btn.MouseLeave -= HandlePrimaryButtonMouseLeave;
            btn.MouseEnter += HandlePrimaryButtonMouseEnter;
            btn.MouseLeave += HandlePrimaryButtonMouseLeave;
        }

        private static void HandlePrimaryButtonMouseEnter(object sender, System.EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = AccentDark;
            }
        }

        private static void HandlePrimaryButtonMouseLeave(object sender, System.EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Accent;
            }
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(66, 66, 66);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            grid.DefaultCellStyle.SelectionForeColor = TextPrimary;
        }
    }
}
