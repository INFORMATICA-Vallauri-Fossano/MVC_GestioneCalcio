namespace es29_CALCIOJSON.View
{
    partial class frmPartite
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
            this.txtSquadraOspite = new System.Windows.Forms.TextBox();
            this.lblNumeroMaglia = new System.Windows.Forms.Label();
            this.txtIdPartita = new System.Windows.Forms.TextBox();
            this.lblSquadra = new System.Windows.Forms.Label();
            this.txtSquadraCasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArbitro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEsiti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsiti)).BeginInit();
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
            // txtSquadraOspite
            // 
            this.txtSquadraOspite.Location = new System.Drawing.Point(125, 210);
            this.txtSquadraOspite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSquadraOspite.Name = "txtSquadraOspite";
            this.txtSquadraOspite.Size = new System.Drawing.Size(157, 20);
            this.txtSquadraOspite.TabIndex = 20;
            // 
            // lblNumeroMaglia
            // 
            this.lblNumeroMaglia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblNumeroMaglia.Location = new System.Drawing.Point(9, 211);
            this.lblNumeroMaglia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroMaglia.Name = "lblNumeroMaglia";
            this.lblNumeroMaglia.Size = new System.Drawing.Size(112, 19);
            this.lblNumeroMaglia.TabIndex = 19;
            this.lblNumeroMaglia.Text = "SQUADRA OSPITE";
            // 
            // txtIdPartita
            // 
            this.txtIdPartita.Location = new System.Drawing.Point(125, 183);
            this.txtIdPartita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPartita.Name = "txtIdPartita";
            this.txtIdPartita.Size = new System.Drawing.Size(157, 20);
            this.txtIdPartita.TabIndex = 18;
            // 
            // lblSquadra
            // 
            this.lblSquadra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.lblSquadra.Location = new System.Drawing.Point(9, 184);
            this.lblSquadra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSquadra.Name = "lblSquadra";
            this.lblSquadra.Size = new System.Drawing.Size(112, 19);
            this.lblSquadra.TabIndex = 17;
            this.lblSquadra.Text = "ID PARTITA";
            // 
            // txtSquadraCasa
            // 
            this.txtSquadraCasa.Location = new System.Drawing.Point(125, 240);
            this.txtSquadraCasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSquadraCasa.Name = "txtSquadraCasa";
            this.txtSquadraCasa.Size = new System.Drawing.Size(157, 20);
            this.txtSquadraCasa.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.label1.Location = new System.Drawing.Point(9, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "SQUADRA CASA";
            // 
            // txtArbitro
            // 
            this.txtArbitro.Location = new System.Drawing.Point(125, 270);
            this.txtArbitro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArbitro.Name = "txtArbitro";
            this.txtArbitro.Size = new System.Drawing.Size(157, 20);
            this.txtArbitro.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F);
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "ARBITRO";
            // 
            // dgvEsiti
            // 
            this.dgvEsiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEsiti.Location = new System.Drawing.Point(286, 137);
            this.dgvEsiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEsiti.Name = "dgvEsiti";
            this.dgvEsiti.RowHeadersWidth = 51;
            this.dgvEsiti.RowTemplate.Height = 24;
            this.dgvEsiti.Size = new System.Drawing.Size(304, 153);
            this.dgvEsiti.TabIndex = 25;
            // 
            // frmPartite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 298);
            this.Controls.Add(this.dgvEsiti);
            this.Controls.Add(this.txtArbitro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSquadraCasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSquadraOspite);
            this.Controls.Add(this.lblNumeroMaglia);
            this.Controls.Add(this.txtIdPartita);
            this.Controls.Add(this.lblSquadra);
            this.Name = "frmPartite";
            this.Text = "PARTITE";
            this.Load += new System.EventHandler(this.frmPartite_Load);
            this.Controls.SetChildIndex(this.lblSquadra, 0);
            this.Controls.SetChildIndex(this.txtIdPartita, 0);
            this.Controls.SetChildIndex(this.lblNumeroMaglia, 0);
            this.Controls.SetChildIndex(this.txtSquadraOspite, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSquadraCasa, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtArbitro, 0);
            this.Controls.SetChildIndex(this.btnInsert, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.dgvEsiti, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEsiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSquadraOspite;
        private System.Windows.Forms.Label lblNumeroMaglia;
        private System.Windows.Forms.TextBox txtIdPartita;
        private System.Windows.Forms.Label lblSquadra;
        private System.Windows.Forms.TextBox txtSquadraCasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArbitro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEsiti;
    }
}