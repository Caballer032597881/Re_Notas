using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using static BL.Registro.AlumnosBL;

namespace BL.Registro
{
    public class CarrerasBL
    {
        Contexto _contexto;

        public BindingList<Carrera> ListaCarreras { get; set; }

        public CarrerasBL()
        {
            _contexto = new Contexto();
            ListaCarreras = new BindingList<Carrera>();
        }

        public BindingList<Carrera> ObtenerCarreras()
        {
            _contexto.Carreras.Load();
            ListaCarreras = _contexto.Carreras.Local.ToBindingList();

            return ListaCarreras;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCarrera(Carrera carrera)
        {
            var resultado = Validar(carrera);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCarrera()
        {
            var nuevaCarrera = new Carrera();
            _contexto.Carreras.Add(nuevaCarrera);
        }

        public bool EliminarCarrera(int id)
        {
            foreach (var carrera in ListaCarreras.ToList())
            {
                if (carrera.Id == id)
                {
                    ListaCarreras.Remove(carrera);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }


        private Resultado Validar(Carrera carrera)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (carrera == null)
            {
                resultado.Mensaje = "Agregue una carrera valida";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(carrera.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Carrera
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
