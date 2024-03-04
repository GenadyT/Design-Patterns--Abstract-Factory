using Factory.IngredientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    internal class VeggiPizza : Pizza
    {
        public VeggiPizza(PizzaIngredientFactory ingrFactory) : base("Veggi Pizza", ingrFactory) { }

        protected override void prepareAdding()
        {
            logger.WritePizzaMakeStep("prepare adding");
            veggies = ingrFactory.createVeggies();

            string[] veggStrArr = veggies.Select(vg => vg.Info).ToArray();
            string veggStr = String.Join(", ", veggStrArr);

            logger.WriteItemLine($"veggies: {veggStr}");
        }
    }
}
