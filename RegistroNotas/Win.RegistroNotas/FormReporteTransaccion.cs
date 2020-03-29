using BL.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.RegistroNotas
{
    public partial class FormReporteTransaccion : Form
    {
        public FormReporteTransaccion()
        {
            InitializeComponent();
            var _transaccionBL = new TransaccionBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _transaccionBL.ObtenerTransacciones();

            var reporte = new ReporteTransaccion();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
