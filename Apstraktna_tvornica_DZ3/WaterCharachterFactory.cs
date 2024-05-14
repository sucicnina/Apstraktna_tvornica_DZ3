using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktna_tvornica_DZ3
{
    public class WaterCharachterFactory : ICharachterFactory
    {
        public IGoblin CreateGoblin()
        {
            return new WaterGoblin();
        }

        public IWizard CreateWizard()
        {
            return new WaterWizard();
        }
    }
}
