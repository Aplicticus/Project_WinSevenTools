namespace WinSevenTools.MainForms
{
    partial class frmManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribTabHome = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribTabTools = new System.Windows.Forms.RibbonTab();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Violet;
            // 
            // lblHome
            // 
            this.lblHome.Size = new System.Drawing.Size(138, 24);
            this.lblHome.Text = "Systeembeheer";
            // 
            // ribTabHome
            // 
            this.ribTabHome.Panels.Add(this.ribbonPanel1);
            this.ribTabHome.Text = "Home";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribTabTools
            // 
            this.ribTabTools.Text = "Tools";
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 492);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmManager";
            this.Text = "Systeembeheerder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribTabHome;
        private System.Windows.Forms.RibbonTab ribTabTools;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
    }
}