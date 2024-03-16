using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    //Clase usuario
    public class Usuario
    {
        public string Nombre { get; set; }
        public double Saldo { get; set; }

        //Contructor
        public Usuario(string nombre, double saldo)
        {
            Nombre = nombre;
            Saldo = saldo;
        }

        //Mostrar informacion con el virtual
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombres: {Nombre}, Saldo: {Saldo}");
        }
    }
}
