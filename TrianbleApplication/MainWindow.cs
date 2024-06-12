using TriangleLibrary;

namespace TrianbleApplication
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e) {
            if (textBoxAB.Text == "" || textBoxBC.Text == "" || textBoxAC.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (!double.TryParse(textBoxAB.Text, out double AB))
            {
                textBoxAB.Text = "";
                MessageBox.Show("Сторона AB введена некорректно");
                return;
            }

            if (!double.TryParse(textBoxBC.Text, out double BC))
            {
                textBoxBC.Text = "";
                MessageBox.Show("Сторона BC введена некорректно");
                return;
            }

            if (!double.TryParse(textBoxAC.Text, out double AC))
            {
                textBoxAC.Text = "";
                MessageBox.Show("Сторона AC введена некорректно");
                return;
            }

            textBox1.Text = new TriangleValidator(new Triangle(AB, BC, AC)).ToString();
        }
    }
}
