using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_GRASP
{
    public class Perro : Mascota
    {
        public override String tipoDeMascota() 
        {
            return "Perro";
        }

        public String comer()
        {
            return "Este animal se alimenta";
        }

        public String habitadTerrestre()
        {
            return "Este animal es de tierra";
        }
    }
}
