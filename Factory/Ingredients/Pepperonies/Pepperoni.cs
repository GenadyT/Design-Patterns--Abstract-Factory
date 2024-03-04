using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Pepperonies
{
    public abstract class Pepperoni
    {
        private string info;

        public string Info
        {
            get { return info; }
        }

        public Pepperoni(string info)
        {
            //this.info = $"Pepperoni: {info}";
            this.info = info;
        }
    }
}
