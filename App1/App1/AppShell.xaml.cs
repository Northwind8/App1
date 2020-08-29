using System;
using System.Collections.Generic;
using App1.Models;
using App1.ViewModels;
using App1.Views;
using Xamarin.Forms;

namespace App1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SoSTelephoneNumber), typeof(SoSTelephoneNumber));
            Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
          //  await Shell.Current.GoToAsync("//SoSTelephoneNumber");
        }
    }
}
