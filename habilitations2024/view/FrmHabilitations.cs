using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using habilitations2024.controller;
using habilitations2024.model;

namespace Habilitations2024.view
{
    public partial class FrmHabilitations : Form
    {
        private FrmHabilitationsController controller;
        private BindingSource bdgDeveloppeurs = new BindingSource();
        private BindingSource bdgProfils = new BindingSource();
        private Boolean demandeModifDeveloppeur = false;

        public FrmHabilitations()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmHabilitationsController();
            RemplirListeProfils();
            RemplirListeDeveloppeurs();
            EnCoursdeModifDeveloppeur(false);
            EnCoursModifPwd(false);
        }

        private void RemplirListeDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = controller.GetLesDeveloppeurs();
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvLesDeveloppeurs.DataSource = bdgDeveloppeurs;
            dgvLesDeveloppeurs.Columns["iddeveloppeur"].Visible = false;
            dgvLesDeveloppeurs.Columns["pwd"].Visible = false;
            dgvLesDeveloppeurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeProfils()
        {
            List<Profil> lesProfils = controller.GetLesProfils();
            lesProfils.Insert(0, new Profil());
            bdgProfils.DataSource = lesProfils;
            comboBox1.DataSource = bdgProfils;
            comboBox1.DisplayMember = "Nom";
            comboBox1.ValueMember = "Nom";
            comboBox1.SelectedIndex = 0;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvLesDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCoursdeModifDeveloppeur(true);
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                comboBox1.SelectedIndex = comboBox1.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Attention");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvLesDeveloppeurs.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if (MessageBox.Show("Voulez vous vraiment supprimer " + developpeur.Prenom + " " + developpeur.Nom + " ? ", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.SuppDeveloppeur(developpeur);
                    comboBox1_SelectedIndexChanged(null, null); // Réappliquer le filtre
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une ligne", "Attention");
            }
        }

        private void btnChangerPwd_Click(object sender, EventArgs e)
        {
            if (dgvLesDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCoursModifPwd(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Attention");
            }
        }

        private void btnEnregistrerDeveloppeur_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && comboBox1.SelectedIndex != -1)
            {
                Profil profil = (Profil)comboBox1.SelectedItem;

                if (demandeModifDeveloppeur)
                {
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = txtPrenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    controller.ModifDeveloppeur(developpeur);
                }
                else
                {
                    Developpeur developpeur = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, "", profil);
                    controller.AjoutDeveloppeur(developpeur);
                }

                EnCoursdeModifDeveloppeur(false);
                comboBox1_SelectedIndexChanged(null, null); // Réappliquer le filtre
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Attention");
            }
        }

        private void btnAnnulerDeveloppeur_Click(object sender, EventArgs e)
        {
            EnCoursdeModifDeveloppeur(false);
        }

        private void btnEnregistrerPwd_Click(object sender, EventArgs e)
        {
            if (!txtPwd.Text.Equals("") && !txtEncorePwd.Text.Equals("") && txtPwd.Text.Equals(txtEncorePwd.Text))
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                developpeur.Pwd = txtPwd.Text;
                controller.ModifPwd(developpeur);
                EnCoursModifPwd(false);
            }
            else
            {
                MessageBox.Show("Les deux zones doivent être remplies avec un mot de passe identique", "Attention");
            }
        }

        private void btnAnnulerPwd_Click(object sender, EventArgs e)
        {
            EnCoursModifPwd(false);
        }

        private void EnCoursModifPwd(Boolean modif)
        {
            gboModifPwd.Enabled = modif;
            gboLesDeveloppeurs.Enabled = !modif;
            gboAjoutDeveloppeur.Enabled = !modif;
            txtPwd.Text = "";
            txtEncorePwd.Text = "";
        }

        private void EnCoursdeModifDeveloppeur(Boolean modif)
        {
            demandeModifDeveloppeur = modif;
            gboLesDeveloppeurs.Enabled = !modif;
            if (!modif)
            {
                gboAjoutDeveloppeur.Text = "Ajouter un développeur";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
                comboBox1.SelectedIndex = 0; // Ligne vide par défaut
            }
            else
            {
                gboAjoutDeveloppeur.Text = "Modifier un développeur";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Profil selectedProfil = (Profil)comboBox1.SelectedItem;

                if (!string.IsNullOrEmpty(selectedProfil.Nom))
                {
                    List<Developpeur> filteredDeveloppeurs = controller.GetLesDeveloppeurs()
                        .Where(d => d.Profil.Nom == selectedProfil.Nom)
                        .ToList();

                    bdgDeveloppeurs.DataSource = filteredDeveloppeurs;
                }
                else
                {
                    bdgDeveloppeurs.DataSource = controller.GetLesDeveloppeurs();
                }

                dgvLesDeveloppeurs.DataSource = bdgDeveloppeurs;
                dgvLesDeveloppeurs.Columns["iddeveloppeur"].Visible = false;
                dgvLesDeveloppeurs.Columns["pwd"].Visible = false;
                dgvLesDeveloppeurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
