namespace ArbolesBinarios
{
    public partial class Form1 : Form
    {
        private ArbolBinario arbol;

        public Form1()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Insertar(valor);
                MostrarRecorrido();
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                arbol.Eliminar(valor);
                MostrarRecorrido();
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                bool encontrado = arbol.Buscar(valor);
                MessageBox.Show(encontrado ? "Valor encontrado." : "Valor no encontrado.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void MostrarRecorrido()
        {
            lstRecorrido.Items.Clear();
            lstRecorrido.Items.Add("InOrden: " + arbol.InOrden());
        }
    }
}
