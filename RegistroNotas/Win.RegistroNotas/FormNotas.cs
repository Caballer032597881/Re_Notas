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
    public partial class FormNotas : Form
    {
        TransaccionBL _transaccionBL;
        AlumnosBL _alumnoBL;
        MateriasBL _materiaBL;
        SeccionesBL _seccionBL;

        public FormNotas()
        {
            InitializeComponent();

            _transaccionBL = new TransaccionBL();
            listaTransaccionesBindingSource.DataSource = _transaccionBL.ObtenerTransacciones();

            _alumnoBL = new AlumnosBL();
            listaAlumnosBindingSource.DataSource = _alumnoBL.ObtenerAlumnos();

            _materiaBL = new MateriasBL();
            listaMateriasBindingSource.DataSource = _materiaBL.ObtenerMaterias();

            _seccionBL = new SeccionesBL();
            listaSeccionesBindingSource.DataSource = _seccionBL.ObtenerSecciones();


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _transaccionBL.AgregarTransaccion();
            listaTransaccionesBindingSource.MoveLast();
            DesahilitarHabilitarBotones(false);
        }

        private void DesahilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listaTransaccionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaTransaccionesBindingSource.EndEdit();

            var transaccion = (Transaccion)listaTransaccionesBindingSource.Current;
            var resultado = _transaccionBL.GuardarTransaccion(transaccion);

            if (resultado.Exitoso == true)
            {
                listaTransaccionesBindingSource.ResetBindings(false);
                DesahilitarHabilitarBotones(true);
                MessageBox.Show("¡Guardado!.");
            }else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DesahilitarHabilitarBotones(true);
            _transaccionBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var transaccin = (Transaccion)listaTransaccionesBindingSource.Current;
            _transaccionBL.AgregarTransaccionDetalle(transaccin);
            DesahilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var transaccion = (Transaccion)listaTransaccionesBindingSource.Current;
            var transaccionDetalle = (TransaccionDetalle)transaccionDetalleBindingSource.Current;
            _transaccionBL.RemoverTransaccionDetalle(transaccion, transaccionDetalle);

            DesahilitarHabilitarBotones(false); 
        }

        private void transaccionDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void transaccionDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var transaccion = (Transaccion)listaTransaccionesBindingSource.Current;
            _transaccionBL.CalcularPromedio(transaccion);

            listaTransaccionesBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea anular este registro?", "Anular", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _transaccionBL.AnularRegistro(id);

            if(resultado == true)
            {
                listaTransaccionesBindingSource.ResetBindings(false);
            }else
            {
                MessageBox.Show("Ocurrio un error al anular el registro.");
            }
        }

        private void listaTransaccionesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var transaccion = (Transaccion)listaTransaccionesBindingSource.Current;

            if(transaccion != null && transaccion.Id != 0 && transaccion.Activo == false)
            {
                label1.Visible = true;
            }else
            {
                label1.Visible = false;
            }
        }
    }
}
