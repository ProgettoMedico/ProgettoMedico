using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Permette la lettura e la scrittura in file
using System.IO.Ports; //Contiene classi per il controllo delle porte seriali
using System.Threading; //Crea e controlla un thread, ne imposta le priorità e ne ottiene lo stato
using System.Data.SqlClient; //Il provider di dati .NET per SQL Server

namespace InvioGSM
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            SerialPort.PortName = "COM5"; //Permette di scegliere il nome della porta seriale
            SerialPort.BaudRate = 115200; //Velocità in  baud della porta
            SerialPort.DataBits = 8; //Lunghezza dei bit di dati
            SerialPort.Parity = System.IO.Ports.Parity.None; //Assegna il valore predefinito del protocollo di controllo della parità a None
            SerialPort.Open(); //Apre una nuova connessione su porta seriale
        }

        private readonly string MedicoConnectionString = "Data Source=(local);Initial Catalog=Progetto Medico;Integrated Security=True"; //stringa di connessione
        
        private void btnInvia_Click(object sender, EventArgs e)
        {
            Timer.Enabled=true; //Avvio il timer premendo il pulsante
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            string NumCell = txtNumCell.Text; //Dichiarazione variabili prese in input
            string messaggio = txtMessInv.Text;
            try
            {
                SqlConnection cnn = new SqlConnection(MedicoConnectionString); //Dichiaro la stringa di connessione

                SqlCommand cmd = new SqlCommand("SELECT COUNT(CodPrenotazione) FROM Prenotazioni WHERE Data = GETDATE()", cnn); //Query
               
                SqlDataReader reader = cmd.ExecuteReader(); //Esegue la query ed ottiene un oggetto per la lettura del resultset

                if (Convert.ToInt32(reader) <= 5) 
                {
                
                    messaggio = txtMessInv.Text;  //invio del messaggio
                    SerialPort.WriteLine(@"AT+CMGF=1" + (char)(13));
                    SerialPort.WriteLine(@"AT+CMGS=" + NumCell + (char)(13)); //Numero di telefono dove inviare il messaggio
                    Thread.Sleep(2000);                
                    SerialPort.WriteLine(messaggio + (char)(26)); //aggiungo testo del messaggio e invio ctrl Z
                    MessageBox.Show("messaggio inviato: " + txtMessInv.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Eccezione del database");
            }
        }
    }
}
