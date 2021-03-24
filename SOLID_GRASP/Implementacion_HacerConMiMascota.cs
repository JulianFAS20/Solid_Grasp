using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_GRASP
{
    public class Implementacion_HacerConMiMascota : IHacerConMiMascota
    {
        public String misMascotas(List<Mascota> mascotas) 
        {
            String respuesta = "Mis mascotas son: ";
            foreach (Mascota mascota in mascotas)
            {
                respuesta += "\n" + mascota.nombre;
            }
            return respuesta;
        }

        public String misTiposDeMascotas(List<Mascota> mascotas)
        {
            String respuesta = "Mis mascotas son: ";
            foreach (Mascota mascota in mascotas)
            {
                respuesta += "\n" + mascota.nombre + " " + mascota.tipoDeMascota();
            }
            return respuesta;
        }
    }
}
