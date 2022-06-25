using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsMedidor.DTO;

namespace UtilsMedidor.DAL
{
    public interface ILectura
    {
        bool AgregarLectura(Lectura lectura);
        List<Lectura> ObtenerMedidores();
        void Eliminar(int lectura);

        List<Lectura> FiltrarMedidores(int lectura);
    }
}
