using ServicioColaborador.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioColaborador.Persistencia
{
    public class ColaboradorDAO
    {

        private string CadenaConexion = "Data Source=305a4753-766f-4c06-b100-a60c0046e39d.sqlserver.sequelizer.com;Database=db305a4753766f4c06b100a60c0046e39d;Initial Catalog=db305a4753766f4c06b100a60c0046e39d;User Id=oytjmyrazbvivilj; Password=ToLz4HuFLd3g7XqckzCHPQc6QPYDsgzupYqpUqQ8KpTzdHcfTXjyZZNdkPSnSYnE";

        public List<Colaborador> ListarColaborador()
        {
            List<Colaborador> colaboradoresEncontrado = new List<Colaborador>();
            Colaborador colaboradorEncontrado = null;
            string sql = "SELECT  id_colaborador,c_dni,c_nombres,c_apellidos,c_fech_nac,c_fech_ingreso,c_cargo,AR.a_descripcion AS area,ES.e_descripcion AS estado FROM T_Colaborador AS CO INNER JOIN T_Area AS AR ON CO.id_area=AR.id_area INNER JOIN T_Estado AS ES ON CO.id_estado=ES.id_estado";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            colaboradorEncontrado = new Colaborador()
                            {

                                Id = (int)resultado["id_colaborador"],
                                Dni = (string)resultado["c_dni"],
                                Nombres = (string)resultado["c_nombres"],
                                Apellidos = (string)resultado["c_apellidos"],
                                FechaNac = (string)resultado["c_fech_nac"],
                                Cargo = (string)resultado["c_cargo"],
                                Area = (string)resultado["area"],
                                Estado = (string)resultado["estado"],

                            };
                            colaboradoresEncontrado.Add(colaboradorEncontrado);
                        }
                    }

                }

            }
            return colaboradoresEncontrado;
        }




        public Colaborador ObtenerColaborador(int id)
        {
            Colaborador colaboradorEncontrado = null;
            string sql = "SELECT  id_colaborador,c_dni,c_nombres,c_apellidos,c_fech_nac,c_fech_ingreso,c_cargo,AR.a_descripcion AS area,ES.e_descripcion AS estado FROM T_Colaborador AS CO INNER JOIN T_Area AS AR ON CO.id_area=AR.id_area INNER JOIN T_Estado AS ES ON CO.id_estado=ES.id_estado WHERE id_colaborador=@id";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            colaboradorEncontrado = new Colaborador()
                            {
                                Id = (int)resultado["id_colaborador"],
                                Dni = (string)resultado["c_dni"],
                                Nombres = (string)resultado["c_nombres"],
                                Apellidos = (string)resultado["c_apellidos"],
                                FechaNac = (string)resultado["c_fech_nac"],
                                Cargo = (string)resultado["c_cargo"],
                                Area = (string)resultado["area"],
                                Estado = (string)resultado["estado"],

                            };
                        }
                    }
                }
            }

            return colaboradorEncontrado;
        }




        public List<Colaborador> ListarColaboradorXPendiente()
        {
            List<Colaborador> colaboradoresEncontrado = new List<Colaborador>();
            Colaborador colaboradorEncontrado = null;
            string sql = "SELECT  id_colaborador,c_dni,c_nombres,c_apellidos,c_fech_nac,c_fech_ingreso,c_cargo,AR.a_descripcion AS area,ES.e_descripcion AS estado FROM T_Colaborador AS CO INNER JOIN T_Area AS AR ON CO.id_area=AR.id_area INNER JOIN T_Estado AS ES ON CO.id_estado=ES.id_estado WHERE ES.e_descripcion='Pendiente'";
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            colaboradorEncontrado = new Colaborador()
                            {

                                Id = (int)resultado["id_colaborador"],
                                Dni = (string)resultado["c_dni"],
                                Nombres = (string)resultado["c_nombres"],
                                Apellidos = (string)resultado["c_apellidos"],
                                FechaNac = (string)resultado["c_fech_nac"],
                                Cargo = (string)resultado["c_cargo"],
                                Area = (string)resultado["area"],
                                Estado = (string)resultado["estado"],

                            };
                            colaboradoresEncontrado.Add(colaboradorEncontrado);
                        }
                    }

                }

            }
            return colaboradoresEncontrado;
        }



    }
}