using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktna_tvornica_DZ3
{
    public class FireCharachterFactory : ICharachterFactory
    {
        public IGoblin CreateGoblin()
        {
            return new FireGoblin();
        }

        public IWizard CreateWizard()
        {
            return new FireWizard();
        }
    }
}
