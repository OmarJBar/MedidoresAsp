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
            try
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
                if (Page.IsValid)
                {
                    this.mensajeLbl.Text = "Medidor Ingresado Exitosamente !!!";
                    Response.Redirect("VerMedidores.aspx");
                }
                else
                {
                    this.mensajeLbl.Text = "Error";
                    mensajeLbl.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception er)
            {
                this.mensajeLbl.Text = "Error: "+er.Message;
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value=="")
            {
                args.IsValid = false;
            }
            else
            {
                int numero;
                bool verification = int.TryParse(args.Value, out numero);
                if (verification && numero>0 && numero<=1000)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}