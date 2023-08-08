namespace Client
{
	partial class Client
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
			this.txt_box_port = new System.Windows.Forms.TextBox();
			this.lbl_port = new System.Windows.Forms.Label();
			this.txt_box_ip = new System.Windows.Forms.TextBox();
			this.btn_connect = new System.Windows.Forms.Button();
			this.lbl_ip = new System.Windows.Forms.Label();
			this.btn_create = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_box_port
			// 
			this.txt_box_port.Location = new System.Drawing.Point(213, 32);
			this.txt_box_port.Name = "txt_box_port";
			this.txt_box_port.Size = new System.Drawing.Size(100, 20);
			this.txt_box_port.TabIndex = 10;
			this.txt_box_port.Text = "8910";
			// 
			// lbl_port
			// 
			this.lbl_port.AutoSize = true;
			this.lbl_port.Location = new System.Drawing.Point(178, 35);
			this.lbl_port.Name = "lbl_port";
			this.lbl_port.Size = new System.Drawing.Size(29, 13);
			this.lbl_port.TabIndex = 9;
			this.lbl_port.Text = "Port:";
			// 
			// txt_box_ip
			// 
			this.txt_box_ip.Location = new System.Drawing.Point(56, 32);
			this.txt_box_ip.Name = "txt_box_ip";
			this.txt_box_ip.Size = new System.Drawing.Size(100, 20);
			this.txt_box_ip.TabIndex = 8;
			this.txt_box_ip.Text = "127.0.0.1";
			// 
			// btn_connect
			// 
			this.btn_connect.Location = new System.Drawing.Point(341, 29);
			this.btn_connect.Name = "btn_connect";
			this.btn_connect.Size = new System.Drawing.Size(75, 23);
			this.btn_connect.TabIndex = 7;
			this.btn_connect.Text = "Connect";
			this.btn_connect.UseVisualStyleBackColor = true;
			this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
			// 
			// lbl_ip
			// 
			this.lbl_ip.AutoSize = true;
			this.lbl_ip.Location = new System.Drawing.Point(30, 35);
			this.lbl_ip.Name = "lbl_ip";
			this.lbl_ip.Size = new System.Drawing.Size(20, 13);
			this.lbl_ip.TabIndex = 6;
			this.lbl_ip.Text = "IP:";
			// 
			// btn_create
			// 
			this.btn_create.Location = new System.Drawing.Point(33, 74);
			this.btn_create.Name = "btn_create";
			this.btn_create.Size = new System.Drawing.Size(75, 23);
			this.btn_create.TabIndex = 11;
			this.btn_create.Text = "Create new";
			this.btn_create.UseVisualStyleBackColor = true;
			this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(181, 74);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(75, 23);
			this.btn_edit.TabIndex = 12;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = true;
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(341, 74);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 13;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 130);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_create);
			this.Controls.Add(this.txt_box_port);
			this.Controls.Add(this.lbl_port);
			this.Controls.Add(this.txt_box_ip);
			this.Controls.Add(this.btn_connect);
			this.Controls.Add(this.lbl_ip);
			this.Name = "Client";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Client_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txt_box_port;
		private System.Windows.Forms.Label lbl_port;
		private System.Windows.Forms.TextBox txt_box_ip;
		private System.Windows.Forms.Button btn_connect;
		private System.Windows.Forms.Label lbl_ip;
		private System.Windows.Forms.Button btn_create;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_delete;
	}
}

