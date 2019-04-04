using Entidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Etiqueta : D_MySQL
    {
        private E_Etiqueta _etiqueta1;
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }


        public E_Etiqueta Etiqueta
        {
            get { return _etiqueta1; }
            set { _etiqueta1 = value; }
        }

        public List<E_Etiqueta> ListaEtiquetasFecha(string inicio, string fin)
        {
            string query = "SELECT * FROM tbl_etiqueta where fecha between @inicio and @fin;";
            MySqlCommand cmd;
            List<E_Etiqueta> temp = new List<E_Etiqueta>();
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@inicio", inicio);
                    cmd.Parameters.AddWithValue("@fin", fin);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Etiqueta objeto1 = new E_Etiqueta();

                            objeto1.Correlativo = Convert.ToInt32(reader["correlativo"]);
                            objeto1.Guia_aerea = Convert.ToString(reader["guia_aerea"]);
                            objeto1.Fecha = Convert.ToString(reader["fecha"]);
                            objeto1.Hora = Convert.ToString(reader["hora"]);

                            temp.Add(objeto1);
                        }
                        Desconectar();
                        return temp;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }

        }

        public List<E_Etiqueta> ListaEtiquetasGuia(string guia)
        {
            string query = "SELECT * FROM tbl_etiqueta where guia_aerea = @guia;";
            MySqlCommand cmd;
            List<E_Etiqueta> temp = new List<E_Etiqueta>();
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@guia", guia);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            E_Etiqueta objeto1 = new E_Etiqueta();

                            objeto1.Correlativo = Convert.ToInt32(reader["correlativo"]);
                            objeto1.Guia_aerea = Convert.ToString(reader["guia_aerea"]);
                            objeto1.Fecha = Convert.ToString(reader["fecha"]);
                            objeto1.Hora = Convert.ToString(reader["hora"]);

                            temp.Add(objeto1);
                        }
                        Desconectar();
                        return temp;
                    }
                    else
                    {
                        _mensaje = "No se encontraron resultados";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return null;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return null;
            }

        }

        public bool CrearEtiqueta()
        {
            string query = "insert into tbl_etiqueta(guia_aerea,fecha,hora) values (@guia,@fecha,@hora);";
            MySqlCommand cmd;
            try
            {
                if (Conectar())
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@guia", _etiqueta1.Guia_aerea);
                    cmd.Parameters.AddWithValue("@fecha", _etiqueta1.Fecha);
                    cmd.Parameters.AddWithValue("@hora", _etiqueta1.Hora);

                    cmd.ExecuteNonQuery();
                    _etiqueta1.Correlativo = Ultimo_ID();
                    Desconectar();
                    return true;
                }
                else
                {
                    _mensaje = "Error en la conexion a la base de datos";
                    return false;
                }
            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                Desconectar();
                return false;
            }

        }

        public int Ultimo_ID()
        {
            string aux = "0";
            string query;
            MySqlDataReader rst;


            query = "select LAST_INSERT_ID() as UltimoID";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                rst = cmd.ExecuteReader();
                if (rst.Read())
                {
                    aux = rst["UltimoID"].ToString();
                }
                else
                {
                    aux = "0";
                }
                rst.Close();
                cmd.Dispose();


            }
            catch (Exception ex)
            {
                _mensaje = ex.Message;
                aux = "0";
            }

            return Convert.ToInt32(aux);
        }
    }
}
