using Practica_Extra_Xam.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Extra_Xam.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption HomeMenuOption { get; set; } = new MenuOption();
        public MenuOption Ubicacion { get; set; } = new MenuOption();
        public MenuOption bus { get; set; } = new MenuOption();
        public MenuOption globo { get; set; } = new MenuOption();
        public MenuOption maleta { get; set; } = new MenuOption();
        public MenuOption mapa { get; set; } = new MenuOption();
        public MenuOption monte { get; set; } = new MenuOption();
        public MenuOption basketball { get; set; } = new MenuOption();
        public MenuOption baseball { get; set; } = new MenuOption();
        public MenuOption soccer { get; set; } = new MenuOption();
        public MenuOption tennis { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            HomeMenuOption.Title = "Hogar";
            HomeMenuOption.Image = "casa";

            Ubicacion.Title = "Ubicacion";
            Ubicacion.Image = "ubicacion";

            bus.Title = "Auto Caravana";
            bus.Image = "autocaravana";

            globo.Title = "Globo";
            globo.Image = "globo";

            maleta.Title = "Maleta";
            maleta.Image = "maleta";

            mapa.Title = "Mapa";
            mapa.Image = "mapa";

            monte.Title = "Monte";
            monte.Image = "Monte";

            basketball.Title = "Basketball";
            basketball.Image = "Basketball";

            baseball.Title = "Baseball";
            baseball.Image = "Baseball";

            soccer.Title = "Soccer";
            soccer.Image = "Soccer";

            tennis.Title = "Tennis";
            tennis.Image = "Tennis";
        }

    }
}
