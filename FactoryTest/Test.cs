using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.PizzaStores;
using Factory.Pizzas;
using Factory._Utils;

namespace FactoryTest
{
    internal class Test : Factory._Utils.Logable
    {
        public void Run()
        {
            //logger.StartLog();
            
            PizzaStore pizzaStore;
            Pizza pizza;

            pizzaStore = new NYPizzaStore();
            logger.WriteLine(pizzaStore.GetLog());
            //------------------------------------
            pizza = pizzaStore.createPizza(Factory.Pizzas.PizzaTypes.Clam);
            logger.WriteLine(pizza.GetLog());
            pizza = pizzaStore.createPizza(Factory.Pizzas.PizzaTypes.Veggie);
            logger.WriteLine(pizza.GetLog());

            pizzaStore = new ChicagoPizzaStore();
            logger.WriteLine(pizzaStore.GetLog());
            //------------------------------------
            pizza = pizzaStore.createPizza(Factory.Pizzas.PizzaTypes.Clam);
            logger.WriteLine(pizza.GetLog());
            pizza = pizzaStore.createPizza(Factory.Pizzas.PizzaTypes.Veggie);
            logger.WriteLine(pizza.GetLog());

            //logger.EndLog();
        }
        
        
        
    }
}
