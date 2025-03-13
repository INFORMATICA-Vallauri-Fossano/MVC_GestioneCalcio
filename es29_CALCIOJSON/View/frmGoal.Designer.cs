namespace es29_CALCIOJSON.View
{
    partial class frmGoal
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
            this.lblNumeroMaglia = new System.Windows.Forms.Label();
            this.cmbMarcatore = new System.Windows.Forms.ComboBox();
            this.lblRuolo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.chkAutoGoal = new System.Windows.Forms.CheckBox();
            this.btnMinuto = new System.Windows.Forms.Button();
            this.btnAggiungiGoal = new System.Windows.Forms.Button();
            this.btnTogliGoal = new System.Windows.Forms.Button();
            this.dgvPartite = new System.Windows.Forms.DataGridView();
            this.dgvGiocatori = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiocatori)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeroMaglia
            // 
            this.lblNumeroMaglia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblNumeroMaglia.Location = new System.Drawing.Point(12, 305);
            this.lblNumeroMaglia.Name = "lblNumeroMaglia";
            this.lblNumeroMaglia.Size = new System.Drawing.Size(125, 23);
            this.lblNumeroMaglia.TabIndex = 23;
            this.lblNumeroMaglia.Text = "ID PARTITA";
            // 
            // cmbMarcatore
            // 
            this.cmbMarcatore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcatore.FormattingEnabled = true;
            this.cmbMarcatore.Location = new System.Drawing.Point(143, 225);
            this.cmbMarcatore.Name = "cmbMarcatore";
            this.cmbMarcatore.Size = new System.Drawing.Size(232, 24);
            this.cmbMarcatore.TabIndex = 20;
            // 
            // lblRuolo
            // 
            this.lblRuolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblRuolo.Location = new System.Drawing.Point(12, 263);
            this.lblRuolo.Name = "lblRuolo";
            this.lblRuolo.Size = new System.Drawing.Size(125, 23);
            this.lblRuolo.TabIndex = 19;
            this.lblRuolo.Text = "MINUTO";
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblNome.Location = new System.Drawing.Point(12, 227);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(125, 23);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "MARCATORE";
            // 
            // chkAutoGoal
            // 
            this.chkAutoGoal.AutoSize = true;
            this.chkAutoGoal.Location = new System.Drawing.Point(280, 308);
            this.chkAutoGoal.Name = "chkAutoGoal";
            this.chkAutoGoal.Size = new System.Drawing.Size(103, 20);
            this.chkAutoGoal.TabIndex = 25;
            this.chkAutoGoal.Text = "AUTOGOAL";
            this.chkAutoGoal.UseVisualStyleBackColor = true;
            // 
            // btnMinuto
            // 
            this.btnMinuto.Location = new System.Drawing.Point(143, 263);
            this.btnMinuto.Name = "btnMinuto";
            this.btnMinuto.Size = new System.Drawing.Size(240, 23);
            this.btnMinuto.TabIndex = 28;
            this.btnMinuto.UseVisualStyleBackColor = true;
            // 
            // btnAggiungiGoal
            // 
            this.btnAggiungiGoal.Location = new System.Drawing.Point(668, 168);
            this.btnAggiungiGoal.Name = "btnAggiungiGoal";
            this.btnAggiungiGoal.Size = new System.Drawing.Size(120, 41);
            this.btnAggiungiGoal.TabIndex = 28;
            this.btnAggiungiGoal.Text = "AGGIUNGI";
            this.btnAggiungiGoal.UseVisualStyleBackColor = true;
            this.btnAggiungiGoal.Click += new System.EventHandler(this.btnAggiungiGoal_Click);
            // 
            // btnTogliGoal
            // 
            this.btnTogliGoal.Location = new System.Drawing.Point(668, 287);
            this.btnTogliGoal.Name = "btnTogliGoal";
            this.btnTogliGoal.Size = new System.Drawing.Size(120, 41);
            this.btnTogliGoal.TabIndex = 29;
            this.btnTogliGoal.Text = "TOGLI";
            this.btnTogliGoal.UseVisualStyleBackColor = true;
            // 
            // dgvPartite
            // 
            this.dgvPartite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartite.Location = new System.Drawing.Point(15, 334);
            this.dgvPartite.Name = "dgvPartite";
            this.dgvPartite.RowHeadersWidth = 51;
            this.dgvPartite.RowTemplate.Height = 24;
            this.dgvPartite.Size = new System.Drawing.Size(776, 164);
            this.dgvPartite.TabIndex = 26;
            // 
            // dgvGiocatori
            // 
            this.dgvGiocatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiocatori.Location = new System.Drawing.Point(797, 12);
            this.dgvGiocatori.Name = "dgvGiocatori";
            this.dgvGiocatori.RowHeadersWidth = 51;
            this.dgvGiocatori.RowTemplate.Height = 24;
            this.dgvGiocatori.Size = new System.Drawing.Size(506, 486);
            this.dgvGiocatori.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // frmGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 516);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvGiocatori);
            this.Controls.Add(this.btnTogliGoal);
            this.Controls.Add(this.btnMinuto);
            this.Controls.Add(this.btnAggiungiGoal);
            this.Controls.Add(this.chkAutoGoal);
            this.Controls.Add(this.dgvPartite);
            this.Controls.Add(this.lblNumeroMaglia);
            this.Controls.Add(this.cmbMarcatore);
            this.Controls.Add(this.lblRuolo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmGoal";
            this.Text = "frmGoal";
            this.Load += new System.EventHandler(this.frmGoal_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.lblRuolo, 0);
            this.Controls.SetChildIndex(this.cmbMarcatore, 0);
            this.Controls.SetChildIndex(this.lblNumeroMaglia, 0);
            this.Controls.SetChildIndex(this.dgvPartite, 0);
            this.Controls.SetChildIndex(this.chkAutoGoal, 0);
            this.Controls.SetChildIndex(this.btnAggiungiGoal, 0);
            this.Controls.SetChildIndex(this.btnMinuto, 0);
            this.Controls.SetChildIndex(this.btnTogliGoal, 0);
            this.Controls.SetChildIndex(this.dgvGiocatori, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiocatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroMaglia;
        private System.Windows.Forms.ComboBox cmbMarcatore;
        private System.Windows.Forms.Label lblRuolo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox chkAutoGoal;
        private System.Windows.Forms.Button btnMinuto;
        private System.Windows.Forms.Button btnAggiungiGoal;
        private System.Windows.Forms.Button btnTogliGoal;
        private System.Windows.Forms.DataGridView dgvPartite;
        private System.Windows.Forms.DataGridView dgvGiocatori;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}