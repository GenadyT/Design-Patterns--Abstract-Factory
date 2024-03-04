using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Cheeses
{
    public abstract class Cheese
    {
        private string info;

        public string Info
        {
            get { return info; }
        }

        public Cheese(string info)
        {
            //this.info = $"Cheese: {info}";
            this.info = info;
        }
    }
}
