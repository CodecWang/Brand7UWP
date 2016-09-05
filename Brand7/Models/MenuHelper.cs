using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brand7.Models
{
    class MenuHelper
    {
        public static void GetMenuList(ObservableCollection<MenuModel> menuList)
        {
            menuList.Add(new MenuModel(BrandCategory.Car));
            menuList.Add(new MenuModel(BrandCategory.Express));
            menuList.Add(new MenuModel(BrandCategory.Lifestyle));
            menuList.Add(new MenuModel(BrandCategory.Cater));
            menuList.Add(new MenuModel(BrandCategory.AV));
            menuList.Add(new MenuModel(BrandCategory.Tech));
            menuList.Add(new MenuModel(BrandCategory.Fashion));
        }
    }
}
