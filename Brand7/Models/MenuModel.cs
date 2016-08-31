using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brand7.Models
{
    public class MenuModel
    {
        public BrandCategory Category { get; set; }
        public string Image { get; set; }

        public MenuModel(BrandCategory category)
        {
            Category = category;
            Image = string.Format("Assets/Icons/{0}.png", Category);
        }
    }

    public enum BrandCategory
    {
        Car,
        Life,
        Cater,
        Fashion,
        University,
        Technology,
        AudioOrVedio,
        None
    }
}
