namespace Brand7.Models
{
    class CategoryHelper
    {
        public static string GetCategoryName(BrandCategory category)
        {
            string name;

            switch (category)
            {
                case BrandCategory.Car:
                    name = "CAR";
                    break;
                case BrandCategory.Walking:
                    name = "TRIP&EMS";
                    break;
                case BrandCategory.Lifestyle:
                    name = "LIFESTYLE";
                    break;
                case BrandCategory.Cater:
                    name = "FOOD&CATER";
                    break;
                case BrandCategory.AV:
                    name = "AUDIO&VEDIO";
                    break;
                case BrandCategory.Tech:
                    name = "IT&TECHNOLOGY";
                    break;
                case BrandCategory.Fashion:
                    name = "SPORTS&FASHION";
                    break;
                case BrandCategory.All:
                    name = "ALL BRANDS";
                    break;
                default:
                    name = "ALL BRANDS";
                    break;
            }

            return name;
        }
    }

    public enum BrandCategory
    {
        Car,
        Walking,
        Lifestyle,
        Cater,
        AV,
        Tech,
        Fashion,
        All
    }
}
