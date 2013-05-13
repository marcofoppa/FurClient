namespace FurClient
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScaricaFur = new System.Windows.Forms.Button();
            this.tbFur = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMese = new System.Windows.Forms.ComboBox();
            this.cbAnno = new System.Windows.Forms.ComboBox();
            this.cbApplicazioni = new System.Windows.Forms.ComboBox();
            this.cbAsl = new System.Windows.Forms.ComboBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnScaricaFur
            // 
            this.btnScaricaFur.Location = new System.Drawing.Point(12, 95);
            this.btnScaricaFur.Name = "btnScaricaFur";
            this.btnScaricaFur.Size = new System.Drawing.Size(75, 23);
            this.btnScaricaFur.TabIndex = 6;
            this.btnScaricaFur.Text = "Scarica FUR";
            this.btnScaricaFur.UseVisualStyleBackColor = true;
            this.btnScaricaFur.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFur
            // 
            this.tbFur.AcceptsReturn = true;
            this.tbFur.Location = new System.Drawing.Point(12, 130);
            this.tbFur.Multiline = true;
            this.tbFur.Name = "tbFur";
            this.tbFur.ReadOnly = true;
            this.tbFur.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFur.Size = new System.Drawing.Size(553, 280);
            this.tbFur.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(489, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Azzera";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Installazione";
            // 
            // tbUrl
            // 
            this.tbUrl.Enabled = false;
            this.tbUrl.Location = new System.Drawing.Point(273, 10);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(291, 20);
            this.tbUrl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mese";
            // 
            // txPin
            // 
            this.txPin.Location = new System.Drawing.Point(273, 36);
            this.txPin.Name = "txPin";
            this.txPin.Size = new System.Drawing.Size(89, 20);
            this.txPin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pin";
            // 
            // txUsername
            // 
            this.txUsername.Location = new System.Drawing.Point(85, 36);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(121, 20);
            this.txUsername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Codice Asl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anno";
            // 
            // cbMese
            // 
            this.cbMese.FormattingEnabled = true;
            this.cbMese.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMese.Location = new System.Drawing.Point(85, 62);
            this.cbMese.Name = "cbMese";
            this.cbMese.Size = new System.Drawing.Size(121, 21);
            this.cbMese.TabIndex = 3;
            // 
            // cbAnno
            // 
            this.cbAnno.FormattingEnabled = true;
            this.cbAnno.Location = new System.Drawing.Point(273, 62);
            this.cbAnno.Name = "cbAnno";
            this.cbAnno.Size = new System.Drawing.Size(89, 21);
            this.cbAnno.TabIndex = 4;
            // 
            // cbApplicazioni
            // 
            this.cbApplicazioni.FormattingEnabled = true;
            this.cbApplicazioni.Location = new System.Drawing.Point(85, 10);
            this.cbApplicazioni.Name = "cbApplicazioni";
            this.cbApplicazioni.Size = new System.Drawing.Size(162, 21);
            this.cbApplicazioni.TabIndex = 0;
            this.cbApplicazioni.SelectedIndexChanged += new System.EventHandler(this.cbApplicazioni_SelectedIndexChanged);
            // 
            // cbAsl
            // 
            this.cbAsl.FormattingEnabled = true;
            this.cbAsl.Location = new System.Drawing.Point(477, 62);
            this.cbAsl.Name = "cbAsl";
            this.cbAsl.Size = new System.Drawing.Size(75, 21);
            this.cbAsl.TabIndex = 5;
            // 
            // btnSalva
            // 
            this.btnSalva.Enabled = false;
            this.btnSalva.Location = new System.Drawing.Point(408, 414);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 18;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 449);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.cbAsl);
            this.Controls.Add(this.cbApplicazioni);
            this.Controls.Add(this.cbAnno);
            this.Controls.Add(this.cbMese);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbFur);
            this.Controls.Add(this.btnScaricaFur);
            this.Name = "FormMain";
            this.Text = "Interrogazione FUR DPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScaricaFur;
        private System.Windows.Forms.TextBox tbFur;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMese;
        private System.Windows.Forms.ComboBox cbAnno;
        private System.Windows.Forms.ComboBox cbApplicazioni;
        private System.Windows.Forms.ComboBox cbAsl;
        private System.Windows.Forms.Button btnSalva;
    }
}

