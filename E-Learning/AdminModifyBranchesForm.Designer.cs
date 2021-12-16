
namespace E_Learning
{
	partial class AdminModifyBranchesForm
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
			this.branchesGDV = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.lblBranchName = new System.Windows.Forms.Label();
			this.lblDeptID = new System.Windows.Forms.Label();
			this.txtBranchName = new System.Windows.Forms.TextBox();
			this.deptIdComboBox = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.branchesGDV)).BeginInit();
			this.SuspendLayout();
			// 
			// branchesGDV
			// 
			this.branchesGDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.branchesGDV.Location = new System.Drawing.Point(53, 69);
			this.branchesGDV.Name = "branchesGDV";
			this.branchesGDV.RowTemplate.Height = 25;
			this.branchesGDV.Size = new System.Drawing.Size(374, 166);
			this.branchesGDV.TabIndex = 0;
			this.branchesGDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branchesGDV_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Braches Details";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.Location = new System.Drawing.Point(53, 253);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(85, 37);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnUpdate.Location = new System.Drawing.Point(196, 253);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(77, 37);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnNew.Location = new System.Drawing.Point(327, 253);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(100, 37);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New Branch";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// lblBranchName
			// 
			this.lblBranchName.AutoSize = true;
			this.lblBranchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblBranchName.Location = new System.Drawing.Point(64, 316);
			this.lblBranchName.Name = "lblBranchName";
			this.lblBranchName.Size = new System.Drawing.Size(113, 21);
			this.lblBranchName.TabIndex = 5;
			this.lblBranchName.Text = "Branch Name";
			// 
			// lblDeptID
			// 
			this.lblDeptID.AutoSize = true;
			this.lblDeptID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblDeptID.Location = new System.Drawing.Point(64, 363);
			this.lblDeptID.Name = "lblDeptID";
			this.lblDeptID.Size = new System.Drawing.Size(123, 21);
			this.lblDeptID.TabIndex = 6;
			this.lblDeptID.Text = "Department ID";
			// 
			// txtBranchName
			// 
			this.txtBranchName.Location = new System.Drawing.Point(196, 314);
			this.txtBranchName.Name = "txtBranchName";
			this.txtBranchName.Size = new System.Drawing.Size(215, 23);
			this.txtBranchName.TabIndex = 7;
			// 
			// deptIdComboBox
			// 
			this.deptIdComboBox.FormattingEnabled = true;
			this.deptIdComboBox.Location = new System.Drawing.Point(196, 365);
			this.deptIdComboBox.Name = "deptIdComboBox";
			this.deptIdComboBox.Size = new System.Drawing.Size(215, 23);
			this.deptIdComboBox.TabIndex = 8;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.Location = new System.Drawing.Point(426, 360);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(97, 31);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(64, 422);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 21);
			this.label4.TabIndex = 14;
			this.label4.Text = "label4";
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(48, 470);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(101, 33);
			this.btnBack.TabIndex = 15;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(173, 470);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(101, 33);
			this.btnExit.TabIndex = 16;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// AdminModifyBranchesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 530);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.deptIdComboBox);
			this.Controls.Add(this.txtBranchName);
			this.Controls.Add(this.lblDeptID);
			this.Controls.Add(this.lblBranchName);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.branchesGDV);
			this.Name = "AdminModifyBranchesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminModifyBranchesForm";
			this.Load += new System.EventHandler(this.AdminModifyBranchesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.branchesGDV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView branchesGDV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Label lblBranchName;
		private System.Windows.Forms.Label lblDeptID;
		private System.Windows.Forms.TextBox txtBranchName;
		private System.Windows.Forms.ComboBox deptIdComboBox;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
	}
}