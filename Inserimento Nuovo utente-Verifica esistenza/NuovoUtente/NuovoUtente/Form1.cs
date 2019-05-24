using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Aggiungiamo alla libreria

namespace NuovoUtente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string connectionstring = @"Data Source=(local);Initial Catalog=Progetto Medico;Integrated Security=True"; //Stringa di connessione

        private void btnCrea_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection cnn = new SqlConnection(connectionstring);

                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Utenti (CodFiscale,Nome,Cognome,DataNascita,Indirizzo,Sesso,NumeroTelefono) values ( @CodFiscale, @Nome, @Cognome,@DataNascita,@Indirizzo,@Sesso,@NumeroTelefono)", cnn); //Inseriamo il nuovo utente


                    cmd.Parameters.AddWithValue("@CodFiscale", txtCodFiscale.Text); //Stampiamo dalla text-box
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Cognome", txtCognome.Text);
                    cmd.Parameters.AddWithValue("@DataNascita", txtDataNascita.Text);
                    cmd.Parameters.AddWithValue("@Indirizzo", txtIndirizzo.Text);
                    cmd.Parameters.AddWithValue("@Sesso", txtSesso.Text);
                    cmd.Parameters.AddWithValue("@NumeroTelefono", txtNumeroTel.Text);


                    cmd.ExecuteNonQuery();
                    cnn.Close(); //Chiudiamo la connessione
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTrovaUtente_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection cnn = new SqlConnection(connectionstring);

                {

                    cnn.Open(); //Apriamo la connessione
                    SqlCommand cmd = new SqlCommand("SELECT COUNT (CodFiscale) FROM Utenti WHERE CodFiscale = @CF", cnn); //Verifichiamo se il codice fiscale è presente nel database e ritorna 0 o 1 se esiste
                    cmd.Parameters.AddWithValue("CF", txtCodFiscale.Text); //Stampiamo dalla text-box
                    Int32 count = Convert.ToInt32(cmd.ExecuteScalar()); 

                    if (count == 1)
                    {
                        MessageBox.Show("L'utente esiste già!");
                    }

                    else //Creiamo il nuovo utente
                    {
                        btnCrea.Visible = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        txtNome.Visible = true;
                        txtCognome.Visible = true;
                        txtDataNascita.Visible = true;
                        txtIndirizzo.Visible = true;
                        txtSesso.Visible = true;
                        txtNumeroTel.Visible = true;
                    }
                    cnn.Close(); //Chiudiamo la connessione
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
