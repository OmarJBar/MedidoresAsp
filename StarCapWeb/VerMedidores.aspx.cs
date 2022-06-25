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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidor medidorDAL = new MedidorObjects();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                this.grillaMedidores.DataSource = medidores;
                this.grillaMedidores.DataBind();
            }
        }
        private void cargaGrilla()
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }
        private void cargaGrilla(List<Medidor> filtrada)
        {
            List<Medidor> medidores = medidorDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }

        protected void tipofil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tipofil.SelectedItem != null)
            {
                int tipo = Convert.ToInt32(this.tipofil.SelectedItem.Value);
                List<Medidor> filtrotipo = medidorDAL.FiltrarMedidores(tipo);
                cargaGrilla(filtrotipo);
            }
        }
    }
}