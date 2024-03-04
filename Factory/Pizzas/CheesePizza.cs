using Factory.IngredientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(PizzaIngredientFactory ingrFactory) : base("Cheese Pizza", ingrFactory) { }

        protected override void prepareAdding()
        {
            // Cheese pizza has no addings
        }
    }
}
