
namespace E_Learning
{
	partial class AdminModifyStaffInfoForm
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnNewStaff = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblFName = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPwd = new System.Windows.Forms.Label();
			this.lblQualification = new System.Windows.Forms.Label();
			this.lblBrief = new System.Windows.Forms.Label();
			this.lblDepId = new System.Windows.Forms.Label();
			this.lblRollId = new System.Windows.Forms.Label();
			this.textBoxFName = new System.Windows.Forms.TextBox();
			this.textBoxLName = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxPwd = new System.Windows.Forms.TextBox();
			this.textBoxQualification = new System.Windows.Forms.TextBox();
			this.textBoxBrief = new System.Windows.Forms.TextBox();
			this.comboBoxDepId = new System.Windows.Forms.ComboBox();
			this.comboBoxRollId = new System.Windows.Forms.ComboBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.staffGDV = new System.Windows.Forms.DataGridView();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.staffGDV)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.Location = new System.Drawing.Point(84, 282);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 33);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUpdate.Location = new System.Drawing.Point(215, 282);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 33);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnNewStaff
			// 
			this.btnNewStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnNewStaff.Location = new System.Drawing.Point(331, 280);
			this.btnNewStaff.Name = "btnNewStaff";
			this.btnNewStaff.Size = new System.Drawing.Size(75, 35);
			this.btnNewStaff.TabIndex = 2;
			this.btnNewStaff.Text = "New Staff";
			this.btnNewStaff.UseVisualStyleBackColor = true;
			this.btnNewStaff.Click += new System.EventHandler(this.btnNewStaff_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.Location = new System.Drawing.Point(462, 525);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(95, 30);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblFName
			// 
			this.lblFName.AutoSize = true;
			this.lblFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblFName.Location = new System.Drawing.Point(84, 339);
			this.lblFName.Name = "lblFName";
			this.lblFName.Size = new System.Drawing.Size(92, 21);
			this.lblFName.TabIndex = 4;
			this.lblFName.Text = "First Name";
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblLName.Location = new System.Drawing.Point(462, 337);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(90, 21);
			this.lblLName.TabIndex = 5;
			this.lblLName.Text = "Last Name";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblEmail.Location = new System.Drawing.Point(84, 386);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(53, 21);
			this.lblEmail.TabIndex = 6;
			this.lblEmail.Text = "Email";
			// 
			// lblPwd
			// 
			this.lblPwd.AutoSize = true;
			this.lblPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblPwd.Location = new System.Drawing.Point(462, 386);
			this.lblPwd.Name = "lblPwd";
			this.lblPwd.Size = new System.Drawing.Size(82, 21);
			this.lblPwd.TabIndex = 7;
			this.lblPwd.Text = "Password";
			// 
			// lblQualification
			// 
			this.lblQualification.AutoSize = true;
			this.lblQualification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblQualification.Location = new System.Drawing.Point(84, 443);
			this.lblQualification.Name = "lblQualification";
			this.lblQualification.Size = new System.Drawing.Size(110, 21);
			this.lblQualification.TabIndex = 8;
			this.lblQualification.Text = "Qualification";
			// 
			// lblBrief
			// 
			this.lblBrief.AutoSize = true;
			this.lblBrief.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBrief.Location = new System.Drawing.Point(462, 443);
			this.lblBrief.Name = "lblBrief";
			this.lblBrief.Size = new System.Drawing.Size(46, 21);
			this.lblBrief.TabIndex = 9;
			this.lblBrief.Text = "Brief";
			// 
			// lblDepId
			// 
			this.lblDepId.AutoSize = true;
			this.lblDepId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblDepId.Location = new System.Drawing.Point(84, 491);
			this.lblDepId.Name = "lblDepId";
			this.lblDepId.Size = new System.Drawing.Size(123, 21);
			this.lblDepId.TabIndex = 10;
			this.lblDepId.Text = "Department ID";
			// 
			// lblRollId
			// 
			this.lblRollId.AutoSize = true;
			this.lblRollId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblRollId.Location = new System.Drawing.Point(84, 534);
			this.lblRollId.Name = "lblRollId";
			this.lblRollId.Size = new System.Drawing.Size(61, 21);
			this.lblRollId.TabIndex = 11;
			this.lblRollId.Text = "Roll ID";
			// 
			// textBoxFName
			// 
			this.textBoxFName.Location = new System.Drawing.Point(241, 341);
			this.textBoxFName.Name = "textBoxFName";
			this.textBoxFName.Size = new System.Drawing.Size(195, 23);
			this.textBoxFName.TabIndex = 12;
			// 
			// textBoxLName
			// 
			this.textBoxLName.Location = new System.Drawing.Point(619, 341);
			this.textBoxLName.Name = "textBoxLName";
			this.textBoxLName.Size = new System.Drawing.Size(195, 23);
			this.textBoxLName.TabIndex = 13;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(241, 388);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(195, 23);
			this.textBoxEmail.TabIndex = 14;
			// 
			// textBoxPwd
			// 
			this.textBoxPwd.Location = new System.Drawing.Point(619, 388);
			this.textBoxPwd.Name = "textBoxPwd";
			this.textBoxPwd.Size = new System.Drawing.Size(195, 23);
			this.textBoxPwd.TabIndex = 15;
			// 
			// textBoxQualification
			// 
			this.textBoxQualification.Location = new System.Drawing.Point(241, 441);
			this.textBoxQualification.Name = "textBoxQualification";
			this.textBoxQualification.Size = new System.Drawing.Size(195, 23);
			this.textBoxQualification.TabIndex = 16;
			// 
			// textBoxBrief
			// 
			this.textBoxBrief.Location = new System.Drawing.Point(619, 441);
			this.textBoxBrief.Name = "textBoxBrief";
			this.textBoxBrief.Size = new System.Drawing.Size(195, 23);
			this.textBoxBrief.TabIndex = 17;
			// 
			// comboBoxDepId
			// 
			this.comboBoxDepId.FormattingEnabled = true;
			this.comboBoxDepId.Location = new System.Drawing.Point(241, 489);
			this.comboBoxDepId.Name = "comboBoxDepId";
			this.comboBoxDepId.Size = new System.Drawing.Size(195, 23);
			this.comboBoxDepId.TabIndex = 18;
			// 
			// comboBoxRollId
			// 
			this.comboBoxRollId.FormattingEnabled = true;
			this.comboBoxRollId.Location = new System.Drawing.Point(241, 536);
			this.comboBoxRollId.Name = "comboBoxRollId";
			this.comboBoxRollId.Size = new System.Drawing.Size(195, 23);
			this.comboBoxRollId.TabIndex = 19;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblMessage.Location = new System.Drawing.Point(23, 20);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(57, 21);
			this.lblMessage.TabIndex = 20;
			this.lblMessage.Text = "label9";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(12, 55);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(173, 37);
			this.label10.TabIndex = 21;
			this.label10.Text = "Staff Details";
			// 
			// staffGDV
			// 
			this.staffGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.staffGDV.Location = new System.Drawing.Point(34, 109);
			this.staffGDV.Name = "staffGDV";
			this.staffGDV.RowTemplate.Height = 25;
			this.staffGDV.Size = new System.Drawing.Size(839, 150);
			this.staffGDV.TabIndex = 22;
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(44, 585);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(94, 35);
			this.btnBack.TabIndex = 23;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(167, 585);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(94, 35);
			this.btnExit.TabIndex = 24;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// AdminModifyStaffInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 641);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.staffGDV);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.comboBoxRollId);
			this.Controls.Add(this.comboBoxDepId);
			this.Controls.Add(this.textBoxBrief);
			this.Controls.Add(this.textBoxQualification);
			this.Controls.Add(this.textBoxPwd);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxLName);
			this.Controls.Add(this.textBoxFName);
			this.Controls.Add(this.lblRollId);
			this.Controls.Add(this.lblDepId);
			this.Controls.Add(this.lblBrief);
			this.Controls.Add(this.lblQualification);
			this.Controls.Add(this.lblPwd);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblLName);
			this.Controls.Add(this.lblFName);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnNewStaff);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Name = "AdminModifyStaffInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminModifyStaffInfoForm";
			this.Load += new System.EventHandler(this.AdminModifyStaffInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.staffGDV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnNewStaff;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.Label lblQualification;
		private System.Windows.Forms.Label lblBrief;
		private System.Windows.Forms.Label lblDepId;
		private System.Windows.Forms.Label lblRollId;
		private System.Windows.Forms.TextBox textBoxFName;
		private System.Windows.Forms.TextBox textBoxLName;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxPwd;
		private System.Windows.Forms.TextBox textBoxQualification;
		private System.Windows.Forms.TextBox textBoxBrief;
		private System.Windows.Forms.ComboBox comboBoxDepId;
		private System.Windows.Forms.ComboBox comboBoxRollId;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView staffGDV;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
	}
}