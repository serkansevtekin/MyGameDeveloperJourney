using System;

namespace BuilderDesignBurgerNameSpace
{

    //Product (Hamburger)
    //Oluşturulan nesne
    public class Burger
    {
        private List<string> _ingredients = new();
        public string? Name { get; set; } // tür adı

        public void AddIngredient(string ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public void ShowBurger()
        {
            System.Console.WriteLine($"\n{Name} içeriği: "); // dinamik başlık
            _ingredients.ForEach(item => System.Console.WriteLine(" - " + item));
        }
    }
}