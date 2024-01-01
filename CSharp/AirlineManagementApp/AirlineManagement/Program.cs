using LibraryAirlineManagement;
using AirlineManagement.Menus;

namespace AirlineManagement
{
    class Program
    {
        public static AirlineCoordinator aCoord;

        static void Main(string[] args)
        {
            aCoord = new AirlineCoordinator(100, 20, 30);
            MenuMain.MainMenu();
        }
    }
}





