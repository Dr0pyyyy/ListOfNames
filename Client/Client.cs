using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
	public partial class Client : Form
	{
		private SimpleTcpClient _client;
		private bool didServerShutDown = false;

		public Client()
		{
			InitializeComponent();
		}

		private void Client_Load(object sender, EventArgs e)
		{
			if (btn_connect.Enabled)
			{
				btn_create.Enabled = false;
				btn_edit.Enabled = false;
				btn_delete.Enabled = false;

				txt_box_ip.Enabled = true;
				txt_box_port.Enabled = true;
			}

			_client = new SimpleTcpClient();
		}

		private void btn_connect_Click(object sender, EventArgs e)
		{
			btn_connect.Enabled = false;

			txt_box_ip.Enabled = false;
			txt_box_port.Enabled = false;

			try
			{
				_client.Connect(txt_box_ip.Text, Convert.ToInt32(txt_box_port.Text));
				UpdateConsoleText("Client connected!");
			}
			catch (Exception ex)
			{
				UpdateConsoleText($"WARNING: {ex.Message}");
				btn_connect.Enabled = true;
				txt_box_ip.Enabled = true;
				txt_box_port.Enabled = true;

				btn_create.Enabled = false;
				btn_edit.Enabled = false;
				btn_delete.Enabled = false;
				return;
			}

			//If connection is established, enable buttons
			btn_create.Enabled = true;
			btn_edit.Enabled = true;
			btn_delete.Enabled = true;
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			using (CreateOrEditForm personForm = new CreateOrEditForm())
			{
				DialogResult result = personForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (personForm.FirstName == "" || personForm.LastName == "")
					{
						UpdateConsoleText("WARNING: New record must contain values!");
						return;
					}

					if (IsServerOnline())
					{
						if (didServerShutDown)
						{
							_client.Disconnect();
							_client.Connect(txt_box_ip.Text, Convert.ToInt32(txt_box_port.Text));

							didServerShutDown = false;

							UpdateConsoleText("Reconnected!");
						}
							
						_client.WriteLine($"CREATE,{personForm.FirstName},{personForm.LastName}");
						UpdateConsoleText("Creating new record...");
					}
					else
						UpdateConsoleText("Server is not responding!");

				}
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you wanna delete selected record?", "Delete record", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (IsServerOnline())
				{
					if (didServerShutDown)
					{
						_client.Disconnect();
						_client.Connect(txt_box_ip.Text, Convert.ToInt32(txt_box_port.Text));

						didServerShutDown = false;

						UpdateConsoleText("Reconnected!");
					}

					_client.WriteLine("DELETE");
					UpdateConsoleText("Deleting selected record...");
				}
				else
					UpdateConsoleText("Server is not responding!");
			}
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			using (CreateOrEditForm personForm = new CreateOrEditForm())
			{
				DialogResult result = personForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					if (personForm.FirstName == "" || personForm.LastName == "")
					{
						UpdateConsoleText("WARNING: New record must contain values!");
						return;
					}

					DialogResult dialogResult = MessageBox.Show("Are you sure you wanna edit selected record?", "Edit record", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						if (IsServerOnline())
						{
							if (didServerShutDown)
							{
								_client.Disconnect();
								_client.Connect(txt_box_ip.Text, Convert.ToInt32(txt_box_port.Text));

								didServerShutDown = false;

								UpdateConsoleText("Reconnected!");
							}

							_client.WriteLine($"EDIT,{personForm.FirstName},{personForm.LastName}");
						}
						else
							UpdateConsoleText("Server is not responding!");
					}
				}
			}
		}

		private void UpdateConsoleText(string message)
		{
			if (txt_box_client_console.InvokeRequired)
				txt_box_client_console.Invoke(new Action<string>(UpdateConsoleText), $"{DateTime.Now}: {message}{Environment.NewLine}");
			else
				txt_box_client_console.Text += $"{DateTime.Now}: {message}{Environment.NewLine}";
		}

		private bool IsServerOnline()
		{
			try
			{
				using (SimpleTcpClient client = new SimpleTcpClient())
				{
					client.Connect(txt_box_ip.Text, Convert.ToInt32(txt_box_port.Text));
				}

				return true;
			}
			catch
			{
				didServerShutDown = true;
				return false;
			}
		}
	}
}
