namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        String operador;

        public Form1()
        {
            InitializeComponent();
        }

        Operaciones op = new Operaciones();

        private void btn7_Click(object sender, EventArgs e)
        {

            txtPantalla.Text = txtPantalla.Text + "7";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 9;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text+ 6;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + 0;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else { 
                operador = "+";
                primero = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if(txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "-";
            }
            else
            {
                operador = "-";
                primero = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }    
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                operador = "*";
                primero = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                operador = "/";
                primero = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
        }

        private void btnResiduo_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                operador = "mod";
                primero = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
        }

        private void btnPorciento_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                operador = "%";
                primero = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double resultado;
            segundo = double.Parse(txtPantalla.Text);

            switch(operador)
            {
                case "+":
                    resultado = op.Sumar(primero, segundo);
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = op.Restar(primero, segundo);
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = op.Multiplicar(primero, segundo);
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "/":
                    if(segundo == 0)
                    {
                        txtPantalla.Text = "ERROR";
                    } else
                    {
                        resultado = op.Dividir(primero, segundo);
                        txtPantalla.Text = resultado.ToString();
                    }
                    break;
                case "%":
                    resultado = op.Porciento(primero, segundo);
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "mod":
                    resultado = op.Residuo(primero, segundo);
                    txtPantalla.Text= resultado.ToString();
                    break;
            }
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                double resultado;
                primero = double.Parse(txtPantalla.Text);
                resultado = primero * -1;
                txtPantalla.Text = resultado.ToString();
            }
        }

        private void btnPotenciaCuadrada_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                double resultado;
                primero = double.Parse(txtPantalla.Text);
                resultado = op.ElevarAlCuadrado(primero);
                txtPantalla.Text = resultado.ToString();
            }
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length <= 0)
            {
                txtPantalla.Text = "";
            }
            else
            {
                double resultado;
                primero = double.Parse(txtPantalla.Text);
                resultado = op.RaizCuadrada(primero);
                txtPantalla.Text = resultado.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }
    }
}