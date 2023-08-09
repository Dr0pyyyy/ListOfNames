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

			btn_create.Enabled = true;
			btn_edit.Enabled = true;
			btn_delete.Enabled = true;

			txt_box_ip.Enabled = false;
			txt_box_port.Enabled = false;

			try
			{
				_client.Connect(txt_box_ip.Text, Convert.ToInt32(txt_box_port.Text));
				UpdateConsoleText("Client connected!");
			}
			catch(Exception ex) 
			{
				UpdateConsoleText($"WARNING: {ex.Message}");
				btn_connect.Enabled = true;
				txt_box_ip.Enabled= true;
				txt_box_port.Enabled= true;
				return;
			}
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

					_client.WriteLine($"CREATE,{personForm.FirstName},{personForm.LastName}");
					UpdateConsoleText("Creating new record...");
				}
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you wanna delete selected record?", "Delete record", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				_client.WriteLine("DELETE");
				UpdateConsoleText("Deleting selected record...");
			}
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			using (CreateOrEditForm personForm = new CreateOrEditForm())
			{
				DialogResult result = personForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					DialogResult dialogResult = MessageBox.Show("Are you sure you wanna edit selected record?", "Edit record", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
						_client.WriteLine($"EDIT,{personForm.FirstName},{personForm.LastName}");
				}
			}
		}

		private void UpdateConsoleText(string message)
		{
			if (txt_box_client_console.InvokeRequired)
				txt_box_client_console.Invoke(new Action<string>(UpdateConsoleText), $"{message}{Environment.NewLine}");
			else
				txt_box_client_console.Text += $"{message}{Environment.NewLine}";
		}
	}
}
