using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

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

        private void SfDataGrid_GridTapped(object sender, GridTappedEventArgs e)
        {
            if (e.RowColumnIndex == new Syncfusion.GridCommon.ScrollAxis.RowColumnIndex(2,2))
            {
                PhoneDialer.Open("+7(383)-337-67-44");
            }
            else if (e.RowColumnIndex == new Syncfusion.GridCommon.ScrollAxis.RowColumnIndex(3, 2))
            {
                PhoneDialer.Open("+7(383)-337-54-43");
            }
            else if (e.RowColumnIndex == new Syncfusion.GridCommon.ScrollAxis.RowColumnIndex(4, 2))
            {
                PhoneDialer.Open("+7(383)-337-74-39");
            }
            else if (e.RowColumnIndex == new Syncfusion.GridCommon.ScrollAxis.RowColumnIndex(5, 2))
            {
                PhoneDialer.Open("+7(383)-337-64-68");
            }
            else if (e.RowColumnIndex == new Syncfusion.GridCommon.ScrollAxis.RowColumnIndex(6, 2))
            {
                PhoneDialer.Open("+7(383)-337-54-60");
            }
        }
    }
}

//"+7(383)-337-67-44"
//"+7(383)-337-54-43"
//"+7(383)-337-74-39"
//"+7(383)-337-64-68"
//"+7(383)-337-54-60"