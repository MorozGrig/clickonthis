using BusStationApp.Common.Enums;

namespace BusStationApp.UI.Helpers
{
    public static class RoleAccessHelper
    {
        public static bool CanOpenAdminPanel(UserRole role) => role == UserRole.Admin || role == UserRole.Manager;

        public static bool CanViewCart(UserRole role) => role != UserRole.Guest;

        public static bool CanCheckout(UserRole role) => role != UserRole.Guest;

        public static bool CanAddToCart(UserRole role) => role != UserRole.Guest;

        public static bool CanManageData(UserRole role) => role == UserRole.Manager || role == UserRole.Admin;

        public static bool CanDelete(UserRole role) => role == UserRole.Admin;

        public static bool CanManageUsers(UserRole role) => role == UserRole.Admin;
    }
}
