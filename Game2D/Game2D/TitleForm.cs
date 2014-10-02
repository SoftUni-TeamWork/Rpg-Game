using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2D
{
    public partial class TitleForm : Form
    {
        public TitleForm()
        {
            InitializeComponent();
        }

        private void Title_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void TitleTrue_Click(object sender, EventArgs e)
        {

        }
    }
}
