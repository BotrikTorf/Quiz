namespace Quiz
{
    partial class Form_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Start));
            this.label_Help = new System.Windows.Forms.Label();
            this.label_param = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_division = new System.Windows.Forms.TextBox();
            this.button_start_division = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_addition = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_subtraction = new System.Windows.Forms.TextBox();
            this.button_subtraction = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Help
            // 
            this.label_Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Help.Location = new System.Drawing.Point(0, 0);
            this.label_Help.Name = "label_Help";
            this.label_Help.Size = new System.Drawing.Size(894, 25);
            this.label_Help.TabIndex = 0;
            this.label_Help.Text = "Эта программа преднозначена для проверки знаний";
            this.label_Help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_param
            // 
            this.label_param.AutoSize = true;
            this.label_param.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_param.Location = new System.Drawing.Point(11, 45);
            this.label_param.Name = "label_param";
            this.label_param.Size = new System.Drawing.Size(624, 25);
            this.label_param.TabIndex = 1;
            this.label_param.Text = "Введите цифру до каторой вы хотите проверить знания";
            // 
            // button_start
            // 
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(717, 28);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(165, 71);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Начать проверку таблицы умножения";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(659, 46);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 31);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Допускается вводить цифры от 2 до 9. Иначе программа не будет работать.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Допускается вводить цифры от 2 до 9. Иначе программа не будет работать.";
            // 
            // textBox_division
            // 
            this.textBox_division.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_division.Location = new System.Drawing.Point(659, 127);
            this.textBox_division.MaxLength = 1;
            this.textBox_division.Name = "textBox_division";
            this.textBox_division.Size = new System.Drawing.Size(52, 31);
            this.textBox_division.TabIndex = 10;
            this.textBox_division.Text = "2";
            this.textBox_division.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_start_division
            // 
            this.button_start_division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start_division.Location = new System.Drawing.Point(717, 109);
            this.button_start_division.Name = "button_start_division";
            this.button_start_division.Size = new System.Drawing.Size(165, 71);
            this.button_start_division.TabIndex = 9;
            this.button_start_division.Text = "Начать проверку на деление";
            this.button_start_division.UseVisualStyleBackColor = true;
            this.button_start_division.Click += new System.EventHandler(this.button_start_division_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(624, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите цифру до каторой вы хотите проверить знания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(606, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Допускается вводить цифры от 2 до 99. Иначе программа не будет работать.";
            // 
            // textBox_addition
            // 
            this.textBox_addition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addition.Location = new System.Drawing.Point(659, 218);
            this.textBox_addition.MaxLength = 2;
            this.textBox_addition.Name = "textBox_addition";
            this.textBox_addition.Size = new System.Drawing.Size(52, 31);
            this.textBox_addition.TabIndex = 14;
            this.textBox_addition.Text = "2";
            this.textBox_addition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(717, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 71);
            this.button1.TabIndex = 13;
            this.button1.Text = "Начать проверку на сложение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(624, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите цифру до каторой вы хотите проверить знания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(606, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Допускается вводить цифры от 2 до 99. Иначе программа не будет работать.";
            // 
            // textBox_subtraction
            // 
            this.textBox_subtraction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_subtraction.Location = new System.Drawing.Point(659, 311);
            this.textBox_subtraction.MaxLength = 2;
            this.textBox_subtraction.Name = "textBox_subtraction";
            this.textBox_subtraction.Size = new System.Drawing.Size(52, 31);
            this.textBox_subtraction.TabIndex = 18;
            this.textBox_subtraction.Text = "2";
            this.textBox_subtraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_subtraction
            // 
            this.button_subtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_subtraction.Location = new System.Drawing.Point(717, 293);
            this.button_subtraction.Name = "button_subtraction";
            this.button_subtraction.Size = new System.Drawing.Size(165, 71);
            this.button_subtraction.TabIndex = 17;
            this.button_subtraction.Text = "Начать проверку на вычитание";
            this.button_subtraction.UseVisualStyleBackColor = true;
            this.button_subtraction.Click += new System.EventHandler(this.button_subtraction_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(624, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Введите цифру до каторой вы хотите проверить знания";
            // 
            // Form_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 386);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_subtraction);
            this.Controls.Add(this.button_subtraction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_addition);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_division);
            this.Controls.Add(this.button_start_division);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_param);
            this.Controls.Add(this.label_Help);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(910, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(910, 425);
            this.Name = "Form_Start";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Help;
        private System.Windows.Forms.Label label_param;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_division;
        private System.Windows.Forms.Button button_start_division;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_addition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_subtraction;
        private System.Windows.Forms.Button button_subtraction;
        private System.Windows.Forms.Label label7;
    }
}

