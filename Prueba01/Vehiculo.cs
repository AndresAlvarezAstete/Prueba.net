using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba01
{
    abstract class Vehiculo
    {
        // private = modificador de acceso
        // public
        // protected
        private Motor _motor;

        protected Vehiculo(string id, TipoMotor tipoMotor, int cilindrada)
        {
            _motor = new Motor(id, tipoMotor, cilindrada);
        }

        internal Motor Motor { get => _motor; set => _motor = value; }
    }
}
