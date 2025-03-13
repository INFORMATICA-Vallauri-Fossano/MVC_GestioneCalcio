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
            this.dgvPartite = new System.Windows.Forms.DataGridView();
            this.cmbIdPartita = new System.Windows.Forms.ComboBox();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblNumeroMaglia
            // 
            this.lblNumeroMaglia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblNumeroMaglia.Location = new System.Drawing.Point(12, 308);
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
            // cmbIdPartita
            // 
            this.cmbIdPartita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdPartita.FormattingEnabled = true;
            this.cmbIdPartita.Location = new System.Drawing.Point(143, 303);
            this.cmbIdPartita.Name = "cmbIdPartita";
            this.cmbIdPartita.Size = new System.Drawing.Size(121, 24);
            this.cmbIdPartita.TabIndex = 31;
            this.cmbIdPartita.SelectedIndexChanged += new System.EventHandler(this.cmbIdPartita_SelectedIndexChanged);
            // 
            // cmbNumero
            // 
            this.cmbNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Location = new System.Drawing.Point(504, 306);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(123, 24);
            this.cmbNumero.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.label1.Location = new System.Drawing.Point(421, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "NUMERO";
            // 
            // txtMinuto
            // 
            this.txtMinuto.Location = new System.Drawing.Point(143, 261);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(232, 22);
            this.txtMinuto.TabIndex = 34;
            // 
            // frmGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 516);
            this.Controls.Add(this.txtMinuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.cmbIdPartita);
            this.Controls.Add(this.chkAutoGoal);
            this.Controls.Add(this.dgvPartite);
            this.Controls.Add(this.lblNumeroMaglia);
            this.Controls.Add(this.cmbMarcatore);
            this.Controls.Add(this.lblRuolo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmGoal";
            this.Text = "frmGoal";
            this.Load += new System.EventHandler(this.frmGoal_Load);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.lblRuolo, 0);
            this.Controls.SetChildIndex(this.cmbMarcatore, 0);
            this.Controls.SetChildIndex(this.lblNumeroMaglia, 0);
            this.Controls.SetChildIndex(this.dgvPartite, 0);
            this.Controls.SetChildIndex(this.chkAutoGoal, 0);
            this.Controls.SetChildIndex(this.cmbIdPartita, 0);
            this.Controls.SetChildIndex(this.cmbNumero, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMinuto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumeroMaglia;
        private System.Windows.Forms.ComboBox cmbMarcatore;
        private System.Windows.Forms.Label lblRuolo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox chkAutoGoal;
        private System.Windows.Forms.DataGridView dgvPartite;
        private System.Windows.Forms.ComboBox cmbIdPartita;
        private System.Windows.Forms.ComboBox cmbNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinuto;
    }
}