namespace InvioGSM
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtMessInv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ProgettoMedicoDataSe = new InvioGSM.NorthwindDataSet1();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.txtNumCell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgettoMedicoDataSe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(187, 118);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 0;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtMessInv
            // 
            this.txtMessInv.Location = new System.Drawing.Point(134, 28);
            this.txtMessInv.Name = "txtMessInv";
            this.txtMessInv.Size = new System.Drawing.Size(203, 20);
            this.txtMessInv.TabIndex = 1;
            this.txtMessInv.Text = "Attenzione! Mancano 5 persone o meno!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messaggio Inviato";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.ProgettoMedicoDataSe;
            this.bindingSource1.Position = 0;
            // 
            // ProgettoMedicoDataSe
            // 
            this.ProgettoMedicoDataSe.DataSetName = "ProgettoMedicoDataSe";
            this.ProgettoMedicoDataSe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Timer
            // 
            this.Timer.Interval = 10000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // txtNumCell
            // 
            this.txtNumCell.Location = new System.Drawing.Point(134, 54);
            this.txtNumCell.Name = "txtNumCell";
            this.txtNumCell.Size = new System.Drawing.Size(203, 20);
            this.txtNumCell.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero di telefono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 153);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumCell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessInv);
            this.Controls.Add(this.btnInvia);
            this.Name = "Form1";
            this.Text = "Invio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgettoMedicoDataSe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.TextBox txtMessInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private NorthwindDataSet1 ProgettoMedicoDataSe;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox txtNumCell;
        private System.Windows.Forms.Label label2;
    }
}

