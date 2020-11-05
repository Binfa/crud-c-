namespace Exercicio_veiculo
{
    partial class frmFabricante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtFab = new System.Windows.Forms.TextBox();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(205, 55);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(193, 20);
            this.txtCod.TabIndex = 2;
            // 
            // txtFab
            // 
            this.txtFab.Location = new System.Drawing.Point(205, 93);
            this.txtFab.Name = "txtFab";
            this.txtFab.Size = new System.Drawing.Size(193, 20);
            this.txtFab.TabIndex = 3;
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(66, 148);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(75, 23);
            this.btnIns.TabIndex = 4;
            this.btnIns.Text = "Inserir";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click_1);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(153, 148);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 5;
            this.btnCon.Text = "Consultar";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click_1);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(238, 148);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 6;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click_1);
            // 
            // btnExc
            // 
            this.btnExc.Location = new System.Drawing.Point(323, 148);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(75, 23);
            this.btnExc.TabIndex = 7;
            this.btnExc.Text = "Excluir";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click_1);
            // 
            // frmFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(482, 234);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.txtFab);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFabricante";
            this.Text = "Fabricante";
            this.Load += new System.EventHandler(this.frmFabricante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtFab;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnExc;
    }
}