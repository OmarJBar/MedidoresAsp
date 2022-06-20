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
                        tipoTxt = "Silver";
                        break;
                    case 2:
                        tipoTxt = "Gold";
                        break;
                    case 3:
                        tipoTxt = "Platinum";
                        break;
                }
                return tipoTxt;
            }
        }
        public int MedidorNro { get => medidorNro; set => medidorNro = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
