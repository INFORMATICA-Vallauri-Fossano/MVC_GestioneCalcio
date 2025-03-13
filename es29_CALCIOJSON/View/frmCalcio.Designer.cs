namespace es29_CALCIOJSON
{
    partial class frmCalcio
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
            this.btnGiocatori = new System.Windows.Forms.Button();
            this.btnPartite = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiocatori
            // 
            this.btnGiocatori.Location = new System.Drawing.Point(9, 34);
            this.btnGiocatori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiocatori.Name = "btnGiocatori";
            this.btnGiocatori.Size = new System.Drawing.Size(146, 32);
            this.btnGiocatori.TabIndex = 0;
            this.btnGiocatori.Text = "GIOCATORI";
            this.btnGiocatori.UseVisualStyleBackColor = true;
            this.btnGiocatori.Click += new System.EventHandler(this.btnGiocatori_Click);
            // 
            // btnPartite
            // 
            this.btnPartite.Location = new System.Drawing.Point(9, 72);
            this.btnPartite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPartite.Name = "btnPartite";
            this.btnPartite.Size = new System.Drawing.Size(146, 32);
            this.btnPartite.TabIndex = 1;
            this.btnPartite.Text = "PARTITE";
            this.btnPartite.UseVisualStyleBackColor = true;
            this.btnPartite.Click += new System.EventHandler(this.btnPartite_Click);
            // 
            // btnGoal
            // 
            this.btnGoal.Location = new System.Drawing.Point(9, 109);
            this.btnGoal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(146, 32);
            this.btnGoal.TabIndex = 2;
            this.btnGoal.Text = "GOAL";
            this.btnGoal.UseVisualStyleBackColor = true;
            this.btnGoal.Click += new System.EventHandler(this.btnGoal_Click);
            // 
            // frmCalcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 162);
            this.Controls.Add(this.btnGoal);
            this.Controls.Add(this.btnPartite);
            this.Controls.Add(this.btnGiocatori);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCalcio";
            this.Text = "GESTIONE GOAL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGiocatori;
        private System.Windows.Forms.Button btnPartite;
        private System.Windows.Forms.Button btnGoal;
    }
}

