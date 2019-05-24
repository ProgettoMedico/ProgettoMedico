using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Aggiungere alla libreria 

namespace Mess_WA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string MedicoConnectionString = "Data Source=(local);Initial Catalog=Progetto Medico;Integrated Security=True"; //Stringa di connessione al database
        private void btnInvia_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(MedicoConnectionString); //Dichiariamo la stringa di connessione
            try
            {
                cnn.Open(); //Apriamo la connessione 

                string nomecognome = txtnome.Text; //Prendo in input il nome e cognome
                DateTime data = DateTime.Now; //Data e ora

                SqlCommand cmd1 = new SqlCommand("INSERT INTO messaggi3 (cognome, data, descrizione) values (@cognome, @data, @descrizione)", cnn); //Eseguiamo la query per inserire i dati

                cmd1.Parameters.AddWithValue("descrizione", txtMess.Text); //Aggiungiamo i valori come parametri
                cmd1.Parameters.AddWithValue("data", data);
                cmd1.Parameters.AddWithValue("cognome", nomecognome);

                cmd1.ExecuteNonQuery();

                cnn.Close(); //Chiudiamo la connessione al database 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Eccezione Database");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eccezione generica");
            }
            finally
            {
                cnn.Close(); //Chiudiamo la connessione
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) //Premendo il radiobutton abilitiamo il btnInvia
            {
                btnInvia.Enabled = true;
            }
        }
    }
}
