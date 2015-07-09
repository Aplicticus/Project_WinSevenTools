using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using WinSevenTools.MainForms;
using WinSevenTools.SQL;

namespace WinSevenTools
{    
    public partial class frmStart : Form
    {
        private string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
        private SQLQueryManager sqlMgr = null;
        public frmStart()
        {
            InitializeComponent();
            txtUsername.KeyDown += new KeyEventHandler(EnterKey);
            txtPassword.KeyDown += new KeyEventHandler(EnterKey);
            sqlMgr = new SQLQueryManager();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 1 && txtPassword.Text.Length > 1)
            {
                UserData currentUser = ReadDatabase(txtUsername.Text, txtPassword.Text); // Read Users from database
                if (currentUser != null)
                {
                    switch (currentUser.UserRole)
                    {
                        case 1:
                            frmAdmin Admin = new frmAdmin(currentUser.UserName, currentUser.UserRole);
                            Admin.ShowDialog();
                            break;
                        case 2:
                            frmDeveloper Developer = new frmDeveloper(currentUser.UserName, currentUser.UserRole);
                            Developer.ShowDialog();
                            break;
                        case 3:
                            frmManager Manager = new frmManager(currentUser.UserName, currentUser.UserRole);
                            Manager.ShowDialog();
                            break;
                        case 4:
                            frmUser User = new frmUser(currentUser.UserName, currentUser.UserRole);
                            User.ShowDialog();
                            break;
                        case 5:
                            frmGuest Guest = new frmGuest(currentUser.UserName, currentUser.UserRole);
                            Guest.ShowDialog();
                            break;
                        default:
                            frmGuest Default = new frmGuest(currentUser.UserName, currentUser.UserRole);
                            Default.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to login. The Username or Password is incorrect or you are already.");
                }
            }
            else
            {
                MessageBox.Show("Username or Password cannot be empty.");
            }
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        

        private UserData ReadDatabase(string Username, string Password)
        {
            try
            {
                UserData userData = new UserData();
                using (SqlConnection sqlConn = new SqlConnection(sqlConnectionString))
                {
                    string sqlQuery = sqlMgr.sqlQueries.Where(x => x.Key == "SelectAllUsers").FirstOrDefault().Value;
                    SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
                    sqlConn.Open();
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    while (reader.Read())
                    {                        
                        userData.UserID = reader.GetInt32(0);
                        userData.UserName = reader.GetString(1);
                        userData.UserSecret = reader.GetString(2);
                        userData.UserRole = reader.GetInt16(3);
                        if (Username == userData.UserName && Password == userData.UserSecret)
                        {
                            return new UserData() { UserID = userData.UserID, UserName = userData.UserName, UserSecret = userData.UserSecret, UserRole = userData.UserRole };
                        }
                    }
                    sqlConn.Close();
                }
            }
            catch (Exception Ex)
            {
                Ex.ToString();
            }
            return null;
        }
        private void EnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
