using Factory._Utils;
using Factory.IngredientFactories;
using Factory.Ingredients;
using Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PizzaStores
{
    public abstract class PizzaStore : Logable
    {
        private PizzaIngredientFactory ingredientFactory;

        private string name;
        public string Name { get { return name; } }        

        public PizzaStore(PizzaIngredientFactory ingredientFactory) 
        {
            this.ingredientFactory = ingredientFactory;
        }

        public Pizza createPizza(PizzaTypes pt)
        {
            Pizza pizza;
            
            switch (pt)
            {
                case PizzaTypes.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    break;
                case PizzaTypes.Veggie:
                    pizza = new VeggiPizza(ingredientFactory);
                    break;
                case PizzaTypes.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    break;
                default:
                    pizza = new CheesePizza(ingredientFactory);
                    break;
            }

            pizza.MakePizza();
            logger.WriteLine(pizza.GetLog());

            return pizza;
        }
    }
}
