using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGA.Telas
{
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();
        }

        private void TelaRelatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
