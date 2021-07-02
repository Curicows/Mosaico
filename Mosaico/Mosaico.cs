using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaico
{
    public class Mosaico
    {
        private Image[] imagens;
        private Timer timer = new Timer();
        private FolderBrowserDialog browser = new FolderBrowserDialog();
        
        private int intervalo = 5000;
        
        public Mosaico()
        {
            
        }

        public string browseFiles()
        {
            this.browser.ShowDialog();
            return this.browser.SelectedPath;
        }

        
        
        
        
        
        
        
        public void StartTimer()
        {
            this.timer.Start();
        }

        public void StopTimer()
        {
            this.timer.Stop();
        }

        public void setIntervalo(int intervalo)
        {
            this.intervalo = intervalo;
            this.timer.Interval = intervalo;
        }

        public int getIntervalo()
        {
            return this.intervalo;
        }


    }
}