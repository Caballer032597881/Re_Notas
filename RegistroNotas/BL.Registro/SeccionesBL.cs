using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Registro.AlumnosBL;

namespace BL.Registro
{
    public class SeccionesBL
    {
        Contexto _contexto;

        public BindingList<Seccion> ListaSecciones { get; set; }

        public SeccionesBL()
        {
            _contexto = new Contexto();
            ListaSecciones = new BindingList<Seccion>();
        }

        public BindingList<Seccion> ObtenerSecciones()
        {
            _contexto.Secciones.Load();
            ListaSecciones = _contexto.Secciones.Local.ToBindingList();

            return ListaSecciones;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarSeccion(Seccion seccion)
        {
            var resultado = Validar(seccion);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarSeccion()
        {
            var nuevaSeccion = new Seccion();
            _contexto.Secciones.Add(nuevaSeccion);
        }

        public bool EliminarSeccion(int id)
        {
            foreach (var seccion in ListaSecciones.ToList())
            {
                if (seccion.Id == id)
                {
                    ListaSecciones.Remove(seccion);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }


        private Resultado Validar(Seccion seccion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (seccion == null)
            {
                resultado.Mensaje = "Agregue una seccion valida";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(seccion.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Seccion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
