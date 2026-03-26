using BusStationApp.Common.DTOs;

namespace BusStationApp.Common.Interfaces
{
    public interface IAuthService
    {
        AuthResult Login(string emailOrPhone, string password);
        AuthResult Register(string name, string email, string phone, string password);
    }
}
