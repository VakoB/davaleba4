using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace დავალება4
{
    internal class Martkutxedi: BaseClass2
    {
        private double simagle, partobi;

        public Martkutxedi(double simagle, double fudze)
        {
            this.simagle = simagle;
            this.martkutxedis_fudze = fudze;
        }

        public double Partobi()
        {
            partobi = martkutxedis_fudze * simagle;
            return partobi;
        }
    }
}
