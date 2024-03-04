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
using Factory.Ingredients.Clam;

namespace Factory.IngredientFactories
{
    internal class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Dough createDough()
        {
            logger.WriteLine("create Dough");
            return new ThickCrustDough();
        }

        public override Sauce createSauce()
        {
            logger.WriteLine("create Sauce");
            return new PlumTomatoSauce();
        }

        public override Cheese createCheese()
        {
            logger.WriteLine("create Cheese");
            return new MozzarellaCheese();
        }

        public override Veggie[] createVeggies()
        {
            logger.WriteLine("create Veggies");
            Veggie[] veggies = {
                new Onion(), new Mushroom(), new GreenPepper()
            };
            return veggies;
        }

        public override Pepperoni createPepperoni()
        {
            logger.WriteLine("create Pepperoni");
            return new CubedPepperoni();
        }

        public override Clams createClams()
        {
            logger.WriteLine("create Clams");
            return new FrozenClams();
        }
    }
}
