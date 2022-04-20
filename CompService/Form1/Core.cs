using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Core
    {
        private static CompServiceEntities context;

        public static CompServiceEntities Context
        {
            get => context ?? (context = new CompServiceEntities());
        }

        private Core() { }
    }
}
