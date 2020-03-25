using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Registro
{
    public class SeguridadBL
    {
        Contexto _contexto;


        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autenticar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return true;
                }
            }

            return false;
        }

        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Contrasena { get; set; }

        }
       
    }
}
