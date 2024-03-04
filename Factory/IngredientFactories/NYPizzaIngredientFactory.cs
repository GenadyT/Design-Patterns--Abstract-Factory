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
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Dough createDough()
        {
            logger.WriteLine("create Dough");
            return new ThinCrustDough();
        }

        public override Sauce createSauce()
        {
            logger.WriteLine("create Sauce");
            return new MarinaraSauce();
        }

        public override Cheese createCheese()
        {
            logger.WriteLine("create Cheese");
            return new ReggianaCheese();
        }

        public override Veggie[] createVeggies()
        {
            logger.WriteLine("create Veggies");
            Veggie[] veggies = {
                new Garlic(), new Onion(), new Mushroom(), new RedPepper()
            };
            return veggies;
        }

        public override Pepperoni createPepperoni()
        {
            logger.WriteLine("create Pepperoni");
            return new SlicedPepperoni();
        }

        public override Clams createClams()
        {
            logger.WriteLine("create Clams");
            return new FreshClams();
        }
    }
}
