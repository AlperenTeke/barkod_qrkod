namespace barkod_qrkod
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Qr = new System.Windows.Forms.Button();
            this.txt_Qr = new System.Windows.Forms.TextBox();
            this.picture_Qr = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Barkod = new System.Windows.Forms.Button();
            this.txt_Barkod = new System.Windows.Forms.TextBox();
            this.picture_Barkod = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Qr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Barkod)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Qr);
            this.groupBox1.Controls.Add(this.txt_Qr);
            this.groupBox1.Controls.Add(this.picture_Qr);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QR Kod Oluştur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "QR Kod";
            // 
            // btn_Qr
            // 
            this.btn_Qr.Location = new System.Drawing.Point(201, 410);
            this.btn_Qr.Name = "btn_Qr";
            this.btn_Qr.Size = new System.Drawing.Size(139, 44);
            this.btn_Qr.TabIndex = 2;
            this.btn_Qr.Text = "QR Oluştur";
            this.btn_Qr.UseVisualStyleBackColor = true;
            this.btn_Qr.Click += new System.EventHandler(this.btn_Qr_Click);
            // 
            // txt_Qr
            // 
            this.txt_Qr.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qr.Location = new System.Drawing.Point(124, 346);
            this.txt_Qr.Name = "txt_Qr";
            this.txt_Qr.Size = new System.Drawing.Size(279, 28);
            this.txt_Qr.TabIndex = 1;
            // 
            // picture_Qr
            // 
            this.picture_Qr.Location = new System.Drawing.Point(152, 113);
            this.picture_Qr.Name = "picture_Qr";
            this.picture_Qr.Size = new System.Drawing.Size(279, 190);
            this.picture_Qr.TabIndex = 0;
            this.picture_Qr.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Barkod);
            this.groupBox2.Controls.Add(this.txt_Barkod);
            this.groupBox2.Controls.Add(this.picture_Barkod);
            this.groupBox2.Location = new System.Drawing.Point(585, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 557);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barkod Oluştur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod";
            // 
            // btn_Barkod
            // 
            this.btn_Barkod.Location = new System.Drawing.Point(227, 410);
            this.btn_Barkod.Name = "btn_Barkod";
            this.btn_Barkod.Size = new System.Drawing.Size(139, 44);
            this.btn_Barkod.TabIndex = 4;
            this.btn_Barkod.Text = "Barkod Oluştur";
            this.btn_Barkod.UseVisualStyleBackColor = true;
            this.btn_Barkod.Click += new System.EventHandler(this.btn_Barkod_Click);
            // 
            // txt_Barkod
            // 
            this.txt_Barkod.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Barkod.Location = new System.Drawing.Point(150, 346);
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(279, 28);
            this.txt_Barkod.TabIndex = 3;
            // 
            // picture_Barkod
            // 
            this.picture_Barkod.Location = new System.Drawing.Point(150, 205);
            this.picture_Barkod.Name = "picture_Barkod";
            this.picture_Barkod.Size = new System.Drawing.Size(279, 29);
            this.picture_Barkod.TabIndex = 1;
            this.picture_Barkod.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 578);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR - Barkod Oluşturucu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Qr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Barkod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picture_Qr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picture_Barkod;
        private System.Windows.Forms.TextBox txt_Qr;
        private System.Windows.Forms.Button btn_Qr;
        private System.Windows.Forms.Button btn_Barkod;
        private System.Windows.Forms.TextBox txt_Barkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

