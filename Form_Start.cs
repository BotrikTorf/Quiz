using System;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form_Start : Form //стартовая форма
    {
        public static int znach;
        public static bool window_open = false;
        public Form_Start()
        {
            InitializeComponent();

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!window_open)
            {
                if (int.TryParse(textBox1.Text, out int rezul) && rezul > 1 && rezul < 10)
                {
                    znach = rezul;
                }
                else return;
                Form_Selection selection_Form = new Form_Selection(1);
                selection_Form.Show();
                window_open = true;
            }
        }

        private void button_start_division_Click(object sender, EventArgs e)
        {
            if (!window_open)
            {
                if (int.TryParse(textBox_division.Text, out int rezul) && rezul > 1 && rezul < 10)
                {
                    znach = rezul;
                }
                else return;
                Form_Selection selection_Form = new Form_Selection(2);
                selection_Form.Show();
                window_open = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!window_open)
            {
                if (int.TryParse(textBox_addition.Text, out int rezul) && rezul > 1 && rezul <= 99)
                {
                    znach = rezul;
                }
                else return;
                Form_Selection selection_Form = new Form_Selection(3);
                selection_Form.Show();
                window_open = true;
            }

        }

        private void button_subtraction_Click(object sender, EventArgs e)
        {
            if (!window_open)
            {
                if (int.TryParse(textBox_subtraction.Text, out int rezul) && rezul > 1 && rezul <= 99)
                {
                    znach = rezul;
                }
                else return;
                Form_Selection selection_Form = new Form_Selection(4);
                selection_Form.Show();
                window_open = true;
            }
            
        }


    }
}
