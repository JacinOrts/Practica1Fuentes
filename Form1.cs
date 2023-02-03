using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {            
            this.Font = new Font(this.Font, FontStyle.Bold);
        }
        private void btnCursiva_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font, FontStyle.Italic); 
        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font, FontStyle.Underline);
        }
    }
}
