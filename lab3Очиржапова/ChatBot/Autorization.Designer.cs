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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.button_name = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.TextBox_name = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_name
            // 
            this.button_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_name.BackColor = System.Drawing.Color.Azure;
            this.button_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_name.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_name.Location = new System.Drawing.Point(306, 107);
            this.button_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(99, 39);
            this.button_name.TabIndex = 0;
            this.button_name.Text = "ОК";
            this.button_name.UseVisualStyleBackColor = false;
            this.button_name.Click += new System.EventHandler(this.Button_name_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(4, 31);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(204, 33);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Введите ваше имя";
            // 
            // TextBox_name
            // 
            this.TextBox_name.BackColor = System.Drawing.Color.GhostWhite;
            this.TextBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_name.Location = new System.Drawing.Point(233, 31);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.Size = new System.Drawing.Size(172, 46);
            this.TextBox_name.TabIndex = 3;
            this.TextBox_name.Text = "";
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(419, 170);
            this.Controls.Add(this.TextBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_name);
            this.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

