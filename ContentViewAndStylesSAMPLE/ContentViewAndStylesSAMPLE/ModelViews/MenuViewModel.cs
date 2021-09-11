using ContentViewAndStylesSAMPLE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewAndStylesSAMPLE.ModelViews
{
    class MenuViewModel
    {
        public MenuOption Cars { get; set; }
        public MenuOption Parts { get; set; }
        public MenuOption Contracts { get; set; }
        public MenuOption Contacts { get; set; }
        public MenuOption Promotions { get; set; }
        public MenuOption Garages { get; set; }

        public MenuViewModel()
        {
            Cars = new MenuOption("Carros", "car.png");
            Parts = new MenuOption("Partes", "part.png");
            Contracts = new MenuOption("Contratos", "contract.png");
            Contacts = new MenuOption("Contactos", "contact.png");
            Promotions = new MenuOption("Promociones", "promotion.png");
            Garages = new MenuOption("Garajes", "garage.png");
        }
    }
}
