﻿namespace m3u8.download.manager.ui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator s1;
            System.Windows.Forms.ToolStripSeparator s2;
            System.Windows.Forms.ToolStripSeparator s3;
            System.Windows.Forms.ToolStripSeparator s4;
            System.Windows.Forms.ToolStripSeparator s5;
            this.downloadListUC = new m3u8.download.manager.ui.DownloadListUC();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.addNewDownloadToolButton = new System.Windows.Forms.ToolStripButton();
            this.startDownloadToolButton = new System.Windows.Forms.ToolStripButton();
            this.pauseDownloadToolButton = new System.Windows.Forms.ToolStripButton();
            this.cancelDownloadToolButton = new System.Windows.Forms.ToolStripButton();
            this.deleteDownloadToolButton = new System.Windows.Forms.ToolStripButton();
            this.deleteAllFinishedDownloadToolButton = new System.Windows.Forms.ToolStripButton();
            this.showLogToolButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolButton = new System.Windows.Forms.ToolStripButton();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.logUC = new m3u8.download.manager.ui.LogUC();
            this.statusBarUC = new m3u8.download.manager.ui.StatusBarUC();
            s1 = new System.Windows.Forms.ToolStripSeparator();
            s2 = new System.Windows.Forms.ToolStripSeparator();
            s3 = new System.Windows.Forms.ToolStripSeparator();
            s4 = new System.Windows.Forms.ToolStripSeparator();
            s5 = new System.Windows.Forms.ToolStripSeparator();

            System.Windows.Forms.ToolStripSeparator s6;
            System.Windows.Forms.ToolStripSeparator s7;
            System.Windows.Forms.ToolStripSeparator s8;
            System.Windows.Forms.ToolStripSeparator s9;
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.startDownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseDownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelDownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWithOutputFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            //---this.allDownloadsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllFinishedDownloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllDownloadsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseAllDownloadsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAllDownloadsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllDownloadsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllWithOutputFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            s6 = new System.Windows.Forms.ToolStripSeparator();
            s7 = new System.Windows.Forms.ToolStripSeparator();
            s8 = new System.Windows.Forms.ToolStripSeparator();
            s9 = new System.Windows.Forms.ToolStripSeparator();
            this.mainContextMenu.SuspendLayout();

            this.mainToolStrip.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadListUC
            // 
            this.downloadListUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadListUC.Location = new System.Drawing.Point(0, 0);
            this.downloadListUC.Name = "downloadListUC";
            this.downloadListUC.Size = new System.Drawing.Size(1015, 249);
            this.downloadListUC.TabIndex = 0;
            this.downloadListUC.SelectionChanged += new m3u8.download.manager.ui.DownloadListUC.SelectionChangedEventHandler(this.downloadListUC_SelectionChanged);
            this.downloadListUC.OutputFileNameClick += new m3u8.download.manager.ui.DownloadListUC.OutputFileNameClickEventHandler(this.downloadListUC_OutputFileNameClick);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.addNewDownloadToolButton,
                s1,
                this.startDownloadToolButton,
                this.pauseDownloadToolButton,
                this.cancelDownloadToolButton,
                s2,
                this.deleteDownloadToolButton,
                this.deleteAllFinishedDownloadToolButton,
                s3,
                this.showLogToolButton,
                s4,
                this.copyToolButton,
                this.pasteToolButton,
                s5,
                this.aboutToolButton
            });
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Size = new System.Drawing.Size(1015, 39);
            this.mainToolStrip.TabIndex = 0;
            // 
            // addNewDownloadToolButton
            // 
            this.addNewDownloadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addNewDownloadToolButton.Image = global::m3u8.download.manager.Properties.Resources.plus;
            this.addNewDownloadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewDownloadToolButton.Size = new System.Drawing.Size(36, 36);
            this.addNewDownloadToolButton.ToolTipText = "Add new download  (Insert)";
            this.addNewDownloadToolButton.Click += new System.EventHandler(this.addNewDownloadToolButton_Click);
            // 
            // startDownloadToolButton
            // 
            this.startDownloadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startDownloadToolButton.Enabled = false;
            this.startDownloadToolButton.Image = global::m3u8.download.manager.Properties.Resources.control_start;
            this.startDownloadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startDownloadToolButton.Size = new System.Drawing.Size(36, 36);
            this.startDownloadToolButton.ToolTipText = "Start download  (Ctrl + S)";
            this.startDownloadToolButton.Click += new System.EventHandler(this.startDownloadToolButton_Click);
            // 
            // pauseDownloadToolButton
            // 
            this.pauseDownloadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseDownloadToolButton.Enabled = false;
            this.pauseDownloadToolButton.Image = global::m3u8.download.manager.Properties.Resources.control_pause;
            this.pauseDownloadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseDownloadToolButton.Size = new System.Drawing.Size(36, 36);
            this.pauseDownloadToolButton.ToolTipText = "Pause download  (Ctrl + P)";
            this.pauseDownloadToolButton.Click += new System.EventHandler(this.pauseDownloadToolButton_Click);
            // 
            // cancelDownloadToolButton
            // 
            this.cancelDownloadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelDownloadToolButton.Enabled = false;
            this.cancelDownloadToolButton.Image = global::m3u8.download.manager.Properties.Resources.control_cancel;
            this.cancelDownloadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelDownloadToolButton.Size = new System.Drawing.Size(36, 36);
            this.cancelDownloadToolButton.ToolTipText = "Cancel download  (Ctrl + Z)";
            this.cancelDownloadToolButton.Click += new System.EventHandler(this.cancelDownloadToolButton_Click);
            // 
            // deleteDownloadToolButton
            // 
            this.deleteDownloadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteDownloadToolButton.Enabled = false;
            this.deleteDownloadToolButton.Image = global::m3u8.download.manager.Properties.Resources.control_delete;
            this.deleteDownloadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteDownloadToolButton.Size = new System.Drawing.Size(36, 36);
            this.deleteDownloadToolButton.ToolTipText = "Delete download  (Del)\r\nWith output file  (Shift + Del)";
            this.deleteDownloadToolButton.Click += new System.EventHandler(this.deleteDownloadToolButton_Click);
            // 
            // deleteAllFinishedDownloadToolButton
            // 
            this.deleteAllFinishedDownloadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteAllFinishedDownloadToolButton.Enabled = false;
            this.deleteAllFinishedDownloadToolButton.Image = global::m3u8.download.manager.Properties.Resources.control_delete_all_finished;
            this.deleteAllFinishedDownloadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAllFinishedDownloadToolButton.Size = new System.Drawing.Size(36, 36);
            this.deleteAllFinishedDownloadToolButton.ToolTipText = "Delete all finished downloads";
            this.deleteAllFinishedDownloadToolButton.Click += new System.EventHandler(this.deleteAllFinishedDownloadToolButton_Click);
            // 
            // showLogToolButton
            // 
            this.showLogToolButton.Checked = true;
            this.showLogToolButton.CheckOnClick = true;
            this.showLogToolButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLogToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showLogToolButton.Image = global::m3u8.download.manager.Properties.Resources.log;
            this.showLogToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showLogToolButton.Size = new System.Drawing.Size(36, 36);
            this.showLogToolButton.ToolTipText = "Show/Hide download log";
            this.showLogToolButton.Click += new System.EventHandler(this.showLogToolButton_Click);
            // 
            // copyToolButton
            // 
            this.copyToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolButton.Image = global::m3u8.download.manager.Properties.Resources.copy;
            this.copyToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolButton.Size = new System.Drawing.Size(36, 36);
            this.copyToolButton.ToolTipText = "Copy  (Ctrl + C)";
            this.copyToolButton.Click += new System.EventHandler(this.copyToolButton_Click);
            // 
            // pasteToolButton
            // 
            this.pasteToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolButton.Image = global::m3u8.download.manager.Properties.Resources.paste;
            this.pasteToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolButton.Size = new System.Drawing.Size(36, 36);
            this.pasteToolButton.ToolTipText = "Paste  (Ctrl + V)";
            this.pasteToolButton.Click += new System.EventHandler(this.pasteToolButton_Click);
            // 
            // aboutToolButton
            // 
            this.aboutToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolButton.Image = global::m3u8.download.manager.Properties.Resources.help;
            this.aboutToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolButton.Size = new System.Drawing.Size(36, 36);
            this.aboutToolButton.ToolTipText = "About";
            this.aboutToolButton.Click += new System.EventHandler(this.aboutToolButton_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 39);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.mainSplitContainer.Panel1.Controls.Add(this.downloadListUC);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.mainSplitContainer.Panel2.Controls.Add(this.logUC);
            this.mainSplitContainer.Size = new System.Drawing.Size(1015, 540);
            this.mainSplitContainer.SplitterDistance = 249;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // logUC
            // 
            this.logUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logUC.Location = new System.Drawing.Point(0, 0);
            this.logUC.Name = "logUC";
            this.logUC.Size = new System.Drawing.Size(1015, 287);
            this.logUC.TabIndex = 0;
            // 
            // statusBarUC
            // 
            this.statusBarUC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarUC.Location = new System.Drawing.Point( 0, 270 );
            this.statusBarUC.Size = new System.Drawing.Size( 803, 35 );
            this.statusBarUC.TabIndex = 4;

            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
                this.startDownloadMenuItem,
                this.pauseDownloadMenuItem,
                this.cancelDownloadMenuItem,
                s6,
                this.deleteDownloadMenuItem,
                this.deleteWithOutputFileMenuItem,
                s7,
                this.deleteAllFinishedDownloadMenuItem,
                s8,
                //---this.allDownloadsMenuItem
                this.startAllDownloadsMenuItem,
                this.pauseAllDownloadsMenuItem,
                this.cancelAllDownloadsMenuItem,
                s9,
                this.deleteAllDownloadsMenuItem,
                this.deleteAllWithOutputFilesMenuItem
            } );
            this.mainContextMenu.Size = new System.Drawing.Size( 183, 176 );
            // 
            // startDownloadMenuItem
            // 
            this.startDownloadMenuItem.Image = global::m3u8.download.manager.Properties.Resources.running;
            this.startDownloadMenuItem.Text = "Start";
            this.startDownloadMenuItem.ShortcutKeyDisplayString = "(Ctrl + S)";
            this.startDownloadMenuItem.Click += new System.EventHandler( this.startDownloadMenuItem_Click );
            // 
            // pauseDownloadMenuItem
            // 
            this.pauseDownloadMenuItem.Image = global::m3u8.download.manager.Properties.Resources.paused;
            this.pauseDownloadMenuItem.Text = "Pause";
            this.pauseDownloadMenuItem.ShortcutKeyDisplayString = "(Ctrl + P)";
            this.pauseDownloadMenuItem.Click += new System.EventHandler( this.pauseDownloadMenuItem_Click );
            // 
            // cancelDownloadMenuItem
            // 
            this.cancelDownloadMenuItem.Image = global::m3u8.download.manager.Properties.Resources.cancel;
            this.cancelDownloadMenuItem.Text = "Cancel";
            this.cancelDownloadMenuItem.ShortcutKeyDisplayString = "(Ctrl + Z)";
            this.cancelDownloadMenuItem.Click += new System.EventHandler( this.cancelDownloadMenuItem_Click );
            // 
            // deleteDownloadMenuItem
            // 
            this.deleteDownloadMenuItem.Image = global::m3u8.download.manager.Properties.Resources.delete;
            this.deleteDownloadMenuItem.Text = "Delete";
            this.deleteDownloadMenuItem.ShortcutKeyDisplayString = "(Del)";
            this.deleteDownloadMenuItem.Click += new System.EventHandler( this.deleteDownloadMenuItem_Click );
            // 
            // deleteWithOutputFileMenuItem
            // 
            this.deleteWithOutputFileMenuItem.Text = "Delete with Output file";
            this.deleteWithOutputFileMenuItem.ShortcutKeyDisplayString = "(Shift + Del)";
            this.deleteWithOutputFileMenuItem.Click += new System.EventHandler( this.deleteWithOutputFileMenuItem_Click );
            /*
            // 
            // allDownloadsMenuItem
            // 
            this.allDownloadsMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
                this.startAllDownloadsMenuItem,
                this.pauseAllDownloadsMenuItem,
                this.cancelAllDownloadsMenuItem,
                s9,
                this.deleteAllDownloadsMenuItem,
                this.deleteAllWithOutputFilesMenuItem
            } );
            this.allDownloadsMenuItem.Text = "All";
            this.allDownloadsMenuItem.DropDownOpening += new System.EventHandler(this.allDownloadsMenuItem_DropDownOpening);
            */
            // 
            // deleteAllFinishedDownloadMenuItem
            // 
            this.deleteAllFinishedDownloadMenuItem.Image = global::m3u8.download.manager.Properties.Resources.control_delete_all_finished;
            this.deleteAllFinishedDownloadMenuItem.Text = "Delete all finished downloads";
            this.deleteAllFinishedDownloadMenuItem.Click += new System.EventHandler(this.deleteAllFinishedDownloadToolButton_Click);
            // 
            // startAllDownloadsMenuItem
            // 
            this.startAllDownloadsMenuItem.Image = global::m3u8.download.manager.Properties.Resources.start_all;
            this.startAllDownloadsMenuItem.Text = "      Start all...";
            this.startAllDownloadsMenuItem.Click += new System.EventHandler(this.startAllDownloadsMenuItem_Click);
            // 
            // pauseAllDownloadsMenuItem
            // 
            this.pauseAllDownloadsMenuItem.Image = global::m3u8.download.manager.Properties.Resources.pause_all;
            this.pauseAllDownloadsMenuItem.Text = "      Pause all...";
            this.pauseAllDownloadsMenuItem.Click += new System.EventHandler(this.pauseAllDownloadsMenuItem_Click);
            // 
            // cancelAllDownloadsMenuItem
            // 
            this.cancelAllDownloadsMenuItem.Image = global::m3u8.download.manager.Properties.Resources.cancel_all;
            this.cancelAllDownloadsMenuItem.Text = "      Cancel all...";
            this.cancelAllDownloadsMenuItem.Click += new System.EventHandler(this.cancelAllDownloadsMenuItem_Click);
            // 
            // deleteAllDownloadsMenuItem
            // 
            this.deleteAllDownloadsMenuItem.Image = global::m3u8.download.manager.Properties.Resources.delete_all;
            this.deleteAllDownloadsMenuItem.Text = "      Delete all...";
            this.deleteAllDownloadsMenuItem.Click += new System.EventHandler(this.deleteAllDownloadsMenuItem_Click);
            // 
            // deleteAllWithOutputFilesMenuItem
            // 
            this.deleteAllWithOutputFilesMenuItem.Text = "      Delete all with Output files...";
            this.deleteAllWithOutputFilesMenuItem.Click += new System.EventHandler(this.deleteAllWithOutputFilesMenuItem_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 579);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.statusBarUC);
            this.Controls.Add(this.mainToolStrip);
            this.Icon = global::m3u8.download.manager.Properties.Resources.m3u8_32x36;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainContextMenu.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton addNewDownloadToolButton;
        private System.Windows.Forms.ToolStripButton startDownloadToolButton;
        private System.Windows.Forms.ToolStripButton pauseDownloadToolButton;
        private System.Windows.Forms.ToolStripButton cancelDownloadToolButton;
        private System.Windows.Forms.ToolStripButton deleteDownloadToolButton;
        private System.Windows.Forms.ToolStripButton deleteAllFinishedDownloadToolButton;
        private System.Windows.Forms.ToolStripButton showLogToolButton;
        private System.Windows.Forms.ToolStripButton copyToolButton;
        private System.Windows.Forms.ToolStripButton pasteToolButton;
        private System.Windows.Forms.ToolStripButton aboutToolButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private DownloadListUC downloadListUC;
        private LogUC logUC;
        private StatusBarUC statusBarUC;

        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem startDownloadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseDownloadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelDownloadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDownloadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWithOutputFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllFinishedDownloadMenuItem;
        //---private System.Windows.Forms.ToolStripMenuItem allDownloadsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAllDownloadsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseAllDownloadsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAllDownloadsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllDownloadsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllWithOutputFilesMenuItem;
    }
}