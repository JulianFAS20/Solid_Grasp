using System;
using System.Collections.Generic;

namespace SOLID_GRASP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Implementacion_HacerConMiMascota doAnithing = new Implementacion_HacerConMiMascota();
            IHacerConMiMascota hacerConMiMascota = doAnithing as IHacerConMiMascota;
            Perro perro = new Perro();
            Gato gato = new Gato();
            Pez pescado = new Pez();
            List<Mascota> mascotas = new List<Mascota>();

            perro.nombre = "Estuar";
            perro.color = "dorado";
            perro.edad = 7;
            mascotas.Add(perro);

            gato.nombre = "Angel";
            gato.color = "Blanco con negro";
            gato.edad = 9;
            mascotas.Add(gato);

            pescado.nombre = "Nemo";
            pescado.color = "naranja con lineas negras y manchas blancas";
            pescado.edad = 2;
            mascotas.Add(pescado);

            Console.WriteLine(hacerConMiMascota.misMascotas(mascotas));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(hacerConMiMascota.misTiposDeMascotas(mascotas));
        }
    }
}
