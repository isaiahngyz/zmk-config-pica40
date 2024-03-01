namespace ZMKSplit
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevicesListView = new System.Windows.Forms.ListView();
            NameColumn = new System.Windows.Forms.ColumnHeader();
            NotifyIcon = new System.Windows.Forms.NotifyIcon(components);
            TrayContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            showContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ReloadButton = new System.Windows.Forms.Button();
            StatusStrip1 = new System.Windows.Forms.StatusStrip();
            StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ConnectButton = new System.Windows.Forms.Button();
            ReconnectTimer = new System.Windows.Forms.Timer(components);
            AutoRunCheckBox = new System.Windows.Forms.CheckBox();
            TrayContextMenu.SuspendLayout();
            StatusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DevicesListView
            // 
            DevicesListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DevicesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { NameColumn });
            DevicesListView.FullRowSelect = true;
            DevicesListView.GridLines = true;
            DevicesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            DevicesListView.HideSelection = false;
            DevicesListView.Location = new System.Drawing.Point(12, 12);
            DevicesListView.MultiSelect = false;
            DevicesListView.Name = "DevicesListView";
            DevicesListView.ShowGroups = false;
            DevicesListView.Size = new System.Drawing.Size(382, 103);
            DevicesListView.TabIndex = 0;
            DevicesListView.UseCompatibleStateImageBehavior = false;
            DevicesListView.View = System.Windows.Forms.View.Details;
            DevicesListView.DoubleClick += DevicesListView_DoubleClick;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 378;
            // 
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = TrayContextMenu;
            NotifyIcon.Visible = true;
            NotifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // TrayContextMenu
            // 
            TrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showContextMenuItem, exitContextMenuItem });
            TrayContextMenu.Name = "trayContextMenu";
            TrayContextMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // showContextMenuItem
            // 
            showContextMenuItem.Name = "showContextMenuItem";
            showContextMenuItem.Size = new System.Drawing.Size(103, 22);
            showContextMenuItem.Text = "Show";
            showContextMenuItem.Click += ShowContextMenuItem_Click;
            // 
            // exitContextMenuItem
            // 
            exitContextMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            exitContextMenuItem.Name = "exitContextMenuItem";
            exitContextMenuItem.Size = new System.Drawing.Size(103, 22);
            exitContextMenuItem.Text = "E&xit";
            exitContextMenuItem.Click += ExitContextMenuItem_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ReloadButton.Location = new System.Drawing.Point(407, 12);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new System.Drawing.Size(158, 32);
            ReloadButton.TabIndex = 3;
            ReloadButton.Text = "Refresh";
            ReloadButton.UseVisualStyleBackColor = true;
            ReloadButton.MouseClick += ReloadButton_MouseClick;
            // 
            // StatusStrip1
            // 
            StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StatusLabel });
            StatusStrip1.Location = new System.Drawing.Point(0, 118);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Size = new System.Drawing.Size(577, 22);
            StatusStrip1.TabIndex = 4;
            StatusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(39, 17);
            StatusLabel.Text = "Ready";
            // 
            // ConnectButton
            // 
            ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            ConnectButton.Location = new System.Drawing.Point(407, 50);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new System.Drawing.Size(158, 32);
            ConnectButton.TabIndex = 5;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ReconnectTimer
            // 
            ReconnectTimer.Interval = 1000;
            ReconnectTimer.Tick += ReconnectTimer_Tick;
            // 
            // AutoRunCheckBox
            // 
            AutoRunCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            AutoRunCheckBox.AutoSize = true;
            AutoRunCheckBox.Location = new System.Drawing.Point(408, 88);
            AutoRunCheckBox.Name = "AutoRunCheckBox";
            AutoRunCheckBox.Size = new System.Drawing.Size(152, 19);
            AutoRunCheckBox.TabIndex = 6;
            AutoRunCheckBox.Text = "Run at Windows startup";
            AutoRunCheckBox.UseVisualStyleBackColor = true;
            AutoRunCheckBox.CheckedChanged += AutoRunCheckBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(577, 140);
            Controls.Add(AutoRunCheckBox);
            Controls.Add(ConnectButton);
            Controls.Add(StatusStrip1);
            Controls.Add(ReloadButton);
            Controls.Add(DevicesListView);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ZMK Split Battery Status";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            TrayContextMenu.ResumeLayout(false);
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView DevicesListView;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContextMenuItem;
        private System.Windows.Forms.Timer ReconnectTimer;
        private System.Windows.Forms.CheckBox AutoRunCheckBox;
    }
}
