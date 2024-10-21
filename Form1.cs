using System;
using System.Windows.Forms;

namespace CuentaAtras
{
    public partial class Form1 : Form
    {
        private Timer countdownTimer;
        private TimeSpan remainingTime;
        private bool isCountingDown = false; // Variable para verificar si la cuenta regresiva est� en marcha

        public Form1()
        {
            InitializeComponent();

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;

            btnStart.Text = "Iniciar"; // Establece el texto inicial del bot�n
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isCountingDown) // Si la cuenta regresiva est� en marcha, parar
            {
                countdownTimer.Stop();
                btnStart.Text = "Iniciar"; // Cambiar el texto del bot�n a "Iniciar"
                isCountingDown = false;
            }
            else // Si no est� en marcha, iniciar
            {
                // Obtener el tiempo en segundos desde el TextBox
                if (int.TryParse(txtTimeInput.Text, out int seconds))
                {
                    remainingTime = TimeSpan.FromSeconds(seconds);
                    lblCountdown.Text = remainingTime.ToString(@"hh\:mm\:ss");
                    countdownTimer.Start();
                    btnStart.Text = "Parar"; // Cambiar el texto del bot�n a "Parar"
                    isCountingDown = true;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un n�mero v�lido.");
                }
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Reducir el tiempo restante
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                lblCountdown.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                countdownTimer.Stop();
                MessageBox.Show("�El tiempo ha terminado!");
                btnStart.Text = "Iniciar"; // Cambiar el texto del bot�n a "Iniciar" cuando el tiempo se acaba
                isCountingDown = false;
            }
        }
    }
}
