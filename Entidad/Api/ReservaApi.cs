using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.Models;

namespace Entidad.Api
{
    public class ReservaApi
    {
        public Reserva rsv { get; set; }
        public List<Servicio> lstSrv { get; set; }
        public ReservaApi(Reserva tmpRsv, List<Servicio> tmpLst)
        {
            rsv = tmpRsv;
            lstSrv = tmpLst;
        }
    }
}
