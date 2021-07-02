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
        private Mosaico _mosaico = new Mosaico();
        private ConfigForm _configForm = new ConfigForm();

        private bool _isFullscreen = false;
        public Form1()
        {
            InitializeComponent();
            this.panel1.Controls.Add(this._mosaico.GetPanel());
            
        }

        private void ToggleFullscreen()
        {
            if (_isFullscreen)
            {
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this._isFullscreen = false;
            }
            else
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this._isFullscreen = true;
            }
        }
        
        // events
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        this.ToggleFullscreen();
                        break;
                    case Keys.C:
                        this._configForm.Show();
                        MessageBox.Show("ssdggdhdgfghs");
                        break;
                }
            }
        }
    }
}