using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// @Author: Mydleyka Dimanche
/// </summary>

namespace Etudiants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Save Information to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Nom Manquant!");
                return;
            }
            if (txtPrenom1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Prénom1 Manquant!");
                return;
            }
            if (txtPrenom1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Prénom1 Manquant!");
                return;
            }
            if (txtPrenom1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Prénom1 Manquant!");
                return;
            }
            if (txtPrenom1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Prénom1 Manquant!");
                return;
            }
            if (txtPrenom2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Prénom2 Manquant!");
                return;
            }
            if (txtAge.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Age Manquant!");
                return;
            }
            if (txtAdresse.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Adresse Manquant!");
                return;
            }
            if (txtVille.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Ville Manquant!");
                return;
            }
            if (txtTelephone.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Telephone Manquant!");
                return;
            }

            List<Personne> Personnes = new List<Personne> { };


            Personne personne = new Personne(txtNom.Text, txtPrenom1.Text, txtPrenom2.Text, int.Parse(txtAge.Text), txtPays.Text, txtNationalite.Text, txtTelephone.Text, txtVille.Text, txtAdresse.Text,DateTime.Now.ToString("d"));

            Personnes.Add(personne);


          

            // Mettre dans Fichier
            FileInfo fileInfo = new FileInfo(@"personnes.txt");

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            else { 

            using (StreamWriter sw = new StreamWriter(@"personnes.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(personne.Nom + " " + personne.Prenom1 + " " + personne.Prenom2 + " " + personne.Age + " " + personne.Pays + " " + personne.Nationalite + " " + personne.Telephone + " " + personne.Ville + " " + personne.AdresseRue + " " + personne.Datecree);
            }
            }

            ListViewItem listviewItem = new ListViewItem();
            listviewItem.Text = personne.Nom;
            listviewItem.SubItems.Add(personne.Prenom1 + " " + personne.Prenom2);
            listviewItem.SubItems.Add(txtAge.Text);
            listviewItem.SubItems.Add(txtTelephone.Text);

            lvPersonne.Items.Add(listviewItem);
        }

        /// <summary>
        /// Clear all the boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNom.Text = String.Empty;
            txtPrenom1.Text = String.Empty;
            txtPrenom2.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtVille.Text = String.Empty;
            txtAdresse.Text = String.Empty;
            txtTelephone.Text = String.Empty;
            txtNationalite.Text = String.Empty;
            txtPays.Text = String.Empty;

        }
        /// <summary>
        /// Load the information of the file to the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Form1_Load(object sender, EventArgs e)
        {
            lvPersonne.View = View.Details;
            lvPersonne.Clear();
            lvPersonne.Columns.Add("Nom", 150, HorizontalAlignment.Left);
            lvPersonne.Columns.Add("Prénom", 150, HorizontalAlignment.Left);
            lvPersonne.Columns.Add("Age", 150, HorizontalAlignment.Left);
            lvPersonne.Columns.Add("Téléphone", 150, HorizontalAlignment.Left);
            txtNom.Focus();

            string line;

            try
            {
                StreamReader sr = new StreamReader(@"personnes.txt");
                
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] info = line.Split(' ');

                        ListViewItem listviewItem = new ListViewItem();
                        listviewItem.Text = info[0];
                        listviewItem.SubItems.Add(info[1] + " " + info[2]);
                        listviewItem.SubItems.Add(info[3]);
                        listviewItem.SubItems.Add(info[7]);

                        lvPersonne.Items.Add(listviewItem);
                    line = sr.ReadLine();

                }
            }
            catch(Exception j)
            {
                Console.WriteLine(j.Message);
            }

           
            
            
        }

        
    }
}
