namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.A_L = new System.Windows.Forms.Label();
            this.Res_L = new System.Windows.Forms.Label();
            this.B_L = new System.Windows.Forms.Label();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.Res_TB = new System.Windows.Forms.TextBox();
            this.B_TB = new System.Windows.Forms.TextBox();
            this.Calc_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Location = new System.Drawing.Point(21, 27);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(49, 13);
            this.A_L.TabIndex = 0;
            this.A_L.Text = "Число &А";
            this.A_L.Click += new System.EventHandler(this.label1_Click);
            // 
            // Res_L
            // 
            this.Res_L.AutoSize = true;
            this.Res_L.Location = new System.Drawing.Point(21, 88);
            this.Res_L.Name = "Res_L";
            this.Res_L.Size = new System.Drawing.Size(59, 13);
            this.Res_L.TabIndex = 1;
            this.Res_L.Text = "&Результат";
            this.Res_L.Click += new System.EventHandler(this.Res_L_Click);
            // 
            // B_L
            // 
            this.B_L.AutoSize = true;
            this.B_L.Location = new System.Drawing.Point(21, 59);
            this.B_L.Name = "B_L";
            this.B_L.Size = new System.Drawing.Size(49, 13);
            this.B_L.TabIndex = 2;
            this.B_L.Text = "Число &В";
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(104, 23);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(135, 20);
            this.A_TB.TabIndex = 4;
            this.A_TB.TextChanged += new System.EventHandler(this.A_TB_TextChanged);
            // 
            // Res_TB
            // 
            this.Res_TB.Location = new System.Drawing.Point(104, 85);
            this.Res_TB.Name = "Res_TB";
            this.Res_TB.ReadOnly = true;
            this.Res_TB.Size = new System.Drawing.Size(135, 20);
            this.Res_TB.TabIndex = 5;
            this.Res_TB.TextChanged += new System.EventHandler(this.Res_TB_TextChanged);
            // 
            // B_TB
            // 
            this.B_TB.Location = new System.Drawing.Point(104, 52);
            this.B_TB.Name = "B_TB";
            this.B_TB.Size = new System.Drawing.Size(135, 20);
            this.B_TB.TabIndex = 6;
            // 
            // Calc_B
            // 
            this.Calc_B.Location = new System.Drawing.Point(262, 17);
            this.Calc_B.Name = "Calc_B";
            this.Calc_B.Size = new System.Drawing.Size(69, 88);
            this.Calc_B.TabIndex = 7;
            this.Calc_B.Text = "Рас&чёт";
            this.Calc_B.UseVisualStyleBackColor = true;
            this.Calc_B.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 127);
            this.Controls.Add(this.Calc_B);
            this.Controls.Add(this.B_TB);
            this.Controls.Add(this.Res_TB);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.B_L);
            this.Controls.Add(this.Res_L);
            this.Controls.Add(this.A_L);
            this.Name = "Form1";
            this.Text = "Простепйшие алгоритмы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label A_L;
        private System.Windows.Forms.Label Res_L;
        private System.Windows.Forms.Label B_L;
        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.TextBox Res_TB;
        private System.Windows.Forms.TextBox B_TB;
        private System.Windows.Forms.Button Calc_B;
    }
}

