using BusStationApp.Common.Enums;

namespace BusStationApp.UI.Helpers
{
    public static class RoleAccessHelper
    {
        public static bool CanOpenAdminPanel(UserRole role)
        {
            return role == UserRole.Admin || role == UserRole.Manager;
        }

        public static bool CanDelete(UserRole role)
        {
            return role == UserRole.Admin;
        }
    }
}
