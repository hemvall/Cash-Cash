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
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace cashcash_clientLourd
{
    public partial class FormIntervention : Form
    {
        public FormIntervention()
        {
            InitializeComponent();
            this.Load += FormIntervention_Load;
        }

        private async void FormIntervention_Load(object sender, EventArgs e)
        {
            // Appeler la méthode pour charger les données depuis l'API
            await LoadDataFromApi();
        }

        private const string apiUrl = "https://localhost:7000/Intervention";
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
                        List<Intervention> interventions = JsonConvert.DeserializeObject<List<Intervention>>(responseBody);

                        // Afficher les données dans le DataGridView
                        dataGridViewInterventions.DataSource = interventions;
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

            try
            {
                // Créer un client HTTP
                using (var client = new HttpClient())
                {
                    // Appeler l'API et récupérer la réponse
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7000/Client");

                    // Vérifier si la réponse est réussie
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Convertir les données JSON en liste d'objets Intervention
                        List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(responseBody);
                        // Afficher les données dans le DataGridView
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

            try
            {
                // Créer un client HTTP
                using (var client = new HttpClient())
                {
                    // Appeler l'API et récupérer la réponse
                    HttpResponseMessage response = await client.GetAsync("https://localhost:7000/Employe");

                    // Vérifier si la réponse est réussie
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Convertir les données JSON en liste d'objets Intervention
                        List<Employe> employes = JsonConvert.DeserializeObject<List<Employe>>(responseBody);
                        // Afficher les données dans le DataGridView

                        foreach (Employe e in employes)
                        {
                            //lBoxEmployés.Items.Add(e.NumEmploye);*
                            RadioButton radio = new RadioButton();
                            radio.Text = e.NumEmploye.ToString();
                            this.Controls.Add(radio);   
                            radio.PointToClient(new Point(360, 250));
                        }
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Close();
        }

        private void btnXml_click(object sender, EventArgs e)
        {
            if (dataGridViewInterventions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à enregistrer en XML.");
                return;
            }

            // Créer une nouvelle instance de XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            // Créer l'élément racine
            XmlElement root = xmlDoc.CreateElement("Data");
            xmlDoc.AppendChild(root);

            // Récupérer les données de la ligne sélectionnée
            DataGridViewRow selectedRow = dataGridViewInterventions.SelectedRows[0];

            // Créer un élément pour chaque colonne et ajouter les données
            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                XmlElement element = xmlDoc.CreateElement(dataGridViewInterventions.Columns[cell.ColumnIndex].Name);
                element.InnerText = cell.Value.ToString();
                root.AppendChild(element);
            }

            // Enregistrer le fichier XML
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fichiers XML (*.xml)|*.xml";
            saveFileDialog.Title = "Enregistrer en XML";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    xmlDoc.Save(sw);
                }
                MessageBox.Show("Données enregistrées en XML avec succès.");
            }
        }
    }
}

