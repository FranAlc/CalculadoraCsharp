namespace CalculadoraCsharp
{
    public partial class Form1 : Form
    {

        double num1 = 0, num2 = 0, resultado=0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }
        //Agrega un numero BARRA
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txtDatos.Text == "0")
            
                txtDatos.Text = "";

                txtDatos.Text += boton.Text;
            

        }
        //al tocar un signo (+ - X / ) limpiara el resultado
        private void clickOperador (object sender,EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtDatos.Text);
           
            operador = Convert.ToChar(boton.Text);
            txtDatos.Text = "0";
            
        }

        

        //Este da el resultado
        private void clickIGual (object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num2 = Convert.ToDouble(txtDatos.Text);
            if (operador == '+')
            {
                txtDatos.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtDatos.Text);

            }
            else if(operador == '-')
            {
                txtDatos.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtDatos.Text);
            }
            else if (operador == 'X')
            {
                txtDatos.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtDatos.Text);
            }
            else if (operador == '/')
            {
                txtDatos.Text = (num1 / num2).ToString();
                num1 = Convert.ToDouble(txtDatos.Text);
            }

        }

        //Borrar todo
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDatos.Text = "0";
        }
        private void btnCe_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtDatos.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}