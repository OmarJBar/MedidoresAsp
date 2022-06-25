using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsMedidor.DTO;

namespace UtilsMedidor.DAL
{
    public class ILecturaObjects : ILectura
    {
        private static List<Lectura> lecturas = new List<Lectura>();

        public bool AgregarLectura(Lectura lectura)
        {
            try
            {
                lecturas.Add(lectura);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public void Eliminar(int lectura)
        {
            Lectura eliminar = lecturas.Find(l => l.IdLectura == lectura);
            lecturas.Remove(eliminar);
        }

        public List<Lectura> FiltrarMedidores(int lectura)
        {
            return lecturas.FindAll(me => me.IdLectura == lectura);
        }

        public List<Lectura> ObtenerMedidores()
        {
            return lecturas;
        }
    }
}
