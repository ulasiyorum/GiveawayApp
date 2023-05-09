
namespace test2
{
    public partial class Form1 : Form
    {
        String text1;
        String text2;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = cekilisGiris();
            label2.Visible = true;
            button2.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            button3.Visible = true;
            label9.Visible = true;
            numericUpDown3.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        { }
        private String cekilisGiris()
        {
            int start = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int end = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            Random random = new Random();
            String x = "" + random.Next(start, end);
            text1 = x;
            String a = "Your number is: " + x;
            return a;
        }
        private String cekilisCikis()
        {

            int start = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int end = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            Random random = new Random();
            String x;
            if (ifEnd()) { x = text1; }
            else
            {
                x = "" + random.Next(start, end);
            }
            text2 = x;
            String a = "The winner is: " + x;
            return a;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = cekilisCikis();
            if (text1 == text2)
            {
                MessageBox.Show("Congratulations! You WON!");
            }
            else
            {
                MessageBox.Show("BASARAMADIN");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            int limit = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
            int start = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            int end = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            Random random = new Random();
            String[] winners = new String[limit];
            for (int i = 0; i < limit; i++)
            {
                winners[i] = "The winner is: " + random.Next(start, end);
            }
            for (int i = 1; i < limit; i++)
            {
                while (winners[i - 1] == winners[i])
                {
                    winners[i - 1] = "The winner is: " + random.Next(start, end);
                }
            }
            winners[random.Next(0, winners.Length)] = cekilisCikis();
            for (int i = 0; i < winners.Length; i++)
            {
                label4.Text += winners[i] + "\n";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private Boolean ifEnd()
        {
            int end = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            if (end % 100 == 0 || end / 50 == 1 || end > 1001 || end % 536 == 0 || end % 553 == 0) { return true; }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numericUpDown2.Value = random.Next(0, 100);
        }
    }
}