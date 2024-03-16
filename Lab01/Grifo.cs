using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Grifo
    {
        private List<Usuario> usuarios;

        //c onstructor
        public Grifo()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            Console.WriteLine("Lista de Usuarios:");
            //recorremos los usuarios
            foreach (var usuario in usuarios)
            {
                usuario.MostrarInformacion();
            }
        }
    }

}
