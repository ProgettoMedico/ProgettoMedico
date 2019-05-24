namespace Mess_WA
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
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progetto_MedicoDataSet = new Mess_WA.Progetto_MedicoDataSet();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.medicoTableAdapter = new Mess_WA.Progetto_MedicoDataSetTableAdapters.MedicoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.progetto_MedicoDataSet1 = new Mess_WA.Progetto_MedicoDataSet1();
            this.medicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter1 = new Mess_WA.Progetto_MedicoDataSet1TableAdapters.MedicoTableAdapter();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progetto_MedicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progetto_MedicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.progetto_MedicoDataSet;
            this.bindingSource1.Position = 0;
            // 
            // progetto_MedicoDataSet
            // 
            this.progetto_MedicoDataSet.DataSetName = "Progetto_MedicoDataSet";
            this.progetto_MedicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 83);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(240, 20);
            this.txtMess.TabIndex = 1;
            // 
            // btnInvia
            // 
            this.btnInvia.Enabled = false;
            this.btnInvia.Location = new System.Drawing.Point(94, 179);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 2;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messaggio";
            // 
            // progetto_MedicoDataSet1
            // 
            this.progetto_MedicoDataSet1.DataSetName = "Progetto_MedicoDataSet1";
            this.progetto_MedicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoBindingSource1
            // 
            this.medicoBindingSource1.DataMember = "Medico";
            this.medicoBindingSource1.DataSource = this.progetto_MedicoDataSet1;
            // 
            // medicoTableAdapter1
            // 
            this.medicoTableAdapter1.ClearBeforeFill = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(12, 31);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(240, 20);
            this.txtnome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Cognome";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(218, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sei sicuro che i dati inseriti siano corretti?";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 227);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtMess);
            this.Name = "Form1";
            this.Text = "Messaggio Medico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progetto_MedicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progetto_MedicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Progetto_MedicoDataSet progetto_MedicoDataSet;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private Progetto_MedicoDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.Label label1;
        private Progetto_MedicoDataSet1 progetto_MedicoDataSet1;
        private System.Windows.Forms.BindingSource medicoBindingSource1;
        private Progetto_MedicoDataSet1TableAdapters.MedicoTableAdapter medicoTableAdapter1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

