using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public class AutoConcepcionaria:Concepcionaria
    {
        public AutoConcepcionaria()
        {
            nombreAdministrador = "";
            propietario = "";
        }
        public override void registrarDatos()
        {
            Console.Write("Ingrese el nombre de la concepcionaria: ");
            nombreConcepcionaria = Console.ReadLine();
            Console.Write("Ingrese el nombre del Administrador: ");
            nombreAdministrador = Console.ReadLine();
            Console.Write("Ingrese el nombre del Propietario: ");
            propietario = Console.ReadLine();

        }
        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Administrador: " + nombreAdministrador);
            Console.WriteLine("Propietario: " + propietario);


        }
        public override void registrarVehiculos()
        {
            Auto auto = new Auto();
            Console.Clear();
            Console.WriteLine("Ingrese los datos del nuevo auto");
            auto.registrarDatosAuto();
            vehiculos.Add(auto);
        }
        public override void agregarVehiculo(Auto auto)
        {
            vehiculos.Add(auto);
        }
        public override void mostrarVehiculos()
        {

            foreach (var auto in vehiculos)
            {
                auto.mostrarDatosAuto();
            }
        }

    }
}
