using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Registro.AlumnosBL;
using static BL.Registro.SeguridadBL;

namespace BL.Registro
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Registro")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
       public DbSet<Transaccion> Transacciones { get; set; }
    }
}
