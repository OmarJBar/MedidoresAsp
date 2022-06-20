using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UtilsMedidor.DAL;
using UtilsMedidor.DTO;

namespace StarCapWeb
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidor medidorDAL = new MedidorObjects();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {

            int numero = Convert.ToInt32(this.NumeroMed.Text.Trim());

            int tipo = Convert.ToInt32(this.tipoMed.SelectedValue);

            Medidor medidor = new Medidor()
            {
                MedidorNro = numero,
                Tipo = tipo
            };
            //3. Llamar al DAL
            medidorDAL.AgregarMedidor(medidor);
            //4. Mostrar mensajae de exito
            this.mensajeLbl.Text = "Medidor Ingresado Exitosamente !!!";
            Response.Redirect("VerMedidores.aspx");
        }
    }
}