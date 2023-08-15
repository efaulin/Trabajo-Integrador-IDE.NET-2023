using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DBContext
    {
        static Datos.DBContext dB = new Datos.DBContext();
        static public Datos.DBContext dBContext { get {  return dB; } }
    }
}
