using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mosaico
{
    public partial class Form1 : Form
    {
        private Mosaico mosaico = new Mosaico();
        public Form1()
        {
            InitializeComponent();
            
            //this.goFullscreen();
        }

        public void goFullscreen()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mosaico.browseFiles();
        }

        
        
        // events
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            Debug.WriteLine(letra);
            if (letra == Char.Parse("a") || letra == Char.Parse("A"))
            {
                MessageBox.Show(letra.ToString());
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("down");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}