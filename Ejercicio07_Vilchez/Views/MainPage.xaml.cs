using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Ejercicio07_Vilchez.Models;

namespace Ejercicio07_Vilchez.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    
                    
                    case (int)MenuItemType.ViewToViewDemo:
                        MenuPages.Add(id, new NavigationPage(new ViewToViewDemo()));
                        break;
                    case (int)MenuItemType.BindingModeDemo:
                        MenuPages.Add(id, new NavigationPage(new BindingModeDemo()));
                        break;
                    case (int)MenuItemType.ListViewDemo:
                        MenuPages.Add(id, new NavigationPage(new ListViewDemo()));
                        break;
                    case (int)MenuItemType.PickerDemo:
                        MenuPages.Add(id, new NavigationPage(new PickerDemo()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}