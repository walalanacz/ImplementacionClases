using ImplementacionClases.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionClases.DAL
{
    public class DatoDAL
    {
        public bool Insertar(DatoDTO datos)
        {
            return DatoDTO.Add(datos);
        }

        public bool Actualizar(DatoDTO datos)
        {
            return false;
        }

        public bool Eliminar(DatoDTO datos)
        {
            return false;
        }

         public List<DatoDTO> List()
        {
            return DatoDTO.List();
        }
    }
}
