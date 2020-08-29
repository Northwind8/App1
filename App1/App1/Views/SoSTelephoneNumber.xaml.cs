using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoSTelephoneNumber : ContentPage
    {
        SoSTelephoneNumberModel _viewModel;

        public SoSTelephoneNumber()
        {
            InitializeComponent();

            BindingContext = _viewModel = new SoSTelephoneNumberModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}