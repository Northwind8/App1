using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using App1.Models;
using App1.Views;

namespace App1.ViewModels
{
    [QueryProperty(nameof(GroupID), nameof(GroupID))]
    public class ItemsViewModel : BaseViewModel
    {
        private Item _selectedItem;

        public ObservableCollection<Item> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }

        public ItemsViewModel()
        {
            Title = "Просмотр";
            Items = new ObservableCollection<Item>();
           // LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            LoadItemsCommand = new Command(async () => await LoadItemsGroup(GroupID));

            ItemTapped = new Command<Item>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }
        public async Task LoadItemsGroup(string groupID)
        {
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await DataStore.GetGroupID(groupID);

                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
            finally
            {
                IsBusy = false;
            }
        }
        private string groupID;
        public string GroupID
        {
            get
            {
                return groupID;
            }
            set
            {
                groupID = value;
                LoadItemsGroup(value);
            }
        }

    


        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
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
            SelectedItem = null;
        }

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(Item item)
        {
            if (item == null)
                return;
            
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}