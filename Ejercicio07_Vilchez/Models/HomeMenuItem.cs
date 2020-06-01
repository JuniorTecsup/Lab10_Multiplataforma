using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio07_Vilchez.Models
{
    public enum MenuItemType
    {
        
        ViewToViewDemo,
        BindingModeDemo,
        ListViewDemo,
        PickerDemo
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
