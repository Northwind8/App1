using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectProfession : ContentPage
    {
        public SelectProfession()
        {
            InitializeComponent();
        }

        private async void helmetClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?{nameof(ItemsViewModel.GroupID)}={EnumProf.helmet}");
        }

        private async void craneClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?{nameof(ItemsViewModel.GroupID)}={EnumProf.crane}");
        }

        private async void electricianClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?{nameof(ItemsViewModel.GroupID)}={EnumProf.electrician}");
        }

        private async void machineClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?{nameof(ItemsViewModel.GroupID)}={EnumProf.machine}");
        }
        private async void welderClick(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ItemsPage)}?{nameof(ItemsViewModel.GroupID)}={EnumProf.welder}");
        }
    }
}