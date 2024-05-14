using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apstraktna_tvornica_DZ3
{
    public interface ICharachterFactory
    {
        public IWizard CreateWizard();
        public IGoblin CreateGoblin();
    }
}
