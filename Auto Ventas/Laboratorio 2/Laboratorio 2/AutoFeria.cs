using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public class AutoFeria : Feria
    {
        protected override string nombreFeria { get; set; }
        protected override IList<Concepcionaria> concepcionarias { get ; set; }
        public string mes { get; set; }
        public int diaInicio { get; set; }
        public int diaFin { get; set; }

        public AutoFeria()
        {
            concepcionarias = new List<Concepcionaria>();
            Concepcionaria concepcionaria = new Concepcionaria();
            concepcionaria.nombreConcepcionaria = "Nisbol";
            concepcionaria.nombreAdministrador = "Hernan Rojas";
            concepcionaria.propietario = "Carlos Quispe";
            concepcionarias.Add(concepcionaria);
        }
        public override void mostrarDatos()
        {
            Console.WriteLine("----Datos de la Feria----");
            Console.WriteLine("Nombre: " + nombreFeria);
            Console.WriteLine("Mes: " + mes);
            Console.WriteLine("Dia Inicio: " + diaInicio);
            Console.WriteLine("Dia Fin: " + diaFin);
        }
        public override void registrarDatos()
        {
            Console.Write("Ingrese Nombre de la feria: ");
            nombreFeria = Console.ReadLine();
            Console.Write("Ingrese Mes: ");
            mes = Console.ReadLine();
            Console.Write("Ingrese dia inicio: ");
            diaInicio = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese dia fin: ");
            diaFin = Convert.ToInt16(Console.ReadLine());
        }

        public override void registrarConcepcionaria(Concepcionaria concepcionaria)
        {
            concepcionarias.Add(concepcionaria);
        }


        public void mostrarConcepcionarias()
        {
            foreach (var concepcionaria in concepcionarias)
            {
                concepcionaria.mostrarDatos();
            }
        }
        public Concepcionaria buscarConcepcionaria(string nombre)
        {
            foreach (var concepcionaria in concepcionarias)
            {
                if (concepcionaria.nombreConcepcionaria == nombre)
                    return concepcionaria;
            }
            return null;
        }
        public void agregarConcepcionaria()
        {
            Concepcionaria autoconcepcionaria = new AutoConcepcionaria();
            autoconcepcionaria.registrarDatos();
            concepcionarias.Add(autoconcepcionaria);
        }
        public void mostrarVehiculosPorConcepcionarias()
        {
            string Nombre;
            Console.Write("Ingrese el nombre de la concepcionaria: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("----------Lista de Vehiculos------");
            var concepcionaria = buscarConcepcionaria(Nombre);
            if (concepcionaria != null)
                concepcionaria.mostrarVehiculos();
            else
                Console.WriteLine("No existe la concepcionaria ingresada, intente de nuevo");
        }
        public void agregarVehiculoAConcepcionaria()
        {
            string Nombre;
            Console.Write("Ingrese el nombre de la concepcionaria: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("----------Lista de Vehiculos------");
            var concepcionaria = buscarConcepcionaria(Nombre);
            if (concepcionaria != null)
            {
                Auto auto = new Auto();
                auto.registrarDatosAuto();
                concepcionaria.agregarVehiculo(auto);
            }
            else
                Console.WriteLine("No existe la concepcionaria ingresada, intente de nuevo");
        }
        public void menu()
        {

            int Opcion;
            do
            {
                Console.WriteLine("--------Menu--------");
                Console.WriteLine("1. Mostrar Datos de la feria");
                Console.WriteLine("2. Añadir concepcionaria");
                Console.WriteLine("3. Mostrar concepcionarias");
                Console.WriteLine("4. Mostrar vehiculos de una concepcionaria");
                Console.WriteLine("5. Añadir vehiculo a una concepcionaria");
                Console.WriteLine("0. Salir");
                Opcion = Convert.ToInt16(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        mostrarDatos();
                        break;
                    case 2:
                        agregarConcepcionaria();
                        break;
                    case 3:
                        mostrarConcepcionarias();
                        break;
                    case 4:
                        mostrarVehiculosPorConcepcionarias();
                        break;
                    case 5:
                        agregarVehiculoAConcepcionaria();
                        break;
                    default:
                        break;
                }
            } while (Opcion != 0);
        }
    }
}
