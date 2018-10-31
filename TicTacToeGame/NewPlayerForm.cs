using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class NewPlayerForm : Form
    {
        public NewPlayerForm()
        {
            InitializeComponent();
        }
        public string Name;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txBxName.Text.Trim() == "")
            {
                Name = System.Environment.MachineName.ToUpper() + "_Ply1";
            }
            else
            {
                Name = txBxName.Text.ToUpper();
            }
            this.Close();
        }
    }
}
