using Factory.IngredientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(PizzaIngredientFactory ingrFactory) : base("Pepperoni Pizza", ingrFactory) { }

        protected override void prepareAdding()
        {
            logger.WritePizzaMakeStep("prepare adding");
            pepperoni = ingrFactory.createPepperoni();
        }
    }
}
