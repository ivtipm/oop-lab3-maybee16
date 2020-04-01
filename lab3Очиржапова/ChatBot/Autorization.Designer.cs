namespace ChatBot
{
    partial class Autorization
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
            this.button_name = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_name
            // 
            this.button_name.Location = new System.Drawing.Point(353, 142);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(75, 23);
            this.button_name.TabIndex = 0;
            this.button_name.Text = "ОК";
            this.button_name.UseVisualStyleBackColor = true;
            this.button_name.Click += new System.EventHandler(this.Button_name_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(328, 99);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 22);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.TextBox_name_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(175, 99);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(130, 17);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Введите ваше имя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_name;
        private System.Windows.Forms.Label label_name;
        public System.Windows.Forms.TextBox textBox_name;
    }
}

