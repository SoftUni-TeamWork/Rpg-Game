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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            TitleForm TitleForm = new TitleForm();
            TitleForm.ShowDialog();

            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            GameForm Game = new GameForm();

            if (Game.ShowDialog() == DialogResult.Yes)
            {
                GameCompletedForm Completed = new GameCompletedForm();
                Completed.ShowDialog();
            }
            else
            {
                GameOverForm Over = new GameOverForm();
                Over.ShowDialog();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
