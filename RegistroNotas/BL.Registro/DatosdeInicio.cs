using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Registro.SeguridadBL;

namespace BL.Registro
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "Admin1";
            usuarioAdmin.Contrasena = "0123";

            contexto.Usuarios.Add(usuarioAdmin);

            var carrera1 = new Carrera();
            carrera1.Descripcion = "Administracion de Empresas";

            var carrera2 = new Carrera();
            carrera2.Descripcion = "Contaduria y finanzas";

            var carrera3 = new Carrera();
            carrera3.Descripcion = "Matematicas";

            contexto.Carreras.Add(carrera1);
            contexto.Carreras.Add(carrera2);
            contexto.Carreras.Add(carrera3);

            var materia1 = new Materia();
            materia1.Descripcion = "Español";

            var materia2 = new Materia();
            materia2.Descripcion = "Matematicas";

            var materia3 = new Materia();
            materia3.Descripcion = "Historia";

            var materia4 = new Materia();
            materia4.Descripcion = "Sociologia";

            contexto.Materias.Add(materia1);
            contexto.Materias.Add(materia2);
            contexto.Materias.Add(materia3);
            contexto.Materias.Add(materia4);

            var seccion1 = new Seccion();
            seccion1.Descripcion = "S1";

            var seccion2 = new Seccion();
            seccion2.Descripcion = "S2";

            var seccion3 = new Seccion();
            seccion3.Descripcion = "S3";

            contexto.Secciones.Add(seccion1);
            contexto.Secciones.Add(seccion2);
            contexto.Secciones.Add(seccion3);
            
            base.Seed(contexto);
        }
    }
}
