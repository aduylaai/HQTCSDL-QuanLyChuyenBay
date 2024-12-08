namespace QuanLyChuyenBay_Demo.Forms
{
    partial class frmSaoLuu
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
            this.btnSaoLuuCSDL = new System.Windows.Forms.Button();
            this.btnKhoiPhucCSDL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaoLuuCSDL
            // 
            this.btnSaoLuuCSDL.Location = new System.Drawing.Point(236, 77);
            this.btnSaoLuuCSDL.Name = "btnSaoLuuCSDL";
            this.btnSaoLuuCSDL.Size = new System.Drawing.Size(367, 166);
            this.btnSaoLuuCSDL.TabIndex = 0;
            this.btnSaoLuuCSDL.Text = "Backup";
            this.btnSaoLuuCSDL.UseVisualStyleBackColor = true;
            this.btnSaoLuuCSDL.Click += new System.EventHandler(this.btnSaoLuuCSDL_Click);
            // 
            // btnKhoiPhucCSDL
            // 
            this.btnKhoiPhucCSDL.Location = new System.Drawing.Point(236, 263);
            this.btnKhoiPhucCSDL.Name = "btnKhoiPhucCSDL";
            this.btnKhoiPhucCSDL.Size = new System.Drawing.Size(367, 166);
            this.btnKhoiPhucCSDL.TabIndex = 1;
            this.btnKhoiPhucCSDL.Text = "Restore";
            this.btnKhoiPhucCSDL.UseVisualStyleBackColor = true;
            this.btnKhoiPhucCSDL.Click += new System.EventHandler(this.btnKhoiPhucCSDL_Click);
            // 
            // frmSaoLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKhoiPhucCSDL);
            this.Controls.Add(this.btnSaoLuuCSDL);
            this.Name = "frmSaoLuu";
            this.Text = "Sao Lưu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaoLuuCSDL;
        private System.Windows.Forms.Button btnKhoiPhucCSDL;
    }
}