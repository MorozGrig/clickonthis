using System;
using System.Data.Entity;
using System.Linq;
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
            if (string.IsNullOrWhiteSpace(emailOrPhone) || string.IsNullOrWhiteSpace(password))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Заполните логин и пароль." };
            }

            try
            {
                using (var context = new BusStationDbContext())
                {
                    var login = emailOrPhone.Trim();
                    var user = context.Users
                        .Include("Role")
                        .FirstOrDefault(x => x.Email == login || x.Phone == login);

                    if (user == null || string.IsNullOrEmpty(user.Password) || user.Password != password)
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
            catch (Exception)
            {
                return new AuthResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Ошибка подключения к базе данных. Повторите попытку позже."
                };
            }
        }

        public AuthResult Register(string name, string email, string phone, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(password))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Все поля обязательны для заполнения." };
            }

            if (!InputValidator.IsValidEmail(email))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Введите корректный email." };
            }

            try
            {
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
                        Password = password,
                        RoleId = (int)UserRole.User
                    };

                    context.Users.Add(user);
                    context.SaveChanges();

                    return new AuthResult { IsSuccess = true, UserId = user.Id, UserName = user.Name, Role = UserRole.User };
                }
            }
            catch (Exception)
            {
                return new AuthResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Не удалось зарегистрировать пользователя из-за ошибки базы данных."
                };
            }
        }
    }
}
