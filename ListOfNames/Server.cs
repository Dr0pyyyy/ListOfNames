using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListOfNames
{
	public partial class Server : Form
	{
		private SimpleTcpServer _server;
		private List<Record> _records = new List<Record>();
		private string _csvFile = @"..\..\..\userData.csv";
		private int _id;

		public Server()
		{
			InitializeComponent();
		}

		private void Server_Load(object sender, EventArgs e)
		{
			_server = new SimpleTcpServer();
			dataGridView1.AutoGenerateColumns = true;
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			btn_start.Enabled = false;
			btn_stop.Enabled = true;

			IPAddress ip = IPAddress.Parse(txt_box_ip.Text);
			_server.Start(ip, Convert.ToInt32(txt_box_port.Text));

			LoadDataFromCsvIntoRecords(_csvFile);
			dataGridView1.DataSource = _records;

			//Get last id
			_id = _records.Last().Id;

			_server.DataReceived += HandleDataReceived;
		}

		private void btn_stop_Click(object sender, EventArgs e)
		{
			btn_start.Enabled = true;
			btn_stop.Enabled = false;

			_server.Stop();

			dataGridView1.DataSource = null;
			_records.Clear();
		}

		private void HandleDataReceived(object sender, SimpleTCP.Message e)
		{
			string[] dataParts = e.MessageString.Split(',');

			if (dataParts.Length == 3 && dataParts[0] == "CREATE")
			{
				string firstName = dataParts[1];
				string lastName = dataParts[2];

				SaveToCsvFile(firstName, lastName);
			}
		}

		private void SaveToCsvFile(string firstName, string lastName)
		{
			using (StreamWriter writer = new StreamWriter(_csvFile, true))
			{
				_id++;
				writer.WriteLine($"{_id},{firstName},{lastName}");
			}
		}

		private void LoadDataFromCsvIntoRecords(string filePath)
		{
			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] fields = line.Split(',');

					if (fields.Length == 3)
					{
						int id = int.Parse(fields[0]);
						string firstname = fields[1];
						string lastname = fields[2];

						_records.Add(new Record(id, firstname, lastname));
					}
				}
			}
		}
	}
}
