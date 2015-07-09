using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSevenTools.SQL;

namespace WinSevenTools
{
    public partial class frmMainLayout : Form
    {
        protected SQLQueryManager sqlQMgr = null;
        
        public frmMainLayout()
        {
            InitializeComponent();
            sqlQMgr = new SQLQueryManager();
        }       
    }
}
