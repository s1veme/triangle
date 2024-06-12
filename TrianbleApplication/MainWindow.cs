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
                MessageBox.Show("��������� ��� ����");
                return;
            }

            if (!double.TryParse(textBoxAB.Text, out double AB))
            {
                textBoxAB.Text = "";
                MessageBox.Show("������� AB ������� �����������");
                return;
            }

            if (!double.TryParse(textBoxBC.Text, out double BC))
            {
                textBoxBC.Text = "";
                MessageBox.Show("������� BC ������� �����������");
                return;
            }

            if (!double.TryParse(textBoxAC.Text, out double AC))
            {
                textBoxAC.Text = "";
                MessageBox.Show("������� AC ������� �����������");
                return;
            }

            textBox1.Text = new TriangleValidator(new Triangle(AB, BC, AC)).ToString();
        }
    }
}
