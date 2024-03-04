using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Doughs
{
    public abstract class Dough
    {
        private string info;

        public string Info
        {
            get { return info; }
        }

        public Dough(string info)
        {
            //this.info = $"Dough: {info}";
            this.info = info;
        }
    }
}
