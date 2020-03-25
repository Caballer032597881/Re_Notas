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
    public class AlumnosBL
    {
        Contexto _contexto;
        public BindingList<Alumno> ListaAlumnos { get; set; }

        public AlumnosBL()
        {
            _contexto = new Contexto();
            ListaAlumnos = new BindingList<Alumno>();
        }

        public BindingList<Alumno> ObtenerAlumnos()
        {
            _contexto.Alumnos.Load();
            ListaAlumnos = _contexto.Alumnos.Local.ToBindingList();
            return ListaAlumnos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        //Método para guardar
        public Resultado GuardarAlumno(Alumno alumno)
        {
            var resultado = Validar(alumno);

            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        //Método para agregar
        public void AgregarAlumno()
        {
            var nuevoAlumno = new Alumno();
            ListaAlumnos.Add(nuevoAlumno);
        }

        //Método para eliminar
        public bool EliminarAlumno(int id)
        {
            foreach (var alumno in ListaAlumnos)
            {
                if(alumno.Id == id)
                {
                    ListaAlumnos.Remove(alumno);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Alumno alumno)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(alumno == null)
            {
                resultado.Mensaje = "Agregue un alumno.";
                resultado.Exitoso = false;

                return resultado;
            }

            if(string.IsNullOrEmpty(alumno.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            if(Convert.ToString(alumno.Anio).Trim().Length > 4)
            {
                resultado.Mensaje = "Ingrese un año correcto";
                resultado.Exitoso = false;
            }

            if (Convert.ToString(alumno.Anio).Trim().Length < 4)
            {
                resultado.Mensaje = "Ingrese un año correcto";
                resultado.Exitoso = false;
            }

            if(Convert.ToString(alumno.Anio) == "")
            {
                resultado.Mensaje = "Ingrese un año.";
                resultado.Exitoso = false;
            }
            
            if(string.IsNullOrEmpty(alumno.NumeroIdentidad) == true)
            {
                resultado.Mensaje = "Ingrese un número de identidad.";
                resultado.Exitoso = false;
            }

           if(Double.IsNaN(alumno.Anio) == true)
            {
                resultado.Mensaje = "Ingrese un año correcto.";
                resultado.Exitoso = false;
            }

           if(alumno.NumeroIdentidad.Length < 13 || alumno.NumeroIdentidad.Length > 13)
            {
                resultado.Mensaje = "Ingrese un número de identidad correcto.";
                resultado.Exitoso = false;
            }

           if(alumno.MateriaId == 0)
            {
                resultado.Mensaje = "Seleccione una materia.";
                resultado.Exitoso = false;
            }

           if(alumno.SeccionId == 0)
            {
                resultado.Mensaje = "Seleccione una seccion.";
                resultado.Exitoso = false;
            }

            if (alumno.CarreraId == 0)
            {
                resultado.Mensaje = "Seleccione una carrera.";
                resultado.Exitoso = false;
            }

            if(alumno.Nota < 0 || alumno.Nota > 100)
            {
                resultado.Mensaje = "Ingrese una nota valida.";
                resultado.Exitoso = false;
            }

            return resultado;
        }

        public class Alumno
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string NumeroIdentidad { get; set; }
            public int CarreraId { get; set; }
            public Carrera Carrera { get; set; }
            public double Anio { get; set; }
            public byte[] Foto  { get; set; }
            public int MateriaId { get; set; }
            public Materia Materia { get; set; }
            public int SeccionId { get; set; }
            public Seccion Seccion { get; set; }
            public int Nota { get; set; }
        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }
    }
}
