namespace Client
{
	partial class PersonForm
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
			this.btn_create = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_box_firstname = new System.Windows.Forms.TextBox();
			this.txt_box_lastname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_create
			// 
			this.btn_create.Location = new System.Drawing.Point(115, 132);
			this.btn_create.Name = "btn_create";
			this.btn_create.Size = new System.Drawing.Size(75, 23);
			this.btn_create.TabIndex = 2;
			this.btn_create.Text = "Create";
			this.btn_create.UseVisualStyleBackColor = true;
			this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Firstname:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Lastname:";
			// 
			// txt_box_firstname
			// 
			this.txt_box_firstname.Location = new System.Drawing.Point(90, 55);
			this.txt_box_firstname.Name = "txt_box_firstname";
			this.txt_box_firstname.Size = new System.Drawing.Size(100, 20);
			this.txt_box_firstname.TabIndex = 5;
			// 
			// txt_box_lastname
			// 
			this.txt_box_lastname.Location = new System.Drawing.Point(90, 81);
			this.txt_box_lastname.Name = "txt_box_lastname";
			this.txt_box_lastname.Size = new System.Drawing.Size(100, 20);
			this.txt_box_lastname.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(55, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Create new record";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(17, 132);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 8;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// PersonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(216, 183);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_box_lastname);
			this.Controls.Add(this.txt_box_firstname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_create);
			this.Name = "PersonForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PersonForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_create;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_box_firstname;
		private System.Windows.Forms.TextBox txt_box_lastname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_cancel;
	}
}