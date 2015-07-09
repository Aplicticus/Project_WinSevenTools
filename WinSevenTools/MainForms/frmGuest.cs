using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSevenTools.MainForms
{
    public partial class frmGuest : frmMainLayout
    {
        public frmGuest(string Username, int UserRole)
        {
            InitializeComponent();
            lblName.Text = Username;
        }
        private void frmClosing(object Sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Wilt u dit venster sluiten?", "Sluiten?", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
