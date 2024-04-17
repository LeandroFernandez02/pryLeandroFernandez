using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace pryLeandroFernandez3
{
    internal class clsConexionBD
    {
        public void conectarBD(ToolStripStatusLabel tstpBD)
        {
            try
            {
                string cadenaConexion = "Server = 127.0.0.1 ; DataBase = juegorol; Uid = root;  Pwd= ;";
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();

                tstpBD.Text = "Conectado";
                tstpBD.BackColor = Color.Green;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }           
        }            
    }
}
