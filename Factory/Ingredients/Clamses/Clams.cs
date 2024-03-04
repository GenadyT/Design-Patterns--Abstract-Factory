using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Clamses
{
    public abstract class Clams
    {
        private string info;

        public string Info
        {
            get { return info; }
        }

        public Clams(string info)
        {
            //this.info = $"Clams: {info}";
            this.info = info;
        }
    }
}
