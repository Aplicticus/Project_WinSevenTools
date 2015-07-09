using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinSevenTools.Libraries;
using WinSevenTools.SQL;

namespace WinSevenTools.MainForms
{
    public partial class frmAdmin : frmMainLayout
    {
        private string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
        private SQLConnectionManager sqlMgr = new SQLConnectionManager();
        public frmAdmin(string Username, int UserRole)
        {
            InitializeComponent();
            lblName.Text = Username;
            FillDGVUsers();
            FillDGVEvents();


            // Encryption Test --> Save DB ( Add User )
            Rijndael rijndael = new Rijndael();

            string Test = rijndael.Encrypt("Testje"); // Encrypt Key

            string absoluteTest = rijndael.Decrypt(Test); // Decrypt Key


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
        private void FillDGVUsers()
        {
            // Fill Data grid view (not finished) !!!
            string sqlQuery = sqlQMgr.sqlQueries.Where(x => x.Key == "SelectAllUsers").FirstOrDefault().Value;
            DataTable dt = sqlMgr.ReadDatabaseToDataTable(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                dgvUsers.Rows.Add(dr[0].ToString());
            }
        }
        private void FillDGVEvents()
        {
            // Fill Data grid view (not finished) !!!
            string sqlQuery = sqlQMgr.sqlQueries.Where(x => x.Key == "SelectAllEvents").First().Value;
            DataTable dt = sqlMgr.ReadDatabaseToDataTable(sqlQuery);
            foreach (DataRow dr in dt.Rows)
            {
                dgvEvents.Rows.Add(dr[0].ToString());
            }
        }

        #region Buttons
        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
