using App1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class SoSTelephoneNumberModel : BaseViewModel
    {
        private SoSTelephoneNumberItem _selectedItem;

        public ObservableCollection<SoSTelephoneNumberItem> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<SoSTelephoneNumberItem> ItemTapped { get; }

        public SoSTelephoneNumberModel()
        {
            Title = "Телефоны экстренного вызова";
            Items = new ObservableCollection<SoSTelephoneNumberItem>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            //ItemTapped = new Command<Item>(OnItemSelected);

            //AddItemCommand = new Command(kOnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;
            
            try
            {
                Items.Clear();
                var items = await DataStoreNumber.GetItemsAsync(true);
                Console.WriteLine(items.Count());
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
           // SelectedItem = null;
        }

        //public SoSTelephoneNumberItem SelectedItem
        //{
        //    get => _selectedItem;
        //    set
        //    {
        //        SetProperty(ref _selectedItem, value);
        //        OnItemSelected(value);
        //    }
        //}

        //private async void OnAddItem(object obj)
        //{
        //    await Shell.Current.GoToAsync(nameof(NewItemPage));
        //}

        //async void OnItemSelected(SoSTelephoneNumberItem item)
        //{
        //    if (item == null)
        //        return;

        //    // This will push the ItemDetailPage onto the navigation stack
        //    await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        //}

    }
}
