namespace RSA_Crypt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_textbox = new System.Windows.Forms.TextBox();
            this.q_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.e_textbox = new System.Windows.Forms.TextBox();
            this.n_textbox = new System.Windows.Forms.TextBox();
            this.d_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msg_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.res_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Refresh);
            this.groupBox1.Controls.Add(this.Generation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.q_textbox);
            this.groupBox1.Controls.Add(this.d_textbox);
            this.groupBox1.Controls.Add(this.n_textbox);
            this.groupBox1.Controls.Add(this.e_textbox);
            this.groupBox1.Controls.Add(this.p_textbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация ключей";
            // 
            // p_textbox
            // 
            this.p_textbox.Location = new System.Drawing.Point(37, 26);
            this.p_textbox.Name = "p_textbox";
            this.p_textbox.Size = new System.Drawing.Size(109, 26);
            this.p_textbox.TabIndex = 0;
            // 
            // q_textbox
            // 
            this.q_textbox.Location = new System.Drawing.Point(37, 58);
            this.q_textbox.Name = "q_textbox";
            this.q_textbox.Size = new System.Drawing.Size(109, 26);
            this.q_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "P:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Q:";
            // 
            // Generation
            // 
            this.Generation.Location = new System.Drawing.Point(7, 90);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(139, 31);
            this.Generation.TabIndex = 2;
            this.Generation.Text = "Сгенерировать";
            this.Generation.UseVisualStyleBackColor = true;
            this.Generation.Click += new System.EventHandler(this.Generation_Click);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.Location = new System.Drawing.Point(321, 21);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(34, 37);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "⟳";
            this.Refresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // e_textbox
            // 
            this.e_textbox.Location = new System.Drawing.Point(206, 26);
            this.e_textbox.Name = "e_textbox";
            this.e_textbox.Size = new System.Drawing.Size(109, 26);
            this.e_textbox.TabIndex = 0;
            // 
            // n_textbox
            // 
            this.n_textbox.Location = new System.Drawing.Point(206, 58);
            this.n_textbox.Name = "n_textbox";
            this.n_textbox.Size = new System.Drawing.Size(109, 26);
            this.n_textbox.TabIndex = 0;
            // 
            // d_textbox
            // 
            this.d_textbox.Location = new System.Drawing.Point(206, 90);
            this.d_textbox.Name = "d_textbox";
            this.d_textbox.Size = new System.Drawing.Size(109, 26);
            this.d_textbox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "E:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "N:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "D:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.res_textbox);
            this.groupBox2.Controls.Add(this.msg_textbox);
            this.groupBox2.Controls.Add(this.Decrypt);
            this.groupBox2.Controls.Add(this.Encrypt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Шифрование";
            // 
            // msg_textbox
            // 
            this.msg_textbox.Location = new System.Drawing.Point(107, 25);
            this.msg_textbox.Name = "msg_textbox";
            this.msg_textbox.Size = new System.Drawing.Size(93, 26);
            this.msg_textbox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Число:";
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(206, 23);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(149, 31);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Шифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(206, 55);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(149, 31);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // res_textbox
            // 
            this.res_textbox.Location = new System.Drawing.Point(107, 57);
            this.res_textbox.Name = "res_textbox";
            this.res_textbox.Size = new System.Drawing.Size(93, 26);
            this.res_textbox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q_textbox;
        private System.Windows.Forms.TextBox p_textbox;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox d_textbox;
        private System.Windows.Forms.TextBox n_textbox;
        private System.Windows.Forms.TextBox e_textbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox msg_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox res_textbox;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Label label7;
    }
}

