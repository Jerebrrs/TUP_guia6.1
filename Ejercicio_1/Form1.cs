using Ejercicio_1.Models;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepartamentoVehicular dpt = new DepartamentoVehicular();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormVerDatos vtn = new FormVerDatos();
            string nombre = tbNombre.Text;
            string patente = tbPatente.Text;
            int dni = Convert.ToInt32(tbDni.Text);
            try
            {
                dpt.RegistrarVehiculo(new Persona(nombre, dni), patente);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }



            tbDni.Clear();
            tbNombre.Clear();
            tbPatente.Clear();

          
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            FormVerDatos vtn = new FormVerDatos();

            vtn.textBox1.Clear();

            dpt.OrdenarRegistros();
            for (int i = 0; i < dpt.CantidadRegistros; i++)
            {
                vtn.textBox1.Text = dpt.VerRegistro(i).ToString() + "\r\n";
            }
            vtn.ShowDialog();


        }
    }
}
