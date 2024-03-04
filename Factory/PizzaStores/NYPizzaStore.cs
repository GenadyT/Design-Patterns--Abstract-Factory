using Factory.IngredientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore() : base(new NYPizzaIngredientFactory()) {
            logger.WriteStoreHeader("New York Pizza store");
        }
    }
}
