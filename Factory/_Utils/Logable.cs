using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory._Utils
{
    public class Logable
    {
        protected Logger logger;

        /*public Logable(Logger logger)
        {
            this.logger = logger;
        }*/

        public Logable()
        {
            this.logger = new Logger();
        }

        public string GetLog()
        {
            return logger.Log;
        }
    }
}
