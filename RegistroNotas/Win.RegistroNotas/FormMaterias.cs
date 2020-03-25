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
    public partial class FormMaterias : Form
    {
        MateriasBL _materias;

        public FormMaterias()
        {
            InitializeComponent();

            _materias = new MateriasBL();

            listaMateriasBindingSource.DataSource = _materias.ObtenerMaterias();
        }

        private void listaMateriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            listaMateriasBindingSource.EndEdit();
            var materia = (Materia)listaMateriasBindingSource.Current;

            var resultado = _materias.GuardarMateria(materia);

            if (resultado.Exitoso == true)
            {
                listaMateriasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Materia guardado");
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
            toolStripButton1.Visible = !valor;
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
            var resultado = _materias.EliminarMateria(id);

            if (resultado == true)
            {
                listaMateriasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la materia");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _materias.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _materias.AgregarMateria();
            listaMateriasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }
    }
}
