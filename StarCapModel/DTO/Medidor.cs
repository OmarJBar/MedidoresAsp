using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsMedidor.DTO
{
    public class Medidor
    {
        private int medidorNro;
        private int tipo;
        public string TipoTxt
        {
            get
            {
                string tipoTxt = "";
                switch (Tipo)
                {
                    case 1:
                        tipoTxt = "Luz";
                        break;
                    case 2:
                        tipoTxt = "Agua";
                        break;
                }
                return tipoTxt;
            }
        }
        public int MedidorNro { get => medidorNro; set => medidorNro = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
