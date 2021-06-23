using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMCrossMigration.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
        private MenuViewModel menu;
        public MenuViewModel Menu
        {
            get { return menu; }
            set
            {
                if (menu != value)
                {
                    menu = value;
                    RaisePropertyChanged();
                }
            }
        }

        private DetailViewModel detail;
        public DetailViewModel Detail
        {
            get { return detail; }
            set
            {
                if (detail != value)
                {
                    detail = value;
                    RaisePropertyChanged();
                }
            }
        }


        public RootViewModel()
        {
            Menu = new MenuViewModel();
            Detail = new DetailViewModel();
        }

    }
}
