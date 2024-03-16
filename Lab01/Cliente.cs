using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Cliente : Usuario
    {
        //Agregamos litros cargados
        public double LitrosCargados { get; set; }

        //Constr...
        public Cliente(string nombre, double saldo, double litrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        //el metodo vitual
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Litros Cargados: {LitrosCargados}");
        }
    }
}
