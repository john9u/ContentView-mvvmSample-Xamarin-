﻿using ContentViewAndStylesSAMPLE.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContentViewAndStylesSAMPLE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ShellPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
