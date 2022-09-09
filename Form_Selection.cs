using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form_Selection : Form
    {
        int param;

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        Button button_check;
        Button button_workout;


        public Form_Selection(int param)
        {
            this.param = param;
            InitializeComponent();
            Button_Creates();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(530, 180);
            this.Name = "Form_Selection";
            this.Text = "Выбор проверки";
            this.ResumeLayout(false);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = ClientSize;
            this.MinimumSize = ClientSize;
            this.Icon = Properties.Resources.icon;
        }

        private void Button_Creates()
        {
            button_check = new Button();
            button_check.Enabled = true;
            button_check.Name = "button_check";
            button_check.Text = "Вы хотите проверить свои знания";
            button_check.Visible = true;
            button_check.AutoSize = false;
            button_check.Location = new Point(10, 10);
            button_check.Size = new Size(200, 100);
            button_check.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            Controls.Add(button_check);
            button_check.Click += Button_check_Click;

            button_workout = new Button();
            button_workout.Enabled = true;
            button_workout.Name = "button_check";
            button_workout.Text = "Вы хотите потренироваться?";
            button_workout.Visible = true;
            button_workout.AutoSize = false;
            button_workout.Location = new Point(250, 10);
            button_workout.Size = new Size(250, 100);
            button_workout.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            Controls.Add(button_workout);
            button_workout.Click += Button_workout_Click;
        }

        private void Button_workout_Click(object sender, EventArgs e)
        {

            switch (param)
            {
                case 1:
                    Form_Examination form_Examination = new Form_Examination(0);
                    form_Examination.Show();
                    break;
                case 2:
                    Form_Division form_Division = new Form_Division(0);
                    form_Division.Show();
                    break;
                case 3:
                    Form_Addition form_Addition = new Form_Addition(0);
                    form_Addition.Show();
                    break;
                case 4:
                    Form_Subtraction form_Subtraction = new Form_Subtraction(0);
                    form_Subtraction.Show();
                    break;
                default: return;
            }
            Form_Start.window_open = false;
            this.Close();
            //this.Hide();

        }


        private void Button_check_Click(object sender, EventArgs e)
        {
            switch (param)
            {
                case 1:
                    Form_Examination form_Examination = new Form_Examination(1);
                    form_Examination.Show();
                    break;
                case 2:
                    Form_Division form_Division = new Form_Division(1);
                    form_Division.Show();
                    break;
                case 3:
                    Form_Addition form_Addition = new Form_Addition(1);
                    form_Addition.Show();
                    break;
                case 4:
                    Form_Subtraction form_Subtraction = new Form_Subtraction(1);
                    form_Subtraction.Show();
                    break;
                default: return;
            }
            Form_Start.window_open = false;
            this.Close();
        }
    }



}
