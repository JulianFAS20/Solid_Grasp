using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_GRASP
{
    public interface IHacerConMiMascota
    {
        public String misMascotas(List<Mascota> mascotas);

        public String misTiposDeMascotas(List<Mascota> mascotas);
    }
}
