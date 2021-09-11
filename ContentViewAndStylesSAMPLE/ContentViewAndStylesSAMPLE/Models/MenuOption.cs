using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewAndStylesSAMPLE.Models
{
    class MenuOption
    {
        public MenuOption(string title, string image)
        {
            Title = title;
            Image = image;
        }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
