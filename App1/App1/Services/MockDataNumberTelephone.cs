using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Services
{
    class MockDataNumberTelephone : IDataStore<SoSTelephoneNumberItem>
    {
        readonly List<SoSTelephoneNumberItem> items;

        public MockDataNumberTelephone()
        {
            items = new List<SoSTelephoneNumberItem>()
            {
            new SoSTelephoneNumberItem { Id = Guid.NewGuid().ToString(), Name="", NumberLocal="Местный", NumberTown="Городской" },
            new SoSTelephoneNumberItem { Id = Guid.NewGuid().ToString(), Name = "Пожарная команлда", NumberLocal = "5-15", NumberTown = "+7(383)-337-67-44" },
            new SoSTelephoneNumberItem { Id = Guid.NewGuid().ToString(), Name = "Дежурный здравпункта", NumberLocal = "4-43", NumberTown = "+7(383)-337-54-43" },
            new SoSTelephoneNumberItem { Id = Guid.NewGuid().ToString(), Name = "Начальник караула", NumberLocal = "2-37", NumberTown = "+7(383)-337-74-39" },
            new SoSTelephoneNumberItem { Id = Guid.NewGuid().ToString(), Name = "Диспетчер ремонтной службы", NumberLocal = "3-80", NumberTown = "+7(383)-337-64-68" },
            new SoSTelephoneNumberItem { Id = Guid.NewGuid().ToString(), Name = "Охрана труда", NumberLocal = "3-55", NumberTown = "+7(383)-337-54-60" }
            };

        }

        public async Task<bool> AddItemAsync(SoSTelephoneNumberItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(SoSTelephoneNumberItem item)
        {
            var oldItem = items.Where((SoSTelephoneNumberItem arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((SoSTelephoneNumberItem arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);
            return await Task.FromResult(true);
        }

        public async Task<SoSTelephoneNumberItem> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

       

        public Task<IEnumerable<SoSTelephoneNumberItem>> GetGroupID(EnumProf groupID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SoSTelephoneNumberItem>> GetGroupID(string groupID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SoSTelephoneNumberItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

    }
}
