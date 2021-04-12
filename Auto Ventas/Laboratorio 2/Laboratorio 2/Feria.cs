using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_2
{
    public abstract class Feria
    {
        protected abstract string nombreFeria { get; set; }
        protected abstract IList<Concepcionaria> concepcionarias { get; set; }
        public Feria()
        {
        }
        public abstract void mostrarDatos();
        public abstract void registrarDatos();
        public abstract void registrarConcepcionaria(Concepcionaria concepcionaria);

    }
}
