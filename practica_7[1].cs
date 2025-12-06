namespace practica_7_elcetromecanica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rangoinferiro, rangosuperior, suma = 0;

            rangoinferiro = int.Parse(textBox1.Text);
            rangosuperior = int.Parse(textBox2.Text);
            for (int i = rangoinferiro; i <= rangosuperior; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }
            textBox3.Text = suma.ToString();
        }
    }
}