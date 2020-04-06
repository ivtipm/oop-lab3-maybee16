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
            this.label_name = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_name
            // 
            this.button_name.BackColor = System.Drawing.Color.LightPink;
            this.button_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_name.ForeColor = System.Drawing.Color.DarkRed;
            this.button_name.Location = new System.Drawing.Point(232, 81);
            this.button_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(110, 34);
            this.button_name.TabIndex = 0;
            this.button_name.Text = "ОК";
            this.button_name.UseVisualStyleBackColor = false;
            this.button_name.Click += new System.EventHandler(this.Button_name_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.DarkRed;
            this.label_name.Location = new System.Drawing.Point(15, 22);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(145, 24);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Введите ваше имя";
            // 
            // TextBox_name
            // 
            this.TextBox_name.Location = new System.Drawing.Point(185, 18);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.Size = new System.Drawing.Size(156, 37);
            this.TextBox_name.TabIndex = 3;
            this.TextBox_name.Text = "";
            this.TextBox_name.TextChanged += new System.EventHandler(this.TextBox_name_TextChanged);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(358, 136);
            this.Controls.Add(this.TextBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_name);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Autorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_name;
        private System.Windows.Forms.Label label_name;
        public System.Windows.Forms.RichTextBox TextBox_name;
    }
}

