namespace Client
{
	partial class CreateOrEditForm
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
			this.btn_save = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_box_firstname = new System.Windows.Forms.TextBox();
			this.txt_box_lastname = new System.Windows.Forms.TextBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(115, 132);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(75, 23);
			this.btn_save.TabIndex = 2;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Create or edit record";
			// 
			// RecordForm
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
			this.Controls.Add(this.btn_save);
			this.Name = "RecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PersonForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_box_firstname;
		private System.Windows.Forms.TextBox txt_box_lastname;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label label4;
	}
}