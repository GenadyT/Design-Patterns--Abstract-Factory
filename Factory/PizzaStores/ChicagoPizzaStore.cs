using Factory.IngredientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore() : base(new ChicagoPizzaIngredientFactory()) 
        {
            logger.WriteStoreHeader("Chicago Pizza store");
        }
    }
}
