using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Меню";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://sinaratm.ru/about/enterprises/novosibirskiy-elektrovozoremontnyy-zavod/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}