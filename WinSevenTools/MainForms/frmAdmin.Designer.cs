namespace WinSevenTools.MainForms
{
    partial class frmAdmin
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cUserID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.pnlUserControls = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cEventID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEventDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.pnlUserControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.SystemColors.Highlight;
            // 
            // lblHome
            // 
            this.lblHome.Size = new System.Drawing.Size(179, 24);
            this.lblHome.Text = "Administrator Panel";
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
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUserID,
            this.cUserName,
            this.cUserRole});
            this.dgvUsers.Location = new System.Drawing.Point(11, 100);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.Size = new System.Drawing.Size(303, 750);
            this.dgvUsers.TabIndex = 1;
            // 
            // cUserID
            // 
            this.cUserID.HeaderText = "UserID";
            this.cUserID.Name = "cUserID";
            this.cUserID.ReadOnly = true;
            this.cUserID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cUserID.Width = 75;
            // 
            // cUserName
            // 
            this.cUserName.HeaderText = "UserName";
            this.cUserName.Name = "cUserName";
            this.cUserName.ReadOnly = true;
            this.cUserName.Width = 150;
            // 
            // cUserRole
            // 
            this.cUserRole.HeaderText = "UserRole";
            this.cUserRole.Name = "cUserRole";
            this.cUserRole.ReadOnly = true;
            this.cUserRole.Width = 75;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEventID,
            this.cEventType,
            this.cEventDescription});
            this.dgvEvents.Location = new System.Drawing.Point(1086, 100);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.Size = new System.Drawing.Size(500, 750);
            this.dgvEvents.TabIndex = 2;
            // 
            // pnlUserControls
            // 
            this.pnlUserControls.BackColor = System.Drawing.Color.Silver;
            this.pnlUserControls.Controls.Add(this.btnRemoveUser);
            this.pnlUserControls.Controls.Add(this.btnEditUser);
            this.pnlUserControls.Controls.Add(this.btnAddUser);
            this.pnlUserControls.Location = new System.Drawing.Point(314, 100);
            this.pnlUserControls.Name = "pnlUserControls";
            this.pnlUserControls.Size = new System.Drawing.Size(200, 750);
            this.pnlUserControls.TabIndex = 3;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.Location = new System.Drawing.Point(9, 121);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(180, 50);
            this.btnRemoveUser.TabIndex = 2;
            this.btnRemoveUser.Text = "Gebruiker Verwijderen";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(9, 65);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(180, 50);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Gebruiker Wijzigen";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(9, 9);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(180, 50);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Gebruiker Toevoegen";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cEventID
            // 
            this.cEventID.HeaderText = "EventID";
            this.cEventID.Name = "cEventID";
            this.cEventID.ReadOnly = true;
            this.cEventID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEventID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cEventID.Width = 75;
            // 
            // cEventType
            // 
            this.cEventType.HeaderText = "EventType";
            this.cEventType.Name = "cEventType";
            this.cEventType.ReadOnly = true;
            this.cEventType.Width = 75;
            // 
            // cEventDescription
            // 
            this.cEventDescription.HeaderText = "EventDescription";
            this.cEventDescription.Name = "cEventDescription";
            this.cEventDescription.ReadOnly = true;
            this.cEventDescription.Width = 345;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.pnlUserControls);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.dgvUsers);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAdmin";
            this.Text = "Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.Controls.SetChildIndex(this.pnlHome, 0);
            this.Controls.SetChildIndex(this.dgvUsers, 0);
            this.Controls.SetChildIndex(this.dgvEvents, 0);
            this.Controls.SetChildIndex(this.pnlUserControls, 0);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.pnlUserControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTab ribTabHome;
        private System.Windows.Forms.RibbonTab ribTabTools;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewButtonColumn cUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserRole;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Panel pnlUserControls;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridViewButtonColumn cEventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEventDescription;
    }
}