namespace HomeOnTheRange.Settings
{
    using System.Collections.Generic;

    public class FoodTypes : IFoodTypes
    {
        public List<string> FoodType()
        {
            return new List<string>
            {
                { "Additive" },
                { "Bread" },
                { "Condiment" },
                { "Dairy" },
                { "Fruit" },
                { "Grain" },
                { "Liquid" },
                { "Meat" },
                { "Oil" },
                { "Sauce" },
                { "Spice" },
                { "Vegetable" },
                { "Other" }
            };
        }

        public List<string> FoodProperty()
        {
            return new List<string>
            {
                { "Perishable" },
                { "Non-Perishable" },
                { "Liquid" },
                { "Solid" },
                { "Soft" },
                { "Hard" }
            };
        }
    }
}