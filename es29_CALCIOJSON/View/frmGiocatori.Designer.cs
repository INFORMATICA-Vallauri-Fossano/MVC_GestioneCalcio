namespace es29_CALCIOJSON.View
{
    partial class frmGiocatori
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRuolo = new System.Windows.Forms.Label();
            this.cmbRuolo = new System.Windows.Forms.ComboBox();
            this.txtSquadra = new System.Windows.Forms.TextBox();
            this.lblSquadra = new System.Windows.Forms.Label();
            this.txtNumeroMaglia = new System.Windows.Forms.TextBox();
            this.lblNumeroMaglia = new System.Windows.Forms.Label();
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
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblNome.Location = new System.Drawing.Point(12, 239);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(125, 23);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 237);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 22);
            this.txtNome.TabIndex = 9;
            // 
            // lblRuolo
            // 
            this.lblRuolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblRuolo.Location = new System.Drawing.Point(12, 275);
            this.lblRuolo.Name = "lblRuolo";
            this.lblRuolo.Size = new System.Drawing.Size(125, 23);
            this.lblRuolo.TabIndex = 10;
            this.lblRuolo.Text = "RUOLO";
            // 
            // cmbRuolo
            // 
            this.cmbRuolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuolo.FormattingEnabled = true;
            this.cmbRuolo.Location = new System.Drawing.Point(143, 273);
            this.cmbRuolo.Name = "cmbRuolo";
            this.cmbRuolo.Size = new System.Drawing.Size(232, 24);
            this.cmbRuolo.TabIndex = 12;
            // 
            // txtSquadra
            // 
            this.txtSquadra.Location = new System.Drawing.Point(143, 311);
            this.txtSquadra.Name = "txtSquadra";
            this.txtSquadra.Size = new System.Drawing.Size(232, 22);
            this.txtSquadra.TabIndex = 14;
            // 
            // lblSquadra
            // 
            this.lblSquadra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblSquadra.Location = new System.Drawing.Point(12, 313);
            this.lblSquadra.Name = "lblSquadra";
            this.lblSquadra.Size = new System.Drawing.Size(125, 23);
            this.lblSquadra.TabIndex = 13;
            this.lblSquadra.Text = "SQUADRA";
            // 
            // txtNumeroMaglia
            // 
            this.txtNumeroMaglia.Location = new System.Drawing.Point(143, 344);
            this.txtNumeroMaglia.Name = "txtNumeroMaglia";
            this.txtNumeroMaglia.Size = new System.Drawing.Size(232, 22);
            this.txtNumeroMaglia.TabIndex = 16;
            // 
            // lblNumeroMaglia
            // 
            this.lblNumeroMaglia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblNumeroMaglia.Location = new System.Drawing.Point(12, 346);
            this.lblNumeroMaglia.Name = "lblNumeroMaglia";
            this.lblNumeroMaglia.Size = new System.Drawing.Size(125, 23);
            this.lblNumeroMaglia.TabIndex = 15;
            this.lblNumeroMaglia.Text = "NUMERO MAGLIA";
            // 
            // frmGiocatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroMaglia);
            this.Controls.Add(this.lblNumeroMaglia);
            this.Controls.Add(this.txtSquadra);
            this.Controls.Add(this.lblSquadra);
            this.Controls.Add(this.cmbRuolo);
            this.Controls.Add(this.lblRuolo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmGiocatori";
            this.Text = "frmGiocatori";
            this.Load += new System.EventHandler(this.frmGiocatori_Load);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.lblRuolo, 0);
            this.Controls.SetChildIndex(this.cmbRuolo, 0);
            this.Controls.SetChildIndex(this.lblSquadra, 0);
            this.Controls.SetChildIndex(this.txtSquadra, 0);
            this.Controls.SetChildIndex(this.lblNumeroMaglia, 0);
            this.Controls.SetChildIndex(this.txtNumeroMaglia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRuolo;
        private System.Windows.Forms.ComboBox cmbRuolo;
        private System.Windows.Forms.TextBox txtSquadra;
        private System.Windows.Forms.Label lblSquadra;
        private System.Windows.Forms.TextBox txtNumeroMaglia;
        private System.Windows.Forms.Label lblNumeroMaglia;
    }
}