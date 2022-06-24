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
    public partial class AgregarLectura : System.Web.UI.Page
    {
        private ILectura lecturaDAL = new ILecturaObjects();
        private IMedidor medidorDAL = new MedidorObjects();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.medidorSerieDd.DataSource = medidores;
                this.medidorSerieDd.DataTextField = "medidorNro";
                this.medidorSerieDd.DataValueField = "medidorNro";
                this.medidorSerieDd.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            int idlectura = Convert.ToInt32(this.NumeroLectura.Text.Trim());
            string fechatxt = this.fechaLectura.SelectedDate.ToShortDateString();
            double consumo = Convert.ToDouble(this.consumoLectura.Text.Trim());            
            int medidorValor = Convert.ToInt32(this.medidorSerieDd.SelectedValue);
            string hora()
            {
                string hour = this.horaTxt.Text.Trim();
                string min = this.minutoTxt.Text.Trim();
                string text =(hour + ":" + min);
                return text;
            }

            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            Medidor medidor = medidores.Find(m=>m.MedidorNro==medidorValor);

            Lectura lectura = new Lectura()
            {
                IdLectura = idlectura,
                Medidor = medidor,
                Hora = hora(),
                Fecha = Convert.ToDateTime(fechatxt),
                Consumo = consumo
            };
            lecturaDAL.AgregarLectura(lectura);
            this.mensajeLbl.Text = "Lectura Ingresada";
            Response.Redirect("VerLecturas.aspx");
        }
    }
}
