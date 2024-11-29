namespace PROYECTO_QUINTA_ARMONIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PresentacionSistema nuevo = new PresentacionSistema();
            this.Hide();
            nuevo.ShowDialog();
            this.Close();
        }
    }
}
