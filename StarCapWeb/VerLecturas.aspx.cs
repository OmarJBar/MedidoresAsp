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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILectura lecturaDAL = new ILecturaObjects();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargaGrilla();
            }
        }
        private void cargaGrilla()
        {
            List<Lectura> lectura = lecturaDAL.ObtenerMedidores();
            this.grillaLecturas.DataSource = lectura;
            this.grillaLecturas.DataBind();
            /*List<Lectura> lecturaMedidor = lecturaDAL.ObtenerMedidores();
            this.MedidoresDdl.DataSource = lecturaMedidor;
            this.MedidoresDdl.DataTextField = "Medidor.MedidorNro";
            this.MedidoresDdl.DataValueField = "Medidor";
            this.MedidoresDdl.DataBind();*/
        }

        private void cargaGrilla(List<Lectura> filtrada)
        {
            List<Lectura> lectura = lecturaDAL.ObtenerMedidores();
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }
        protected void grillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //  pendiente
        }
    }
}