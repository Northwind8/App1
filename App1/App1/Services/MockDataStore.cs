using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using App1.Models;
using Xamarin.Forms;

namespace App1.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { GroupID = EnumProf.helmet.ToString(), Id = Guid.NewGuid().ToString(), Text = "Общее положение", Description="Информация..." },
                new Item { GroupID = EnumProf.helmet.ToString(), Id = Guid.NewGuid().ToString(), Text = "Первое помощь при поражении электрическим током", Description="Информация..." },
                new Item { GroupID = EnumProf.helmet.ToString(), Id = Guid.NewGuid().ToString(), Text = "Последовательность действий при оказании первой медицинской помощи", Description="Информация..." },
                new Item { GroupID = EnumProf.helmet.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила определения признаков клинической смерти и реанимационные возможности", Description="Информация..." },
                new Item { GroupID = EnumProf.helmet.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила определения пульса на сонной артерии", Description="Информация..." },
                new Item { GroupID = EnumProf.helmet.ToString(), Id = Guid.NewGuid().ToString(), Text = "Анатомические ориентиры, необходимы для проведения сердечно-легочной реанимации", Description="Информация..." },
                new Item { GroupID = EnumProf.electrician.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила проведения непрямого массажа сердца и безвентиляционной реанимации", Description="Информация..." },

                new Item { GroupID = EnumProf.electrician.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила проведения вдоха ИВЛ", Description="Информация..." },
                new Item { GroupID = EnumProf.electrician.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила проведения вдоха ИВЛ", Description="Информация..." },
                new Item { GroupID = EnumProf.electrician.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила проведения вдоха ИВЛ", Description="Информация..." },
                new Item { GroupID = EnumProf.electrician.ToString(), Id = Guid.NewGuid().ToString(), Text = "Правила проведения вдоха ИВЛ", Description="Информация..." },

                new Item { Images = new [] {"helmet.png", "craneDriver.png"}, GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Выполнение обязанностей (допуск)", Description="К выполнению обязанностей электрогазосварщика допускаются лица не моложе 18 лет, прошедшие специальное техническое обучение, аттестованные квалификационной комиссией с присвоением соответствующего разряда, прошедшие медицинское освидетельствование, вводный инструктаж, первичный инструктаж на рабочем месте, стажировку и проверку знаний по охране труда, имеющие II группу по электробезопасности" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "CИЗ", Description="Электрогазосварщик обеспечивается спецодеждой и средствами  индивидуальной защиты в соответствии с нормами бесплатной выдачи СИЗ" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Сварочные работы", Description="Производство сварочных работ с приставных  лестниц запрещается" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Работа вблизи сварочного аппарата", Description="По правилам техники безопасности вблизи работы сварочного аппарата не должно находиться легковоспламеняющихся предметов" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Расположение баллонов", Description="Баллоны с газом также не должны располагаться около места ведения работ – минимальное расстояние должно составлять 5 метров. Если речь идет о баллонах с горючими газами, то они должны находиться вообще за пределами помещения в специальных стальных шкафах и быть надежно закреплены, чтобы исключить возможность их падения" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Зажигание газовых горелок", Description="Для зажигания газовых горелок запрещается использовать обычные спички – для этого существуют специальные зажигалки." },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Напряжение электрической горелки", Description="Если  сварка производится с помощью горелки, работающей от электрического тока, то здесь очень важно проследить, чтобы подходящее к горелке напряжение не превышало 36 В" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Состояние электропроводов", Description="Кроме того, необходимо следить и за состоянием электропроводов – они должны быть надежно изолированы. Использовать провода с поврежденной изоляцией запрещено" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Материал рукоятки горелки", Description="Рукоятка используемой при сварке горелки должна быть изготовлена из специального материала, не допускающего ожог или удар электрическим током" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Приточно-вытяжная вентиляция", Description="В помещении, где производятся сварочные работы, должна быть обязательно установлена приточно-вытяжная вентиляция, обеспечивающая постоянный доступ свежего воздуха и вытяжку продуктов горения" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Возникновение пожара", Description="При возникновении пожара вызвать пожарную команду по телефону 5-15, а до ее прибытия тушить пожар имеющимися в цехе средствами" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Сварка пластмассовых изделий", Description="Если производится сварка пластмассовых изделий, то необходимо следить за тем, чтобы на рабочем месте сварщика присутствовало хорошее освещение – это позволит сделать качественный сварной шов и вовремя заметить возможные неполадки в работе оборудования" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Питание ацетиленом и кислородом от баллонов", Description="При питании ацетиленом и кислородом от баллонов, баллоны устанавливать в вертикальном положении в специальных стойках с закреплением их хомутами, цепочками или тросиками. Установка стоек с баллонами в границах проездов и проходов запрещается. Запрещается хранить баллоны без предохранительных колпаков" },
                new Item { GroupID = EnumProf.welder.ToString(), Id = Guid.NewGuid().ToString(), Text = "Неисправности в оборудовании", Description="О всех замеченных неисправностях в оборудовании, на рабочем месте и о возникших опасностях немедленно сообщить администрации участка" }



            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where(arg => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }


        public async Task<IEnumerable<Item>> GetGroupID(string groupID)
        {
            return await Task.FromResult(items.Where(x => x.GroupID == groupID));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        //public async Task<IEnumerable<Item>> GetGroupID(string groupID)
        //{
        //    return await Task.FromResult(items.Where(x => x.GroupID == groupID));
        //}
    }
}