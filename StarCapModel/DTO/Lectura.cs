using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilsMedidor.DTO;

namespace UtilsMedidor.DTO
{
    public class Lectura
    {
        private int idLectura;
        private Medidor medidor;
        private DateTime fecha;
        private string hora;
        private double consumo;
        
        public int IdLectura { get => idLectura; set => idLectura = value; }
        public Medidor Medidor { get => medidor; set => medidor = value; }
        public string Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Consumo { get => consumo; set => consumo = value; }
    }
}
