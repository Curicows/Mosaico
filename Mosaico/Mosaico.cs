using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaico
{
    public class Mosaico
    {
        private Image[] imagens;
        private Timer timer = new Timer();
        
        
        private Panel _panel2 = new Panel();

        private int _intervalo = 5000;

        public Mosaico()
        {
            this.timer.Tick += this.Timer_Tick;
            this._panel2.Dock = DockStyle.Fill;
            this._panel2.Location = new Point(0, 0);
            this._panel2.Name = "imagem";
            this._panel2.TabIndex = 1;
            //this._panel2.BackColor = Color.Aqua;
        }
        
        public void StartTimer()
        {
            timer.Start();
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs eventArgs)
        {
            
        }





        public Panel GetPanel()
        {
            return this._panel2;
        }

        public void SetIntervalo(int intervalo)
        {
            this._intervalo = intervalo;
            timer.Interval = intervalo;
        }

        public int GetIntervalo()
        {
            return _intervalo;
        }
    }
}