using Factory._Utils;
using Factory.Ingredients.Cheeses;
using Factory.Ingredients.Clamses;
using Factory.Ingredients.Doughs;
using Factory.Ingredients.Pepperonies;
using Factory.Ingredients.Sauces;
using Factory.Ingredients.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IngredientFactories
{
    public abstract class PizzaIngredientFactory : Logable
    {
        public abstract Dough createDough();
        public abstract Sauce createSauce();
        public abstract Cheese createCheese();
        public abstract Veggie[] createVeggies();
        public abstract Pepperoni createPepperoni();
        public abstract Clams createClams();
    }
}
