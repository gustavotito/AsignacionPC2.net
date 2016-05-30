using ServicioColaborador.Dominio;
using ServicioColaborador.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioColaborador
{
    
    public class ColaboradorService : IColaboradorService
    {
        ColaboradorDAO colaboradorDAO = new ColaboradorDAO();

        public List<Colaborador> ListarColaborador()
        {
            return colaboradorDAO.ListarColaborador();
        }

        public Colaborador ObtenerColaborador(int id)
        {
            return colaboradorDAO.ObtenerColaborador(id);
        }

        public List<Colaborador> ListarColaboradorXPendiente()
        {
            return colaboradorDAO.ListarColaboradorXPendiente();
        }



    }
}
