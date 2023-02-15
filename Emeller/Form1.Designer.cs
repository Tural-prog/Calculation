namespace Emeller
{
    partial class Hesablama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesablama));
            this.txtGöster = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnÇıxma = new System.Windows.Forms.Button();
            this.btnVurma = new System.Windows.Forms.Button();
            this.btnBölmə = new System.Windows.Forms.Button();
            this.btnCavab = new System.Windows.Forms.Button();
            this.btnNfy = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblQeyd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGöster
            // 
            this.txtGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGöster.Location = new System.Drawing.Point(23, 12);
            this.txtGöster.Name = "txtGöster";
            this.txtGöster.Size = new System.Drawing.Size(173, 26);
            this.txtGöster.TabIndex = 0;
            this.txtGöster.Text = "0";
            this.txtGöster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnToplama
            // 
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToplama.Location = new System.Drawing.Point(25, 81);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(38, 32);
            this.btnToplama.TabIndex = 1;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click_1);
            // 
            // btnÇıxma
            // 
            this.btnÇıxma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÇıxma.Location = new System.Drawing.Point(69, 81);
            this.btnÇıxma.Name = "btnÇıxma";
            this.btnÇıxma.Size = new System.Drawing.Size(39, 32);
            this.btnÇıxma.TabIndex = 2;
            this.btnÇıxma.Text = "-";
            this.btnÇıxma.UseVisualStyleBackColor = true;
            this.btnÇıxma.Click += new System.EventHandler(this.btnÇıxma_Click_1);
            // 
            // btnVurma
            // 
            this.btnVurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVurma.Location = new System.Drawing.Point(114, 81);
            this.btnVurma.Name = "btnVurma";
            this.btnVurma.Size = new System.Drawing.Size(35, 32);
            this.btnVurma.TabIndex = 3;
            this.btnVurma.Text = "*";
            this.btnVurma.UseVisualStyleBackColor = true;
            this.btnVurma.Click += new System.EventHandler(this.btnVurma_Click);
            // 
            // btnBölmə
            // 
            this.btnBölmə.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBölmə.Location = new System.Drawing.Point(160, 81);
            this.btnBölmə.Name = "btnBölmə";
            this.btnBölmə.Size = new System.Drawing.Size(38, 32);
            this.btnBölmə.TabIndex = 4;
            this.btnBölmə.Text = "/";
            this.btnBölmə.UseVisualStyleBackColor = true;
            this.btnBölmə.Click += new System.EventHandler(this.btnBölmə_Click);
            // 
            // btnCavab
            // 
            this.btnCavab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCavab.Location = new System.Drawing.Point(25, 130);
            this.btnCavab.Name = "btnCavab";
            this.btnCavab.Size = new System.Drawing.Size(55, 42);
            this.btnCavab.TabIndex = 6;
            this.btnCavab.Text = "Hesabla";
            this.btnCavab.UseVisualStyleBackColor = true;
            this.btnCavab.Click += new System.EventHandler(this.btnCavab_Click);
            // 
            // btnNfy
            // 
            this.btnNfy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNfy.Location = new System.Drawing.Point(86, 130);
            this.btnNfy.Name = "btnNfy";
            this.btnNfy.Size = new System.Drawing.Size(68, 42);
            this.btnNfy.TabIndex = 7;
            this.btnNfy.Text = " Fayla yaz";
            this.btnNfy.UseCompatibleTextRendering = true;
            this.btnNfy.UseVisualStyleBackColor = true;
            this.btnNfy.Click += new System.EventHandler(this.btnNfy_Click);
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = true;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(160, 130);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(38, 42);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseCompatibleTextRendering = true;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblQeyd
            // 
            this.lblQeyd.AutoSize = true;
            this.lblQeyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQeyd.Location = new System.Drawing.Point(115, 41);
            this.lblQeyd.Name = "lblQeyd";
            this.lblQeyd.Size = new System.Drawing.Size(18, 20);
            this.lblQeyd.TabIndex = 9;
            this.lblQeyd.Text = "0";
            // 
            // Hesablama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(224, 203);
            this.Controls.Add(this.lblQeyd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnNfy);
            this.Controls.Add(this.btnCavab);
            this.Controls.Add(this.btnBölmə);
            this.Controls.Add(this.btnVurma);
            this.Controls.Add(this.btnÇıxma);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.txtGöster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hesablama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGöster;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnÇıxma;
        private System.Windows.Forms.Button btnVurma;
        private System.Windows.Forms.Button btnBölmə;
        private System.Windows.Forms.Button btnCavab;
        private System.Windows.Forms.Button btnNfy;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblQeyd;
    }
}

