using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsMedidor.DTO;

namespace UtilsMedidor.DAL
{
    public class MedidorObjects : IMedidor
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void Eliminar(int medidorNro)
        {
            Medidor eliminando = medidores.Find(c => c.MedidorNro == medidorNro);
            medidores.Remove(eliminando);
        }

        public List<Medidor> FiltrarMedidores(int medidor)
        {
            return medidores.FindAll(me=>me.MedidorNro==medidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }        
    }
}
