using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Veggies
{
    public abstract class Veggie
    {
        private string info;

        public string Info
        {
            get { return info; }
        }

        public Veggie(string info)
        {
            //this.info = $"Veggie: {info}";
            this.info = info;
        }
    }
}
