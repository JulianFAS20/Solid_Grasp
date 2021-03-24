using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_GRASP
{
    public abstract class Mascota
    {
        public String nombre { get; set; }
        public Int16 edad { get; set; }
        public String color { get; set; }

        public Mascota()
        {

        }

        public abstract String tipoDeMascota();
    }
}
