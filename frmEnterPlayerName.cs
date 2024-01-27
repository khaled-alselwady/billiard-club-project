using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billiard_Club_Project
{
    public partial class frmEnterPlayerName : Form
    {
        public Action<string> PlayerNameBack;

        public frmEnterPlayerName()
        {
            InitializeComponent();
        }

        private void txtNamePlayer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamePlayer.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNamePlayer, "This field cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtNamePlayer, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("You have to enter the name first!", "Miss Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            PlayerNameBack?.Invoke(txtNamePlayer.Text.Trim());
            this.Close();
        }
    }
}
