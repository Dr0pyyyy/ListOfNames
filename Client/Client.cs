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

			_client.Connect(txt_box_ip.Text, 8910);//Todo: Hodnota na tvrdo, změnit!!
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			using (RecordForm personForm = new RecordForm())
			{
				DialogResult result = personForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					string firstName = personForm.FirstName;
					string lastName = personForm.LastName;

					_client.WriteLine($"CREATE,{firstName},{lastName}");
				}
			}
		}
	}
}
