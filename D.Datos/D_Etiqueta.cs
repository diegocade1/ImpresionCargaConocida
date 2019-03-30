using C_Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Datos
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

        public bool CrearEtiqueta()
        {
            string query = "insert into tbl_etiqueta(guia_aerea,fecha,hora) values (@guia,@fecha,@hora);";
            MySqlCommand cmd;
            try
            {
                if(Conectar())
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
            catch(Exception ex)
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
