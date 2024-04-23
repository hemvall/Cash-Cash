using CashCash.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace cashcash_clientLourd
{
    public partial class FormContrat : Form
    {
        public FormContrat()
        {
            InitializeComponent();
            this.Load += FormContrat_Load;
        }

        private async void FormContrat_Load(object sender, EventArgs e)
        {
            // Appeler la méthode pour charger les données depuis l'API
            await LoadDataFromApi();
        }
        private const string apiUrl = "https://localhost:7000/Contrat";
        private async Task LoadDataFromApi()
        {
            try
            {
                // Créer un client HTTP
                using (var client = new HttpClient())
                {
                    // Appeler l'API et récupérer la réponse
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Vérifier si la réponse est réussie
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Convertir les données JSON en liste d'objets Intervention
                        List<Contrat> contrats = JsonConvert.DeserializeObject<List<Contrat>>(responseBody);

                        // Afficher les données dans le DataGridView
                        dataGridContrat.DataSource = contrats;
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la récupération des données de l'API.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
