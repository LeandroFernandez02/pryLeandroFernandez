using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Data;

namespace pryLeandroFernandez3
{
    internal class clsAPI
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string baseUrl = "https://www.dnd5eapi.co";

        public async Task<JObject> GetMonsterDataAsync(string relativeUrl)
        {
            // Construir la URL absoluta
            string absoluteUrl = baseUrl + relativeUrl.Trim();

            // Asegurarse de que la URL es absoluta
            if (!Uri.IsWellFormedUriString(absoluteUrl, UriKind.Absolute))
            {
                throw new ArgumentException("La URL proporcionada no es una URL absoluta: " + absoluteUrl);
            }

            HttpResponseMessage response = await client.GetAsync(absoluteUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JObject.Parse(responseBody);
        }

        public async void seleccionarMonstruo(TreeNodeMouseClickEventArgs e, ListBox lista)
        {
            if (e.Node.Tag is DataRow row)
            {
                string url = row["URL"].ToString().Trim();

                // Imprimir la URL relativa para depuración
                //MessageBox.Show("URL relativa proporcionada: " + url);

                if (!string.IsNullOrEmpty(url))
                {
                    try
                    {
                        JObject data = await GetMonsterDataAsync(url);
                        MostrarDatosMonstruo(data, lista);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener datos del monstruo: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No URL found for this monster.");
                }
            }
        }

        void MostrarDatosMonstruo(JObject data , ListBox lista)
        {                    
            lista.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos datos

            // Añadir todos los datos relevantes al ListBox
            lista.Items.Add("Armor Class: " + data["armor_class"]?.ToString() ?? "N/A");
            lista.Items.Add("Strength: " + data["strength"]?.ToString() ?? "N/A");
            lista.Items.Add("Dexterity: " + data["dexterity"]?.ToString() ?? "N/A");
            lista.Items.Add("Intelligence: " + data["intelligence"]?.ToString() ?? "N/A");
            lista.Items.Add("Wisdom: " + data["wisdom"]?.ToString() ?? "N/A");
            // Añadir más campos según sea necesario            
        }
    }
}
