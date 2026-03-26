using BusStationApp.Common.Enums;

namespace BusStationApp.Common.DTOs
{
    public class AuthResult
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public UserRole Role { get; set; }
    }
}
