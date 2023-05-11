namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int wynik = 0;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            wynik = (int)numericUpDown2.Value;
            wynik = +(int)numericUpDown1.Value;
            label1.Text = wynik.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
                wynik = (int)numericUpDown2.Value;
                wynik += (int)numericUpDown1.Value;
                label1.Text = wynik.ToString();
        }
    }
}