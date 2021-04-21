using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.Clases
{
    public class EnviarRHHEventArgs : EventArgs
    {
        public RRHH recHum { get; set; }
        
        public EnviarRHHEventArgs(RRHH rRHH)
        {
            recHum = rRHH;
        }
    }
}
