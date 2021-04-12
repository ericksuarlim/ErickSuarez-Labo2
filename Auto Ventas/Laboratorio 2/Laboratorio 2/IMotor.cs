using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public interface IMotor
    {
        int cilindrada { get; set; }
        string combustible { get; set; }
        void registrarDatosMotor();
        void mostrarDatosMotor();
    }
}
