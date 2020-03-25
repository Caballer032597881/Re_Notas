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
    public partial class FormCarreras : Form
    {
        CarrerasBL _carreras;

        public FormCarreras()
        {
            InitializeComponent();

            _carreras = new CarrerasBL();
            listaCarrerasBindingSource.DataSource = _carreras.ObtenerCarreras();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _carreras.AgregarCarrera();
            listaCarrerasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _carreras.EliminarCarrera(id);

            if (resultado == true)
            {
                listaCarrerasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la carrera");
            }
        }

        private void listaCarrerasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            listaCarrerasBindingSource.EndEdit();
            var carrera = (Carrera)listaCarrerasBindingSource.Current;

            var resultado = _carreras.GuardarCarrera(carrera);

            if (resultado.Exitoso == true)
            {
                listaCarrerasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Carrera guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripCancelar.Visible = !valor;
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _carreras.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
