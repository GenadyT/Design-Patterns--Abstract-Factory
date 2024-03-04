using Factory._Utils;
using Factory.IngredientFactories;
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

namespace Factory.Pizzas
{
    public abstract class Pizza : Logable
    {
        private string name;
        public string Name { get { return name; } }
        
        //-------------------
        private Dough dough;
        private Sauce sauce;
        private Cheese cheese;
        //-------------------
        protected Veggie[] veggies;
        protected Pepperoni pepperoni;
        protected Clams clams;
        //-------------------

        protected PizzaIngredientFactory ingrFactory;

        protected Pizza(string name, PizzaIngredientFactory ingrFactory)
        {
            this.name = name;
            this.ingrFactory = ingrFactory;

            logger.WritePizzaHeader(this.name);
        }

        private void prepareBasing()
        {
            logger.WritePizzaMakeStep("prepare basing");

            dough = ingrFactory.createDough();
            sauce = ingrFactory.createSauce();
            cheese = ingrFactory.createCheese();
            
            logger.WriteItemLine($"dough: {dough.Info},  sauce: {sauce.Info},  cheese: {cheese.Info}");
        }

        public void MakePizza()
        {
            //logger.WriteLine("Make Pizza");

            preparePizza();
            lastSteps();
        }

        protected abstract void prepareAdding();

        //---------------------------------
        private void preparePizza()
        {   
            prepareBasing();
            prepareAdding();
        }
        private void lastSteps()
        {
            logger.WritePizzaMakeStep("the 3 last steps");

            logger.WriteItemLine($"1. {bake()}");
            logger.WriteItemLine($"2. {cut()}");
            logger.WriteItemLine($"3. {box()}");
        }
        //---------------------------------

        string bake()
        {
            return "Bake for 25 minutes at 350";
        }

        string cut()
        {
            return "Cutting the pizza diagonal slices";
        }

        string box()
        {
            return "Place pizza in official PizzaStore box";
        }
    }
}
