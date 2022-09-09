using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form_Addition:Form //форма для проверки сложения
    {
        private TextBox[] textBox;
        private Label[] labels_prim;
        private PictureBox[] picture_boxes;
        private int znach = Form_Start.znach;
        private int[] sum = new int[30];
        private Button button_restar;
        private Button button_examination;
        private int param;
        private Random random = new Random();
        private bool pressing = true;

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Form_Addition(int param)
        {
            this.param = param;
            InitializeComponent();
            Creates_Text_Box();
            Creates_Labels();
            Creates_Picture_Box();
            Mapping_Button();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(820, 520);
            this.Name = "Form_Division";
            this.Text = "Проверка умений выполнять сложение";
            this.ResumeLayout(false);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize =ClientSize;
            this.MinimumSize = ClientSize;
            this.Icon = Properties.Resources.icon;
        }



        private void Creates_Labels()
        {
            labels_prim = new Label[30];
            for (int i = 0; i < labels_prim.Length; i++)
            {
                labels_prim[i] = new Label();
                labels_prim[i].Text = Text_Prim(i);
                labels_prim[i].Visible = true;
                labels_prim[i].AutoSize = true;
                labels_prim[i].Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                labels_prim[i].Name = " labels_prim[" + i + "]";
                labels_prim[i].Size = new Size(82, 29);
                labels_prim[i].TabIndex = i;
                if (i < 10)
                {
                    labels_prim[i].Location = new Point(9, i * 35 + 11);
                }
                else if (i >= 20) labels_prim[i].Location = new Point(550, (i - 20) * 35 + 11);
                else labels_prim[i].Location = new Point(250, (i - 10) * 35 + 11);

                Controls.Add(labels_prim[i]);
            }
        }

        private void Creates_Text_Box()
        {
            textBox = new TextBox[30];
            for (int i = 0; i < textBox.Length; i++)
            {
                textBox[i] = new TextBox();
                textBox[i].Visible = true;
                textBox[i].AutoSize = true;
                textBox[i].Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                textBox[i].Size = new Size(59, 31);
                textBox[i].Name = "textBox[" + i + "]";
                textBox[i].TabIndex = i;
                textBox[i].MaxLength = 2;
                textBox[i].TextAlign = HorizontalAlignment.Center;

                if (i < 10) textBox[i].Location = new Point(115, i * 35 + 12);
                else if (i >= 20) textBox[i].Location = new Point(115 + 550, (i - 20) * 35 + 12);
                else textBox[i].Location = new Point(115 + 250, (i - 10) * 35 + 12);
                Controls.Add(textBox[i]);
                if (param == 0)
                {
                    textBox[i].TextChanged += Form_Examination_TextChanged;
                }
                //// создание обработчика если изменяется текст в текстовом поле
                //textBox[i].TextChanged += Form_Examination_TextChanged;
            }

        }

        private void Form_Examination_TextChanged(object sender, EventArgs e)
        {

            TextBox text_box = sender as TextBox;
            int index = text_box.TabIndex;

            foreach (var item in labels_prim)
            {
                if (item.TabIndex == index)
                {
                    Proverka(index);
                }
            }
        }

        string Text_Prim(int i)
        {
            int first_term;
            int second_term;
            int rezul;

            do
            {
                first_term = random.Next(1, znach + 1);
                second_term = random.Next(1, znach + 1);
                rezul = first_term + second_term;
            } while (rezul >= 100);

            sum[i] = rezul;
            return second_term.ToString() + " + " + first_term.ToString() + " =";


        }

        private void Creates_Picture_Box()
        {
            picture_boxes = new PictureBox[30];
            for (int i = 0; i < picture_boxes.Length; i++)
            {
                picture_boxes[i] = new PictureBox();
                picture_boxes[i].Size = new Size(33, 25);
                picture_boxes[i].TabIndex = i;
                picture_boxes[i].BackColor = Color.Red;

                if (i < 10) picture_boxes[i].Location = new Point(180, i * 35 + 15);
                else if (i >= 20) picture_boxes[i].Location = new Point(180 + 550, (i - 20) * 35 + 15);
                else picture_boxes[i].Location = new Point(180 + 250, (i - 10) * 35 + 15);

                if (param == 0) picture_boxes[i].Visible = true;
                if (param == 1) picture_boxes[i].Visible = false;

                Controls.Add(picture_boxes[i]);
            }
        }

        private void Proverka(int i)
        {

            if (int.TryParse(textBox[i].Text, out int rez) && sum[i] == rez)
                picture_boxes[i].BackColor = Color.Green;
            else
                picture_boxes[i].BackColor = Color.Red;

        }

        private void Mapping_Button()
        {
            if (param == 0) Creates_Button_Restar();
            if (param == 1)
            {
                Creates_Button_Examination();
                Creates_Button_Restar();
            }
        }

        private void Creates_Button_Examination()
        {
            button_examination = new Button();
            button_examination.Enabled = true;
            button_examination.Name = "button_examination";
            button_examination.Text = "Проверить результат";
            button_examination.Visible = true;
            button_examination.AutoSize = false;
            button_examination.Location = new Point(270, 370);
            button_examination.Size = new Size(250, 100);
            button_examination.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            Controls.Add(button_examination);
            button_examination.Click += Button_examination_Click;
        }

        private void Button_examination_Click(object sender, EventArgs e)
        {
            if (!pressing) return;
            for (int i = 0; i < 30; i++)
            {
                picture_boxes[i].Visible = true;
                Proverka(i);
            }
            pressing = false;
        }

        private void Creates_Button_Restar()
        {
            if (param == 0)
            {
                button_restar = new Button();
                button_restar.Enabled = true;
                button_restar.Name = "button_restart";
                button_restar.Text = "Записать новые примеры";
                button_restar.Visible = true;
                button_restar.AutoSize = false;
                button_restar.Location = new Point(10, 370);
                button_restar.Size = new Size(250, 100);
                button_restar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                Controls.Add(button_restar);
                button_restar.Click += Button_restar_Click;
            }
            if (param == 1)
            {
                button_restar = new Button();
                button_restar.Enabled = true;
                button_restar.Name = "button_restart";
                button_restar.Text = "Записать новые примеры";
                button_restar.Visible = true;
                button_restar.AutoSize = false;
                button_restar.Location = new Point(10, 370);
                button_restar.Size = new Size(250, 100);
                button_restar.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
                Controls.Add(button_restar);
                button_restar.Click += Button_restar_Click;
            }
        }

        private void Button_restar_Click(object sender, EventArgs e)
        {
            //очищает форму
            Controls.Clear();

            Creates_Text_Box();
            Creates_Labels();
            Creates_Picture_Box();
            Mapping_Button();
            pressing = true;
        }
    }
}
