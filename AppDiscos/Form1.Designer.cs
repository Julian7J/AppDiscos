using System;

namespace AppDiscos
{
    partial class Form1
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pictureBoxDiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(-1, 0);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(439, 330);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscos_CellContentClick);
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pictureBoxDiscos
            // 
            this.pictureBoxDiscos.Location = new System.Drawing.Point(449, 0);
            this.pictureBoxDiscos.Name = "pictureBoxDiscos";
            this.pictureBoxDiscos.Size = new System.Drawing.Size(361, 318);
            this.pictureBoxDiscos.TabIndex = 1;
            this.pictureBoxDiscos.TabStop = false;
            this.pictureBoxDiscos.Click += new System.EventHandler(this.pictureBoxDiscos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 338);
            this.Controls.Add(this.pictureBoxDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "Form1";
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pictureBoxDiscos;
    }
}

