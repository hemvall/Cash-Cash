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
using System.IO;
using System.Xml;

namespace cashcash_clientLourd
{

    public partial class FormContrat : Form
    {
           
        List<Materiel> listMateriels = new List<Materiel>();
        List<Materiel> listMaterielsContrats = new List<Materiel>();
        List<Materiel> listMaterielsWithoutContrats = new List<Materiel>();


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
        private const string apiClientUrl = "https://localhost:7000/CLient";
        private async Task LoadDataFromApi()
        {
            try
            {
                // Créer un client HTTP
                using (var client = new HttpClient())
                {
                    // Appeler l'API et récupérer la réponse
                    HttpResponseMessage response = await client.GetAsync(apiClientUrl);

                    // Vérifier si la réponse est réussie
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Convertir les données JSON en liste d'objets Intervention
                        List<Client> clients = JsonConvert.DeserializeObject<List<Client>>(responseBody);

                        // Afficher les données dans le DataGridView
                        dataGridClient.DataSource = clients;
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

            const string apiMaterielUrl = "https://localhost:7000/Materiel";
            try
            {
                // Créer un client HTTP
                using (var client = new HttpClient())
                {
                    // Appeler l'API et récupérer la réponse
                    HttpResponseMessage response = await client.GetAsync(apiMaterielUrl);

                    // Vérifier si la réponse est réussie
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Convertir les données JSON en liste d'objets Intervention
                        listMateriels = JsonConvert.DeserializeObject<List<Materiel>>(responseBody);
                        MessageBox.Show(listMateriels.ToString());
                        // Afficher les données dans le DataGridView
                        //dataGridClient.DataSource = materiel;
                        
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

        private void btnExportXml_Click(object sender, EventArgs e)
        {
            if (dataGridClient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à enregistrer en XML.");
                return;
            }

            // Créer une nouvelle instance de XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            // Créer l'élément racine
            XmlElement root = xmlDoc.CreateElement("listeMateriel");
            xmlDoc.AppendChild(root);

            // Récupérer les données de la ligne sélectionnée
            DataGridViewRow selectedRow = dataGridClient.SelectedRows[0];
            object value = selectedRow.Cells["numClient"].Value;
            int numClientValue = (int)value;
            //MessageBox.Show(numClientValue.ToString());


            foreach(Materiel m in listMateriels)
            {
                MessageBox.Show(m.ToString());
                if(m.NumContrat != null && m.NumClient == numClientValue)
                {
                    listMaterielsContrats.Add(m);
                } else if (m.NumContrat == null && m.NumClient == numClientValue)
                {
                    listMaterielsWithoutContrats.Add(m);
                }
            }


            XmlElement elementWithContrat = xmlDoc.CreateElement("sousContrat");
            foreach(Materiel m in listMaterielsContrats)
            {
                elementWithContrat.InnerText = m.ToString();
            }
            root.AppendChild(elementWithContrat);

            XmlElement elementWithoutContrat = xmlDoc.CreateElement("horsContrat");
            root.AppendChild(elementWithoutContrat);
            foreach (Materiel m in listMaterielsWithoutContrats)
            {
                elementWithoutContrat.InnerText = m.ToString();
            }
            root.AppendChild(elementWithoutContrat);
            
            
            // listMateriels


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