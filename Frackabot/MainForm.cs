using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frackabot
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Fires when the form is first loaded.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Fires when the form is first shown.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Shown(object sender, EventArgs e)
		{

		}
		
		/// <summary>
		/// Fires when the form is activated and gains focus.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Activated(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Fires when the form is initiating a close or shutdown.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = false;
			switch (e.CloseReason)
			{
				// Check settings and see if we need to display a message or just save data.
				case CloseReason.FormOwnerClosing:
				case CloseReason.MdiFormClosing:
				case CloseReason.UserClosing:
				case CloseReason.None:
					// ask if we should quit the application, if settings allow us.
					var messageBoxResult = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false);
					switch (messageBoxResult)
					{
						case DialogResult.No:
							e.Cancel = true;
							return;
					}
					break;
			}
		}

		/// <summary>
		/// Fires when the form is closing.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		/// <summary>
		/// Fires when the form begins to resize.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_ResizeBegin(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Fires when the form ends a resize.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_ResizeEnd(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Fires when the form is being resized.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Resize(object sender, EventArgs e)
		{

		}



































	}
}
