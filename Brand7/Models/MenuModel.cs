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
        public string Name { get; set; }

        public MenuModel(BrandCategory category)
        {
            Category = category;
            switch (category)
            {
                case BrandCategory.Car:
                    Name = "CAR";
                    break;
                case BrandCategory.University:
                    Name = "UNIVERSITY";
                    break;
                case BrandCategory.Life:
                    Name = "LIFESTYLE";
                    break;
                case BrandCategory.Cater:
                    Name = "FOOD & CATER";
                    break;
                case BrandCategory.Fashion:
                    Name = "SPORTS & FASHION";
                    break;
                case BrandCategory.Technology:
                    Name = "IT & TECHNOLOGY";
                    break;
                case BrandCategory.AudioOrVedio:
                    Name = "AUDIO & VEDIO";
                    break;
                default:
                    Name = category.ToString();
                    break;
            }
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
