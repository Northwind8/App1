using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace App1.Models
{
    public class Item
    {
        public string[] Images { get; set; }
        public string GroupID { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}