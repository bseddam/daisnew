namespace Dais
{
    partial class GirisFRM
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
            this.pnlgiris = new System.Windows.Forms.Panel();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.lblparol = new System.Windows.Forms.Label();
            this.txtparol = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.pnlgiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlgiris
            // 
            this.pnlgiris.Controls.Add(this.lblmessage);
            this.pnlgiris.Controls.Add(this.btngiris);
            this.pnlgiris.Controls.Add(this.lblparol);
            this.pnlgiris.Controls.Add(this.txtparol);
            this.pnlgiris.Controls.Add(this.lbllogin);
            this.pnlgiris.Controls.Add(this.txtlogin);
            this.pnlgiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlgiris.Location = new System.Drawing.Point(0, 0);
            this.pnlgiris.Name = "pnlgiris";
            this.pnlgiris.Size = new System.Drawing.Size(307, 154);
            this.pnlgiris.TabIndex = 1;
            this.pnlgiris.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlgiris_Paint);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(36, 9);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 19);
            this.lblmessage.TabIndex = 9;
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngiris.Location = new System.Drawing.Point(160, 103);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(100, 33);
            this.btngiris.TabIndex = 8;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lblparol
            // 
            this.lblparol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblparol.Location = new System.Drawing.Point(99, 65);
            this.lblparol.Name = "lblparol";
            this.lblparol.Size = new System.Drawing.Size(55, 22);
            this.lblparol.TabIndex = 6;
            this.lblparol.Text = "Parol:";
            // 
            // txtparol
            // 
            this.txtparol.Location = new System.Drawing.Point(160, 67);
            this.txtparol.Name = "txtparol";
            this.txtparol.PasswordChar = '*';
            this.txtparol.Size = new System.Drawing.Size(100, 20);
            this.txtparol.TabIndex = 7;
            this.txtparol.Text = "222";
            // 
            // lbllogin
            // 
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(35, 36);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(119, 22);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "İstifadəçı adı:";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(160, 36);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(100, 20);
            this.txtlogin.TabIndex = 5;
            this.txtlogin.Text = "dsk002";
            // 
            // GirisFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 154);
            this.Controls.Add(this.pnlgiris);
            this.Name = "GirisFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.pnlgiris.ResumeLayout(false);
            this.pnlgiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlgiris;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lblparol;
        private System.Windows.Forms.TextBox txtparol;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txtlogin;
    }
}