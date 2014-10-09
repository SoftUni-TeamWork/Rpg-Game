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
    public partial class GameCompletedForm : Form
    {
        public GameCompletedForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameCompleted_Load(object sender, EventArgs e)
        {

        }

        private void GameCompleted_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
