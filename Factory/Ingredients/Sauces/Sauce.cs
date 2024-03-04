using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Sauces
{
    public abstract class Sauce
    {
        private string info;

        public string Info
        {
            get { return info; }
        }

        public Sauce(string info)
        {
            //this.info = $"Sauce: {info}";
            this.info = info;
        }
    }
}
