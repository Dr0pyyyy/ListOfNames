namespace ListOfNames
{
	partial class Server
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
			this.lbl_ip = new System.Windows.Forms.Label();
			this.btn_start = new System.Windows.Forms.Button();
			this.txt_box_ip = new System.Windows.Forms.TextBox();
			this.txt_box_port = new System.Windows.Forms.TextBox();
			this.lbl_port = new System.Windows.Forms.Label();
			this.btn_stop = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txt_box_server_console = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_ip
			// 
			this.lbl_ip.AutoSize = true;
			this.lbl_ip.Location = new System.Drawing.Point(34, 30);
			this.lbl_ip.Name = "lbl_ip";
			this.lbl_ip.Size = new System.Drawing.Size(20, 13);
			this.lbl_ip.TabIndex = 0;
			this.lbl_ip.Text = "IP:";
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(410, 64);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(75, 23);
			this.btn_start.TabIndex = 1;
			this.btn_start.Text = "Start";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// txt_box_ip
			// 
			this.txt_box_ip.Location = new System.Drawing.Point(60, 27);
			this.txt_box_ip.Name = "txt_box_ip";
			this.txt_box_ip.Size = new System.Drawing.Size(100, 20);
			this.txt_box_ip.TabIndex = 2;
			this.txt_box_ip.Text = "127.0.0.1";
			// 
			// txt_box_port
			// 
			this.txt_box_port.Location = new System.Drawing.Point(218, 27);
			this.txt_box_port.Name = "txt_box_port";
			this.txt_box_port.Size = new System.Drawing.Size(100, 20);
			this.txt_box_port.TabIndex = 4;
			this.txt_box_port.Text = "8910";
			// 
			// lbl_port
			// 
			this.lbl_port.AutoSize = true;
			this.lbl_port.Location = new System.Drawing.Point(183, 30);
			this.lbl_port.Name = "lbl_port";
			this.lbl_port.Size = new System.Drawing.Size(29, 13);
			this.lbl_port.TabIndex = 3;
			this.lbl_port.Text = "Port:";
			// 
			// btn_stop
			// 
			this.btn_stop.Location = new System.Drawing.Point(410, 106);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(75, 23);
			this.btn_stop.TabIndex = 5;
			this.btn_stop.Text = "Stop";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(37, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(341, 255);
			this.dataGridView1.TabIndex = 6;
			// 
			// txt_box_server_console
			// 
			this.txt_box_server_console.Location = new System.Drawing.Point(37, 331);
			this.txt_box_server_console.Multiline = true;
			this.txt_box_server_console.Name = "txt_box_server_console";
			this.txt_box_server_console.ReadOnly = true;
			this.txt_box_server_console.Size = new System.Drawing.Size(341, 159);
			this.txt_box_server_console.TabIndex = 7;
			// 
			// Server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 517);
			this.Controls.Add(this.txt_box_server_console);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_stop);
			this.Controls.Add(this.txt_box_port);
			this.Controls.Add(this.lbl_port);
			this.Controls.Add(this.txt_box_ip);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.lbl_ip);
			this.Name = "Server";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Server";
			this.Load += new System.EventHandler(this.Server_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_ip;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.TextBox txt_box_ip;
		private System.Windows.Forms.TextBox txt_box_port;
		private System.Windows.Forms.Label lbl_port;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txt_box_server_console;
	}
}

