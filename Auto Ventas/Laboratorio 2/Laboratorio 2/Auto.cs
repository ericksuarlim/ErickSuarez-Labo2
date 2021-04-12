using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public class Auto : IVehiculo, IMotor

    {


        public int cilindrada { get; set; }
        public string combustible { get; set; }
        public int anio { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }

        public Auto()
        {

        }

        public void mostrarDatosMotor()
        {
            Console.WriteLine("      Cilindrada: " + cilindrada + "HP");
            Console.WriteLine("      Combustible: " + combustible );
        }

        public void registrarDatosMotor()
        {
            Console.Write("Ingrese la Cilindrada: ");
            cilindrada = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ingrese el Combustible: ");
            combustible = Console.ReadLine();
        }

        public void mostrarDatosVehiculo()
        {
            Console.WriteLine("      Marca: " + marca);
            Console.WriteLine("      Modelo: " + modelo);
            Console.WriteLine("      Anio: " + anio);
        }

        public void registrarDatosVehiculo()
        {
            Console.Write("Ingrese la Marca: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese el Modelo: ");
            modelo = Console.ReadLine();
            Console.Write("Ingrese el anio: ");
            anio = Convert.ToInt16(Console.ReadLine());
        }

        public void vehiculoProbando()
        {
            Console.Write("El vehiculo se encuntra en Pruebas!!!");
        }

        public void vehiculoCorriendo()
        {
            Console.Write("El vehiculo esta corriendo!!!");
        }

        public void mostrarDatosAuto()
        {
            Console.WriteLine("----------Datos del vehiculo----------");
            mostrarDatosVehiculo();
            mostrarDatosMotor();
        }

        public void registrarDatosAuto()
        {
            registrarDatosVehiculo();
            registrarDatosMotor();
        }


    }
}
