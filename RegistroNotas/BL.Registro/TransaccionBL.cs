using BL.Registro;
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
    public class TransaccionBL
    {
         Contexto _contexto;   

         public BindingList<Transaccion> ListaTransacciones { get; set; }

        public TransaccionBL()
        {
            _contexto = new Contexto();
        }

        public BindingList<Transaccion> ObtenerTransacciones()
        {
            _contexto.Transacciones.Include("TransaccionDetalle").Load();
            ListaTransacciones = _contexto.Transacciones.Local.ToBindingList();

            return ListaTransacciones;
        }

        public void AgregarTransaccion()
        {
            var nuevaTransaccion = new Transaccion();
            _contexto.Transacciones.Add(nuevaTransaccion);
        }

        public void AgregarTransaccionDetalle(Transaccion transaccion)
        {
            if(transaccion != null)
            {
                var nuevoDetalle = new TransaccionDetalle();
                transaccion.TransaccionDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverTransaccionDetalle(Transaccion transaccion, TransaccionDetalle transaccionDetalle)
        {
            if(transaccion != null && transaccionDetalle != null)
            {
                transaccion.TransaccionDetalle.Remove(transaccionDetalle);
            }
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarTransaccion(Transaccion transaccion)
        {
            var resultado = Validar(transaccion);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        private Resultado Validar(Transaccion transaccion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(transaccion == null)
            {
                resultado.Mensaje = "Agregue una transaccion para poder guardar";
                resultado.Exitoso = false;

                return resultado;
            }

            if (transaccion.Id != 0 )
            {
                resultado.Mensaje = "La transaccion ya fue emitida y no se pueden realizar cambios en ella";
                resultado.Exitoso = false;
            }

            if (transaccion.Id != 0 && transaccion.Activo == true)
            {
                resultado.Mensaje = "La factura ya fue emitida y no se pueden realizar cambios en ella";
                resultado.Exitoso = false;
            }

            if (transaccion.Activo == false)
            {
                resultado.Mensaje = "La factura esta anulada y no se pueden realizar cambios en ella";
                resultado.Exitoso = false;
            }


            if (transaccion.TransaccionDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue alumnos.";
                resultado.Exitoso = false;
            }

            foreach (var detalle in transaccion.TransaccionDetalle)
            {
                if (detalle.AlumnoId == 0)
                {
                    resultado.Mensaje = "Seleccione datos validos";
                    resultado.Exitoso = false;
                }
            }

            return resultado;
        }

        public void CalcularPromedio(Transaccion transaccion)
        {
            if(transaccion != null)
            {
                double subtotal = 0;
                int contador = 0;

                foreach (var detalle in transaccion.TransaccionDetalle)
                {
                    var alumno = _contexto.Alumnos.Find(detalle.AlumnoId);
                    if(alumno != null)
                    {
                        detalle.Nota = alumno.Nota;
                        detalle.Total = detalle.Nota;
                        detalle.ContadorSuma = detalle.Contador;

                        subtotal += detalle.Total;
                        contador += detalle.ContadorSuma;
                    }
                }

                transaccion.Promedio = subtotal / contador;
            }
        }

        public bool AnularRegistro(int id)
        {
            foreach (var transaccion in ListaTransacciones)
            {
                if(transaccion.Id == id){
                    transaccion.Activo = false;
                    _contexto.SaveChanges();
                    return true;
                }
                
            }
            return false;
        }
    }

    public class Transaccion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int MateriaId { get; set; }
        public int SeccionId { get; set; }
        public BindingList<TransaccionDetalle> TransaccionDetalle { get; set; }
        public Materia Materia { get; set; }
        public Seccion Seccion { get; set; }
        public double Promedio { get; set; }
        public bool Activo { get; set; }

        public Transaccion()
        {
            Fecha = DateTime.Now;
            TransaccionDetalle = new BindingList<TransaccionDetalle>();
            Activo = true;
        }
    }

    public class TransaccionDetalle
    {
        public int Id { get; set; }
        public int AlumnoId { get; set; }
        public Alumno Alumno { get; set; }
        public int Contador { get; set; }
        public int Nota { get; set; }
        public double Total { get; set; }
        public int ContadorSuma { get; set; }

        public TransaccionDetalle()
        {
            Contador = 1;
        }
    }

}
