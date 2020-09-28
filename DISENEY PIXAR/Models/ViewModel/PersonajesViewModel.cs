 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DISENEY_PIXAR.Models.ViewModel
{
    public class PersonajesViewModel
    {
        public String NombreOriginal { get; set; }
        public String Nombre { get; set; }
        public DateTime? FechaEstreno { get; set; }
        public String Descripcion { get; set; }
        public int Id { get; set; }
        public IEnumerable<Apariciones> Apariciones { get; set; }


      

    }
}
