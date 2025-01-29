namespace Projekt_w69758_GL01_3IIZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            visits1.Hide();
            animals1.Hide();
            vets1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // visits button
        private void button1_Click(object sender, EventArgs e)
        {
            animals1.Hide();
            vets1.Hide();
            visits1.Show();
        }

        // animals button
        private void button2_Click(object sender, EventArgs e)
        {
            visits1.Hide();
            vets1.Hide();
            animals1.Show();
        }

        // vets button
        private void button3_Click(object sender, EventArgs e)
        {
            visits1.Hide();
            animals1.Hide();
            vets1.Show();
        }

    }
}
