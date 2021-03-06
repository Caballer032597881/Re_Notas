﻿using BL.Registro;
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
    public partial class FormReporteA : Form
    {
        public FormReporteA()
        {
            InitializeComponent();

            var _productoBL = new AlumnosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _productoBL.ObtenerAlumnos();

            var reporte = new ReporteAlumnos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
