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
            if (string.IsNullOrWhiteSpace(emailOrPhone))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Введите email или телефон." };
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Введите пароль." };
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
            if (string.IsNullOrWhiteSpace(name)) return new AuthResult { IsSuccess = false, ErrorMessage = "Введите имя." };
            if (string.IsNullOrWhiteSpace(email)) return new AuthResult { IsSuccess = false, ErrorMessage = "Введите email." };
            if (string.IsNullOrWhiteSpace(phone)) return new AuthResult { IsSuccess = false, ErrorMessage = "Введите телефон." };
            if (string.IsNullOrWhiteSpace(password)) return new AuthResult { IsSuccess = false, ErrorMessage = "Введите пароль." };
            if (password.Trim().Length < 6) return new AuthResult { IsSuccess = false, ErrorMessage = "Пароль должен содержать минимум 6 символов." };

            if (!InputValidator.IsValidEmail(email))
            {
                return new AuthResult { IsSuccess = false, ErrorMessage = "Введите корректный email." };
            }

            try
            {
                using (var context = new BusStationDbContext())
                {
                    var normalizedEmail = email.Trim();
                    var normalizedPhone = phone.Trim();
                    var exists = context.Users.Any(x => x.Email == normalizedEmail || x.Phone == normalizedPhone);
                    if (exists)
                    {
                        return new AuthResult { IsSuccess = false, ErrorMessage = "Пользователь с таким email или телефоном уже существует." };
                    }

                    var user = new User
                    {
                        Name = name.Trim(),
                        Email = normalizedEmail,
                        Phone = normalizedPhone,
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
