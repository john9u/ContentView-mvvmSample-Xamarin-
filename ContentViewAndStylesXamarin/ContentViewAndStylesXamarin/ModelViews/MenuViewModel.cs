using ContentViewAndStylesXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewAndStylesXamarin.ModelViews
{
    public class MenuViewModel
    {
        public MenuOption Cars { get; set; }
        public MenuOption Parts { get; set; }
        public MenuOption Contracts { get; set; }
        public MenuOption Contacts { get; set; }
        public MenuOption Promotions { get; set; }
        public MenuOption Garages { get; set; }

        public MenuViewModel()
        {
            Cars = new MenuOption("Carros", "2000 opciones", "car.png");
            Parts = new MenuOption("Partes", "60000 opciones", "part.png");
            Contracts = new MenuOption("Contratos", "6 opciones", "contract.png");
            Contacts = new MenuOption("Contactos", "60 opciones", "contact.png");
            Promotions = new MenuOption("Promociones", "200 opciones", "promotion.png");
            Garages = new MenuOption("Garajes", "10 opciones", "garage.png");
        }
    }
}
