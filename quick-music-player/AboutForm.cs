﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace quick_music_player
{
	partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			versionLabel.Text = String.Format("Version: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0, 5));

			if (ThemeManager.isDarkTheme())
			{
				this.BackColor = ThemeManager.BackColorDark;
				this.ForeColor = Color.White;

				infoGroup.ForeColor = Color.White;
				pagesGroup.ForeColor = Color.White;

				okButton.BackColor = ThemeManager.SecondColorDark;

				ThemeManager.enableDarkTitlebar(this.Handle, true);
			}
		}

		private void developerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://moduleart.github.io/");
		}

		private void projectLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-music-player/");
		}

		private void issuesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-music-player/issues/");
		}

		private void updatesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MainForm parent = (MainForm)this.Owner;

			parent.checkForUpdates(true);
		}

		private void makeDefaultLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("ms-settings:defaultapps");
		}

		private void AboutForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ModuleArt/quick-music-player/blob/master/LICENSE.md/");
		}
	}
}
