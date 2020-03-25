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
    public partial class FormSecciones : Form
    {
        SeccionesBL _secciones;
         
        public FormSecciones()
        {
            InitializeComponent();

            _secciones = new SeccionesBL();
            listaSeccionesBindingSource.DataSource = _secciones.ObtenerSecciones();
        }

        private void listaSeccionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaSeccionesBindingSource.EndEdit();
            var seccion = (Seccion)listaSeccionesBindingSource.Current;

            var resultado = _secciones.GuardarSeccion(seccion);

            if (resultado.Exitoso == true)
            {
                listaSeccionesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Seccion guardada");
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _secciones.AgregarSeccion();
            listaSeccionesBindingSource.MoveLast();

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
            var resultado = _secciones.EliminarSeccion(id);

            if (resultado == true)
            {
                listaSeccionesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la seccion.");
            }
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _secciones.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }
    }
}
