namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSSaludar_Click(object sender, EventArgs e)
        { lblSaludo.Text = "�Hola, " + txtNombre.Text + "!";
        }
    }
}
