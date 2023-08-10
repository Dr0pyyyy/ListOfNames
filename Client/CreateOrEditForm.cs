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
	public partial class CreateOrEditForm : Form
	{
		private string _firstName;
		private string _lastName;

		public string FirstName
		{
			get { return _firstName; }
		}

		public string LastName
		{
			get { return _lastName; }
		}

		public CreateOrEditForm()
		{
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			_firstName = txt_box_firstname.Text;
			_lastName = txt_box_lastname.Text;

			if (_firstName != "" || _lastName != "")
				this.DialogResult = DialogResult.OK;
			else
				MessageBox.Show("New record must contain values!");
			this.Close();
		}
	}
}
