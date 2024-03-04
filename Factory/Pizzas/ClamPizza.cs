using Factory.IngredientFactories;
using Factory.Ingredients;
using Factory.Ingredients.Cheeses;
using Factory.Ingredients.Doughs;
using Factory.Ingredients.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    internal class ClamPizza : Pizza
    {
        public ClamPizza(PizzaIngredientFactory ingrFactory) : base("Clam Pizza", ingrFactory) { }

        protected override void prepareAdding()
        {
            logger.WritePizzaMakeStep("prepare adding");
            clams = ingrFactory.createClams();
            logger.WriteItemLine($"clams: {clams.Info}");
        }
    }
}
