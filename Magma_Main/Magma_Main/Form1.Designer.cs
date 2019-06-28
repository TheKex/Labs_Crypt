namespace Magma_Main
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
            this.cypher = new System.Windows.Forms.Button();
            this.msg_textbox = new System.Windows.Forms.TextBox();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.key_label = new System.Windows.Forms.Label();
            this.msg_label = new System.Windows.Forms.Label();
            this.res_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cypher
            // 
            this.cypher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cypher.Location = new System.Drawing.Point(12, 128);
            this.cypher.Name = "cypher";
            this.cypher.Size = new System.Drawing.Size(240, 50);
            this.cypher.TabIndex = 0;
            this.cypher.Tag = "1";
            this.cypher.Text = "Зашифровать";
            this.cypher.UseVisualStyleBackColor = true;
            this.cypher.Click += new System.EventHandler(this.cypher_Click);
            // 
            // msg_textbox
            // 
            this.msg_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg_textbox.Location = new System.Drawing.Point(12, 32);
            this.msg_textbox.Name = "msg_textbox";
            this.msg_textbox.Size = new System.Drawing.Size(537, 26);
            this.msg_textbox.TabIndex = 1;
            this.msg_textbox.TextChanged += new System.EventHandler(this.msg_textbox_TextChanged);
            // 
            // key_textbox
            // 
            this.key_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_textbox.Location = new System.Drawing.Point(12, 96);
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(537, 26);
            this.key_textbox.TabIndex = 2;
            this.key_textbox.TextChanged += new System.EventHandler(this.key_textbox_TextChanged);
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.key_label.Location = new System.Drawing.Point(488, 73);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(61, 20);
            this.key_label.TabIndex = 3;
            this.key_label.Text = "0 из 64";
            // 
            // msg_label
            // 
            this.msg_label.AutoSize = true;
            this.msg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg_label.Location = new System.Drawing.Point(488, 9);
            this.msg_label.Name = "msg_label";
            this.msg_label.Size = new System.Drawing.Size(61, 20);
            this.msg_label.TabIndex = 3;
            this.msg_label.Text = "0 из 16";
            // 
            // res_textbox
            // 
            this.res_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res_textbox.Location = new System.Drawing.Point(12, 217);
            this.res_textbox.Name = "res_textbox";
            this.res_textbox.Size = new System.Drawing.Size(537, 26);
            this.res_textbox.TabIndex = 1;
            this.res_textbox.TextChanged += new System.EventHandler(this.msg_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(309, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 50);
            this.button1.TabIndex = 0;
            this.button1.Tag = "2";
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cypher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg_label);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.key_textbox);
            this.Controls.Add(this.res_textbox);
            this.Controls.Add(this.msg_textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cypher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cypher;
        private System.Windows.Forms.TextBox msg_textbox;
        private System.Windows.Forms.TextBox key_textbox;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.Label msg_label;
        private System.Windows.Forms.TextBox res_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

