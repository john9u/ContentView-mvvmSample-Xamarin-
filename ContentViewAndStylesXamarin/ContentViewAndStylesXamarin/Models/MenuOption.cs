using System;
using System.Collections.Generic;
using System.Text;

namespace ContentViewAndStylesXamarin.Models
{
    public class MenuOption
    {
        public MenuOption(string title, string description, string image)
        {
            Title = title;
            Description = description;
            Image = image;
        }

        public string Title { get; }
        public string Description { get; }
        public string Image { get; }
    }
}
