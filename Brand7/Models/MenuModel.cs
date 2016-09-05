namespace Brand7.Models
{
    public class MenuModel
    {
        public BrandCategory Category { get; set; }
        public string Name { get; set; }

        public MenuModel(BrandCategory category)
        {
            Category = category;
            Name = CategoryHelper.GetCategoryName(category);
        }
    }
}
