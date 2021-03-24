using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_GRASP
{
    public class Pez : Mascota, IMascotaDeAgua, IMascota
    {
        public override String tipoDeMascota()
        {
            return "Pezcado";
        }

        public String habitadDeAgua()
        {
            return "Este animal vive en el mar";
        }

        public String comer()
        {
            return "Este animal se alimenta";
        }
    }
}
