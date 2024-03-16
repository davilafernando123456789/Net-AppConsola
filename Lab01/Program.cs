// See https://aka.ms/new-console-template for more information
using Lab01;

Console.WriteLine("Hello, World!");

Grifo grifo = new Grifo();

bool salir = false;
while (!salir)
{
    Console.WriteLine("**********----Menú---***********:");
    Console.WriteLine("1. Mostrar información de usuarios");
    Console.WriteLine("2. Agregar cliente");
    Console.WriteLine("3. Agregar empleado");
    Console.WriteLine("4. Salir");
    Console.Write("Selecciona una opción: ");
    
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1"://Mostramos usuarios
            grifo.MostrarUsuarios();
            break;

        case "2"://agregamos cliente
            Console.Write("Ingrese nombre del cliente: ");
            string nombreCliente = Console.ReadLine();
            Console.Write("Ingrese saldo del cliente: ");
            double saldoCliente = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese litros cargados del cliente: ");
            double litrosCargadosCliente = Convert.ToDouble(Console.ReadLine());
            Cliente nuevoCliente = new Cliente(nombreCliente, saldoCliente, litrosCargadosCliente);
            grifo.AgregarUsuario(nuevoCliente);
            break;


        case "3"://agregar empleado
            Console.Write("Ingrese nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();
            Console.Write("Ingrese saldo del empleado: ");
            double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese sueldo del empleado: ");
            double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());
            Empleado nuevoEmpleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
            grifo.AgregarUsuario(nuevoEmpleado);
            break;

        case "4":
            salir = true;
            break;

        default:
            Console.WriteLine("Ingresa un numero valido.");
            break;
    }
}
