using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiMega_Client
{
    public partial class formgestao : Form
    {
        public formgestao()
        {
            InitializeComponent();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
