using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionClases.DTO
{
    public class DatoDTO
    {
        private int id;
        private float flujo;
        private float nivel;
        private float temperatura;
        private float voltaje;
        private BancoDTO banco;
        private CeldaDTO celda;

        private static List<DatoDTO> datos = new List<DatoDTO>()
        {
            new DatoDTO() { id = 1, flujo = 0, nivel = 0, temperatura = 0, voltaje = 0 },
            new DatoDTO() { id = 2, flujo = 1.1f, nivel = 2.0f, temperatura = 4.3f, voltaje = 1.1f },
            new DatoDTO() { id = 2, flujo = 2.3f, nivel = 3.0f, temperatura = 3.1f, voltaje = 2.0f }
        };

        public int Id { get => id; set => id = value; }
        public float Flujo { get => flujo; set => flujo = value; }
        public float Nivel { get => nivel; set => nivel = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float Voltaje { get => voltaje; set => voltaje = value; }
        public BancoDTO Banco { get => banco; set => banco = value; }
        public CeldaDTO Celda { get => celda; set => celda = value; }

        public DatoDTO()
        {
           
        }

        public DatoDTO(int id, float flujo, float nivel, float temperatura, float voltaje, BancoDTO banco, CeldaDTO celda)
        {
            this.Banco = new BancoDTO();
            this.Celda = new CeldaDTO();
            this.id = id;
            this.flujo = flujo;
            this.nivel = nivel;
            this.temperatura = temperatura;
            this.voltaje = voltaje;
            this.Banco = banco;
            this.Celda = celda;
        }

        public static bool Add(DatoDTO nuevosDatos)
        {
            try
            {
                datos.Add(nuevosDatos);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static List<DatoDTO> List()
        {
            return datos;
        }

        public static int Find(int id)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i].id == id)
                {
                    return i;
                }
            }
            
            return -1;
        }

        public static DatoDTO Find(DatoDTO dato)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i].id == dato.Id)
                {
                    return datos[i];
                }
            }

            return new DatoDTO();
        }

        public static bool Remove(int id)
        {
            int idEncontrado = Find(id);

            if (idEncontrado >= 0)
            {
                datos.RemoveAt(idEncontrado);
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
