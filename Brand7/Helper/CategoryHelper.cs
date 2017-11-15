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
                    name = "品车";
                    break;
                case BrandCategory.Walking:
                    name = "旅途";
                    break;
                case BrandCategory.Lifestyle:
                    name = "生活";
                    break;
                case BrandCategory.Cater:
                    name = "吃货";
                    break;
                case BrandCategory.AV:
                    name = "娱乐";
                    break;
                case BrandCategory.Tech:
                    name = "宅男";
                    break;
                case BrandCategory.Fashion:
                    name = "时尚";
                    break;
                case BrandCategory.All:
                    name = "所有品牌";
                    break;
                default:
                    name = "所有品牌";
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
