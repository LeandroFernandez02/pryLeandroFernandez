using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using TreeView = System.Windows.Forms.TreeView;
using pryLeandroFernandez2;

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

        public void cargarJugadorBD(string nombre, int puntaje)
        {
            try
            {
                string cadenaConexion = "Server = 127.0.0.1 ; DataBase = juegorol; Uid = root;  Pwd= ;";
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                //-------------------------
  
                // Query SQL para insertar datos
                string query = "INSERT INTO jugadores (Nombre, Puntaje) VALUES (@Nombre, @Puntaje)";

                // Crear el comando con parámetros
                using (MySqlCommand comando = new MySqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Puntaje", puntaje);

                    // Ejecutar el comando
                    comando.ExecuteNonQuery();
                }
                   

                MessageBox.Show("Jugador y puntaje guardados correctamente.");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void cargarTrv(TreeView trv, ToolStripStatusLabel tstpBD)
        {
            string cadenaConexion = "Server=127.0.0.1;DataBase=juegorol;Uid=root;Pwd=;";
            string consulta = "SELECT type, name, armor_class, strength, wisdom, intelligence, dexterity FROM monstruario";

            // Limpiar TreeView antes de cargar los datos
            trv.Nodes.Clear();

            // Agregar el nodo raíz "Monstruario"
            TreeNode rootNode = new TreeNode("Monstruario");
            trv.Nodes.Add(rootNode);

            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                MySqlCommand command = new MySqlCommand(consulta, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();

                    tstpBD.Text = "Conectado";
                    tstpBD.BackColor = Color.Green;

                    adapter.Fill(dataSet);

                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        string tipoMonstruo = row["type"].ToString();
                        string nombreMonstruo = row["name"].ToString();

                        TreeNode tipoNode = rootNode.Nodes.Find(tipoMonstruo, false).FirstOrDefault();

                        // Si el nodo del tipo de monstruo no existe, créalo
                        if (tipoNode == null)
                        {
                            tipoNode = new TreeNode(tipoMonstruo);
                            tipoNode.Name = tipoMonstruo;
                            rootNode.Nodes.Add(tipoNode);
                        }

                        TreeNode monsterNode = new TreeNode(nombreMonstruo);
                        monsterNode.Tag = row; // Almacena el DataRow en el Tag del nodo
                        tipoNode.Nodes.Add(monsterNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el TreeView: " + ex.Message);
                }
            }
        }

        public void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e, Label lblFuerza, Label lblDestreza, Label lblVelocidad, Label lblInteligencia, Label lblDanio)
        {
            // Obtener el nodo seleccionado
            TreeNode selectedNode = e.Node;

            // Verificar si el nodo seleccionado tiene un DataRow asociado
            if (selectedNode.Tag is DataRow row)
            {
                // Mostrar los datos en las etiquetas
                lblFuerza.Text = "Armadura: " + row["armor_class"].ToString();
                lblDestreza.Text = "Fortaleza: " + row["strength"].ToString();
                lblVelocidad.Text = "sabiduria: " + row["wisdom"].ToString();
                lblInteligencia.Text = "Inteligencia: " + row["intelligence"].ToString();
                lblDanio.Text = "Destreza: " + row["dexterity"].ToString();
            }
        }
    }
}
