namespace Frackabot
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.mainTabPage_TwitchDebug = new System.Windows.Forms.TabPage();
			this.mainTabPage_TwitchConsole = new System.Windows.Forms.TabPage();
			this.mainTabPage_DiscordConsole = new System.Windows.Forms.TabPage();
			this.mainTabPage_DiscordDebug = new System.Windows.Forms.TabPage();
			this.mainTabPage_MainDebug = new System.Windows.Forms.TabPage();
			this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.mainStatusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.mainTabControl);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1136, 635);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(1136, 681);
			this.toolStripContainer.TabIndex = 0;
			this.toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.mainMenuStrip);
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 0);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(1136, 22);
			this.mainStatusStrip.TabIndex = 0;
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(1136, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.mainTabPage_MainDebug);
			this.mainTabControl.Controls.Add(this.mainTabPage_TwitchDebug);
			this.mainTabControl.Controls.Add(this.mainTabPage_DiscordDebug);
			this.mainTabControl.Controls.Add(this.mainTabPage_TwitchConsole);
			this.mainTabControl.Controls.Add(this.mainTabPage_DiscordConsole);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(1136, 635);
			this.mainTabControl.TabIndex = 0;
			// 
			// mainTabPage_TwitchDebug
			// 
			this.mainTabPage_TwitchDebug.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage_TwitchDebug.Name = "mainTabPage_TwitchDebug";
			this.mainTabPage_TwitchDebug.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage_TwitchDebug.Size = new System.Drawing.Size(1128, 609);
			this.mainTabPage_TwitchDebug.TabIndex = 0;
			this.mainTabPage_TwitchDebug.Text = "Twitch DEBUG";
			this.mainTabPage_TwitchDebug.UseVisualStyleBackColor = true;
			// 
			// mainTabPage_TwitchConsole
			// 
			this.mainTabPage_TwitchConsole.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage_TwitchConsole.Name = "mainTabPage_TwitchConsole";
			this.mainTabPage_TwitchConsole.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage_TwitchConsole.Size = new System.Drawing.Size(1128, 609);
			this.mainTabPage_TwitchConsole.TabIndex = 1;
			this.mainTabPage_TwitchConsole.Text = "Twitch Console";
			this.mainTabPage_TwitchConsole.UseVisualStyleBackColor = true;
			// 
			// mainTabPage_DiscordConsole
			// 
			this.mainTabPage_DiscordConsole.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage_DiscordConsole.Name = "mainTabPage_DiscordConsole";
			this.mainTabPage_DiscordConsole.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage_DiscordConsole.Size = new System.Drawing.Size(1128, 609);
			this.mainTabPage_DiscordConsole.TabIndex = 2;
			this.mainTabPage_DiscordConsole.Text = "Discord Console";
			this.mainTabPage_DiscordConsole.UseVisualStyleBackColor = true;
			// 
			// mainTabPage_DiscordDebug
			// 
			this.mainTabPage_DiscordDebug.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage_DiscordDebug.Name = "mainTabPage_DiscordDebug";
			this.mainTabPage_DiscordDebug.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage_DiscordDebug.Size = new System.Drawing.Size(1128, 609);
			this.mainTabPage_DiscordDebug.TabIndex = 3;
			this.mainTabPage_DiscordDebug.Text = "Discord DEBUG";
			this.mainTabPage_DiscordDebug.UseVisualStyleBackColor = true;
			// 
			// mainTabPage_MainDebug
			// 
			this.mainTabPage_MainDebug.Location = new System.Drawing.Point(4, 22);
			this.mainTabPage_MainDebug.Name = "mainTabPage_MainDebug";
			this.mainTabPage_MainDebug.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage_MainDebug.Size = new System.Drawing.Size(1128, 609);
			this.mainTabPage_MainDebug.TabIndex = 4;
			this.mainTabPage_MainDebug.Text = "DEBUG";
			this.mainTabPage_MainDebug.UseVisualStyleBackColor = true;
			// 
			// mainToolStripMenuItem
			// 
			this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
			this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.mainToolStripMenuItem.Text = "&Main";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 681);
			this.Controls.Add(this.toolStripContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1152, 720);
			this.Name = "MainForm";
			this.Text = "Frackabot";
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage mainTabPage_TwitchDebug;
		private System.Windows.Forms.TabPage mainTabPage_TwitchConsole;
		private System.Windows.Forms.TabPage mainTabPage_DiscordConsole;
		private System.Windows.Forms.TabPage mainTabPage_DiscordDebug;
		private System.Windows.Forms.TabPage mainTabPage_MainDebug;
		private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
	}
}

