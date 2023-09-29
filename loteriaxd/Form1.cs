using System;
using System.Windows.Forms;

namespace LoteriaApp
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            // Agrega el controlador de eventos a las cajas de texto del monto y del GrupoBox
            monto.KeyPress += cajaMonto_KeyPress;
            cajap1.KeyPress += cajasGrupo_KeyPress;
            cajap2.KeyPress += cajasGrupo_KeyPress;
            cajap3.KeyPress += cajasGrupo_KeyPress;
        }

        private void loteria_Click(object sender, EventArgs e)
        {
            // Verificar si se ha ingresado un monto válido
            if (!int.TryParse(monto.Text, out int montoJuego) || montoJuego <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor que cero.");
                return;
            }

            // Determinar cuántas cajas de juego están habilitadas
            int cajasHabilitadas = radioButtonPale.Checked ? 2 : (radioButtonSolo.Checked ? 1 : 0);

            // Generar números aleatorios y mostrarlos en los botones de resultados
            int resultado1Numero = GenerarNumeroAleatorio();
            int resultado2Numero = GenerarNumeroAleatorio();
            int resultado3Numero = GenerarNumeroAleatorio();

            resultado1.Text = resultado1Numero.ToString();
            resultado2.Text = resultado2Numero.ToString();
            resultado3.Text = resultado3Numero.ToString();

            // Verificar si los números coinciden con las cajas de juego
            int coincidencias = VerificarCoincidencias(resultado1Numero, resultado2Numero, resultado3Numero, cajasHabilitadas);

            // Calcular el resultado total
            int resultadoTotal = montoJuego * (coincidencias > 0 ? (radioButtonPale.Checked ? 3 : 2) : 0);

            // Mostrar el resultado total
            total.Text = resultadoTotal.ToString();

            // Mostrar el mensaje final en el botón final
            final.Text = (coincidencias > 0) ? "GANE" : "PERDI";
        }

        private int GenerarNumeroAleatorio()
        {
            return random.Next(0, 100);
        }

        private int VerificarCoincidencias(int num1, int num2, int num3, int cajasHabilitadas)
        {
            int coincidencias = 0;

            if (cajasHabilitadas >= 1 && num1 == ObtenerValorCaja(cajap1))
            {
                coincidencias++;
            }
            if (cajasHabilitadas >= 2 && num2 == ObtenerValorCaja(cajap2))
            {
                coincidencias++;
            }
            if (cajasHabilitadas >= 1 && num3 == ObtenerValorCaja(cajap3))
            {
                coincidencias++;
            }

            return coincidencias;
        }

        private int ObtenerValorCaja(TextBox caja)
        {
            if (int.TryParse(caja.Text, out int valorCaja))
            {
                return valorCaja;
            }

            return -1; // Valor no válido
        }

        private void cajaMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox caja = sender as TextBox;

            // Verifica si el carácter es un número o control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número ni un control
            }
        }

        private void cajasGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox caja = sender as TextBox;

            // Verifica si el carácter es un número o control (como retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número ni un control
            }
            else if (char.IsDigit(e.KeyChar) && caja.Text.Length >= 2)
            {
                e.Handled = true; // Ignora el carácter si ya hay 2 números
            }
        }
    }
}
