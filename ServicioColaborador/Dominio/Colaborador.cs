using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServicioColaborador.Dominio
{
    [DataContract]
    public class Colaborador
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Dni { get; set; }

        [DataMember]
        public string Nombres { get; set; }

        [DataMember]
        public string Apellidos { get; set; }

        [DataMember]
        public string FechaNac { get; set; }

        [DataMember]
        public string FechaIng { get; set; }

        [DataMember]
        public string Cargo { get; set; }

        [DataMember]
        public string Area { get; set; }

        [DataMember]
        public string Estado { get; set; }


    }
}