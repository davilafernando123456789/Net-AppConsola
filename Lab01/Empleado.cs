using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    //heredamos de usuario
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }
        //contructor agregadp sueldo
        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }
}
