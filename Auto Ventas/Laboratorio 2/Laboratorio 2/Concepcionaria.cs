using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public class Concepcionaria
    {
        public string nombreConcepcionaria { get; set; }
        public string nombreAdministrador { get; set; }
        public string propietario { get; set; }
        public IList<Auto> vehiculos;

        public Concepcionaria()
        {
            nombreConcepcionaria = "";
            vehiculos = new List<Auto>();
            vehiculos.Add(
                new Auto()
                {
                    marca = "Toyota",
                    modelo = "Hilux",
                    cilindrada = 1600,
                    combustible = "Gasolina",
                    anio = 2020,

                }
            );
            vehiculos.Add(
                new Auto()
                {
                    marca = "Nisan",
                    modelo = "Patrol",
                    cilindrada = 4000,
                    combustible = "Diesel",
                    anio = 2001,
                }
            );
            vehiculos.Add(
                new Auto()
                {
                    marca = "Ford",
                    modelo = "Vista",
                    cilindrada = 2400,
                    combustible = "Gasolina",
                    anio = 2014,
                }
            ); vehiculos.Add(
                 new Auto()
                 {
                     marca = "Datsun",
                     modelo = "Xc20",
                     cilindrada = 5600,
                     combustible = "Diesel",
                     anio = 1992,
                 }
             );

        }

        public virtual void registrarDatos() { }

        public virtual void agregarVehiculo(Auto auto) { }

        public virtual void mostrarDatos()
        {
            Console.WriteLine("-----Concepcionaria----");
            Console.WriteLine("Nombre Concepcionaria: " + nombreConcepcionaria);
        }

        public virtual void registrarVehiculos() { }
        public virtual void mostrarVehiculos() { }

    }
}
