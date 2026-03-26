using System.Linq;
using System.Data.Entity;
using BusStationApp.BLL.Security;
using BusStationApp.Common.DTOs;
using BusStationApp.Common.Enums;
using BusStationApp.Common.Interfaces;
using BusStationApp.Common.Validation;
using BusStationApp.DAL.Contexts;
using BusStationApp.DAL.Entities;

namespace BusStationApp.BLL.Services
{
    public class AuthService : IAuthService
    {
        public AuthResult Login(string emailOrPhone, string password)
        {
            using (var context = new BusStationDbContext())
            {
                var hash = PasswordHasher.Hash(password);
                var user = context.Users
                    .Include("Role")
                    .FirstOrDefault(x =>
                        (x.Email == emailOrPhone || x.Phone == emailOrPhone) &&
                        x.PasswordHash == hash);

                if (user == null)
                {
                    return new AuthResult { IsSuccess = false, ErrorMessage = "Неверный логин или пароль." };
                }

                return new AuthResult
                {
                    IsSuccess = true,
                    UserId = user.Id,
                    UserName = user.Name,
                    Role = (UserRole)user.RoleId
                };
            }
        }

        public AuthResult Register(string name, string email, string phone, string password)
        {
            if (!InputValidator.IsValidEmail(email))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Введите корректный email." };
            }

            using (var context = new BusStationDbContext())
            {
                var exists = context.Users.Any(x => x.Email == email || x.Phone == phone);
                if (exists)
                {
                    return new AuthResult { IsSuccess = false, ErrorMessage = "Пользователь уже существует." };
                }

                var user = new User
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    PasswordHash = PasswordHasher.Hash(password),
                    RoleId = (int)UserRole.User
                };

                context.Users.Add(user);
                context.SaveChanges();

                return new AuthResult { IsSuccess = true, UserId = user.Id, UserName = user.Name, Role = UserRole.User };
            }
        }
    }
}
