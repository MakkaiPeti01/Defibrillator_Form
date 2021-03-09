
namespace Defibrillator_Form
{
    partial class Defibrillator
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
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.btn_Adatok = new System.Windows.Forms.Button();
            this.lbKiir = new System.Windows.Forms.ListBox();
            this.btn_Ujadat = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_X.Location = new System.Drawing.Point(72, 114);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(79, 29);
            this.lbl_X.TabIndex = 0;
            this.lbl_X.Text = "label1";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Y.Location = new System.Drawing.Point(72, 163);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(79, 29);
            this.lbl_Y.TabIndex = 1;
            this.lbl_Y.Text = "label1";
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(236, 117);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(124, 26);
            this.tb_X.TabIndex = 2;
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(236, 167);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(124, 26);
            this.tb_Y.TabIndex = 3;
            // 
            // btn_Adatok
            // 
            this.btn_Adatok.Location = new System.Drawing.Point(162, 224);
            this.btn_Adatok.Name = "btn_Adatok";
            this.btn_Adatok.Size = new System.Drawing.Size(182, 34);
            this.btn_Adatok.TabIndex = 4;
            this.btn_Adatok.Text = "Adatok lekérése";
            this.btn_Adatok.UseVisualStyleBackColor = true;
            this.btn_Adatok.Click += new System.EventHandler(this.btn_Adatok_Click);
            // 
            // lbKiir
            // 
            this.lbKiir.FormattingEnabled = true;
            this.lbKiir.ItemHeight = 20;
            this.lbKiir.Location = new System.Drawing.Point(77, 283);
            this.lbKiir.Name = "lbKiir";
            this.lbKiir.Size = new System.Drawing.Size(357, 304);
            this.lbKiir.TabIndex = 5;
            // 
            // btn_Ujadat
            // 
            this.btn_Ujadat.Location = new System.Drawing.Point(31, 611);
            this.btn_Ujadat.Name = "btn_Ujadat";
            this.btn_Ujadat.Size = new System.Drawing.Size(182, 34);
            this.btn_Ujadat.TabIndex = 6;
            this.btn_Ujadat.Text = "Új adat hozzáadása";
            this.btn_Ujadat.UseVisualStyleBackColor = true;
            this.btn_Ujadat.Click += new System.EventHandler(this.btn_Ujadat_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(334, 611);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(182, 34);
            this.btnKilepes.TabIndex = 7;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // Defibrillator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 657);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btn_Ujadat);
            this.Controls.Add(this.lbKiir);
            this.Controls.Add(this.btn_Adatok);
            this.Controls.Add(this.tb_Y);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Defibrillator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defibrillátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Button btn_Adatok;
        private System.Windows.Forms.ListBox lbKiir;
        private System.Windows.Forms.Button btn_Ujadat;
        private System.Windows.Forms.Button btnKilepes;
    }
}

