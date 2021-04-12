using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public interface IVehiculo
    {
        string marca { get; set; }
        string modelo { get; set; }
        void vehiculoProbando();
        void vehiculoCorriendo();
        void registrarDatosVehiculo();
        void mostrarDatosVehiculo();
    }
}
