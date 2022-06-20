using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsMedidor.DTO;

namespace UtilsMedidor.DAL
{
    public interface IMedidor
    {
        void AgregarMedidor(Medidor medidor);
        List<Medidor> ObtenerMedidores();
        void Eliminar(int medidorNro);

        List<Medidor> FiltrarMedidores(int medidor);
    }
}
