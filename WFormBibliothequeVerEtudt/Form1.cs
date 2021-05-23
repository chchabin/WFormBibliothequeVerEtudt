using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libBibliotheque;

namespace WFormBibliotheque
{
    public partial class Form1 : Form
    {
        Bibliotheque b = Bibliotheque.getInstance();
        public Form1()
        {
            InitializeComponent();
        }
        #region fonctions utiles
        /// <summary>
        /// Charge les listBox des auteurs et des livres
        /// </summary>
        private void chargerListe()
        {
            string ligne = null;
            for (int i = 1; i < b.nbAuteurs(); i++)
            {
                ligne = $"{b.getAuteur(i).getNom()}";
                listBox1.Items.Add(ligne);
            }
            // Chargement des livres par nom

        }
        /// <summary>
        /// Fournir une  liste sans doublons des genre des livres
        /// </summary>
        /// <returns>Un tableau des genres</returns>
        private string[] listeGenre()
        {
            string genre = null;
            string[] listeGenre = new string[50];
            bool flag = true;
            listeGenre[0] = b.getLivre(1).getGenre();
            int j = 0;
            //Double boucle pour charger le tableau
            // boucle 1 pour lire la liste de livre
            // boucle 2 pour verifier que le genre n'existe pas déjà dans le tableau
            return listeGenre;

        }
        /// <summary>
        /// Charge le combobox des genres
        /// </summary>
        private void chargerGenre()
        {
            int i = 0;
                // boucle pour charger les genre dans le combobox
        }
        #endregion
        #region Gestion des évènements
        private void Form1_Load(object sender, EventArgs e)
        {
            chargerListe();
            chargerGenre();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ligne = null;
            string nomAuteur = listBox1.SelectedItem.ToString();
            Auteur auteur = b.getAuteur(nomAuteur);

            label9.Text = auteur.ToString();
            string[] prenom = auteur.ToString().Split('\t');

            textBox1.Text = auteur.getNom();
            textBox2.Text = prenom[2];
            textBox3.Text = Convert.ToString(auteur.getAnneeNaissance());
            textBox4.Text = Convert.ToString(auteur.getAnneeDeces());

            /*
             * Ecrire le code suivant :
             * Lorsque vous cliquez sur un auteur la liste de ses livres apparait dans le listbox2
             */

            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            * Ecrire le code suivant :
            * Lorsque vous cliquez sur un livre ses propriétés apparaissent dans la partie livre
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.Items.Clear();
            chargerListe();
            chargerGenre();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
           * Ecrire le code suivant :
           * Lorsque vous choisissez un genre, la listbox1 se charge des auteurs qui ont publié des livres de ce genre
           */
        }
        #endregion 
    }
       
}
