namespace Rabin_CryptoSystem
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
            this.tv_title = new System.Windows.Forms.Label();
            this.txtInputMessage = new System.Windows.Forms.TextBox();
            this.btn_encryption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.titleQ = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.titleN = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMessageEncryped = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtOriginMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMessageNeedDecription = new System.Windows.Forms.TextBox();
            this.btnDecryption = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_title
            // 
            this.tv_title.AutoSize = true;
            this.tv_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_title.Location = new System.Drawing.Point(94, 31);
            this.tv_title.Name = "tv_title";
            this.tv_title.Size = new System.Drawing.Size(91, 20);
            this.tv_title.TabIndex = 0;
            this.tv_title.Text = "Thông Điệp";
            // 
            // txtInputMessage
            // 
            this.txtInputMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMessage.Location = new System.Drawing.Point(191, 28);
            this.txtInputMessage.Name = "txtInputMessage";
            this.txtInputMessage.Size = new System.Drawing.Size(100, 26);
            this.txtInputMessage.TabIndex = 1;
            this.txtInputMessage.TextChanged += new System.EventHandler(this.txtInputMessage_TextChanged);
            // 
            // btn_encryption
            // 
            this.btn_encryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encryption.Location = new System.Drawing.Point(91, 161);
            this.btn_encryption.Name = "btn_encryption";
            this.btn_encryption.Size = new System.Drawing.Size(154, 33);
            this.btn_encryption.TabIndex = 2;
            this.btn_encryption.Text = "Mã Hóa";
            this.btn_encryption.UseVisualStyleBackColor = true;
            this.btn_encryption.Click += new System.EventHandler(this.btn_encryption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "P = ";
            // 
            // txtP
            // 
            this.txtP.Enabled = false;
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(72, 30);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 26);
            this.txtP.TabIndex = 4;
            // 
            // titleQ
            // 
            this.titleQ.AutoSize = true;
            this.titleQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleQ.Location = new System.Drawing.Point(19, 63);
            this.titleQ.Name = "titleQ";
            this.titleQ.Size = new System.Drawing.Size(50, 25);
            this.titleQ.TabIndex = 5;
            this.titleQ.Text = "Q = ";
            // 
            // txtQ
            // 
            this.txtQ.Enabled = false;
            this.txtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(72, 63);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 26);
            this.txtQ.TabIndex = 6;
            // 
            // txtN
            // 
            this.txtN.Enabled = false;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(72, 98);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 26);
            this.txtN.TabIndex = 8;
            // 
            // titleN
            // 
            this.titleN.AutoSize = true;
            this.titleN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleN.Location = new System.Drawing.Point(18, 98);
            this.titleN.Name = "titleN";
            this.titleN.Size = new System.Drawing.Size(48, 25);
            this.titleN.TabIndex = 7;
            this.titleN.Text = "N = ";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(24, 139);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(148, 27);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Khởi tạo";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(155, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vui lòng chỉ nhập số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Khóa công khai (N)";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Enabled = false;
            this.txtPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.Location = new System.Drawing.Point(191, 101);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(100, 26);
            this.txtPublicKey.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtP);
            this.panel1.Controls.Add(this.titleQ);
            this.panel1.Controls.Add(this.txtQ);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.titleN);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 199);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMessageEncryped);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tv_title);
            this.panel2.Controls.Add(this.txtInputMessage);
            this.panel2.Controls.Add(this.txtPublicKey);
            this.panel2.Controls.Add(this.btn_encryption);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(237, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 308);
            this.panel2.TabIndex = 14;
            // 
            // txtMessageEncryped
            // 
            this.txtMessageEncryped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageEncryped.Location = new System.Drawing.Point(191, 224);
            this.txtMessageEncryped.Name = "txtMessageEncryped";
            this.txtMessageEncryped.Size = new System.Drawing.Size(100, 26);
            this.txtMessageEncryped.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thông điệp đã mã hóa";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtOriginMessage);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtMessageNeedDecription);
            this.panel3.Controls.Add(this.btnDecryption);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(564, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 308);
            this.panel3.TabIndex = 15;
            // 
            // txtOriginMessage
            // 
            this.txtOriginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginMessage.Location = new System.Drawing.Point(191, 224);
            this.txtOriginMessage.Name = "txtOriginMessage";
            this.txtOriginMessage.Size = new System.Drawing.Size(100, 26);
            this.txtOriginMessage.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thông điệp cần giải mã";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thông Điệp ban đầu";
            // 
            // txtMessageNeedDecription
            // 
            this.txtMessageNeedDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageNeedDecription.Location = new System.Drawing.Point(193, 34);
            this.txtMessageNeedDecription.Name = "txtMessageNeedDecription";
            this.txtMessageNeedDecription.Size = new System.Drawing.Size(100, 26);
            this.txtMessageNeedDecription.TabIndex = 1;
            // 
            // btnDecryption
            // 
            this.btnDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryption.Location = new System.Drawing.Point(91, 161);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(154, 33);
            this.btnDecryption.TabIndex = 2;
            this.btnDecryption.Text = "Giải Mã";
            this.btnDecryption.UseVisualStyleBackColor = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(157, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vui lòng chỉ nhập số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tv_title;
        private System.Windows.Forms.TextBox txtInputMessage;
        private System.Windows.Forms.Button btn_encryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label titleQ;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label titleN;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMessageEncryped;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtOriginMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMessageNeedDecription;
        private System.Windows.Forms.Button btnDecryption;
        private System.Windows.Forms.Label label8;
    }
}

