using ServicioColaborador.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioColaborador
{
    
    [ServiceContract]
    public interface IColaboradorService
    {
        [OperationContract]
        List<Colaborador> ListarColaborador();

        [OperationContract]
        Colaborador ObtenerColaborador(int id);
    }
}
