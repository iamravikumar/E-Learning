using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using E_Learning.DAL;
using E_Learning.Business;

namespace E_Learning
{
	public partial class AdminModifyBranchesForm : Form
	{
		//Declare variables related to branches in a class level
		public Branch branch;
		public BranchRepository branchRepo;
		
		public AdminModifyBranchesForm()
		{
			InitializeComponent();
		}

		private void AdminModifyBranchesForm_Load(object sender, EventArgs e)
		{
			RefreshTable();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			//Department Combo Box 
			deptIdComboBox.Items.Clear();
			DepartmentRepository deptRepo = new DepartmentRepository();
			//List contains all ids to be used when updating the branch
			List<Department> departments = deptRepo.GetAllDepartments();
			foreach (Department department in departments)
			{
				deptIdComboBox.Items.Add(department.id + ", "+ department.name);
			}

			//Show Add Section
			this.lblBranchName.Visible = true;
			this.lblDeptID.Visible = true;
			this.txtBranchName.Visible = true;
			this.deptIdComboBox.Visible = true;
			this.btnAdd.Visible = true;
		}

		private void branchesGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = branchesGDV.CurrentRow.Index;
			ShowBranchDetails(index);
		}

		private void ShowBranchDetails(int rowIndex)
		{
			//Make the selected cell is the first one Branch ID
			branchesGDV.CurrentCell = branchesGDV.Rows[rowIndex].Cells[1];
			//Get the value of the branch id cell
			string id = branchesGDV.Rows[rowIndex].Cells[0].Value.ToString();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//take the id of the selected branch
			int index = branchesGDV.CurrentRow.Index;
			int id = Convert.ToInt32(branchesGDV.Rows[index].Cells[0].Value.ToString());

			//Uncomment to enable the deletion functionality
			BranchRepository branchRepo = new BranchRepository();
			branchRepo.Delete(id);
			RefreshTable();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//Take the branch name and dept id
			int index = branchesGDV.CurrentRow.Index;

			//brach id
			int branchId = Convert.ToInt32(branchesGDV.Rows[index].Cells[0].Value.ToString());
			//branch name
			string name = branchesGDV.Rows[index].Cells[1].Value.ToString();
			//Department ID
			int deptId = Convert.ToInt32(branchesGDV.Rows[index].Cells[2].Value.ToString());

			branchRepo = new BranchRepository();
			branch = branchRepo.GetBranchById(branchId);
			//set the values of this branch 
			branch.name = name;
			branch.department_id = deptId;
			branchRepo.Update(branch);
			RefreshTable();
		}

		private void RefreshTable()
		{
			//Generate a list of all branches 
			branchRepo = new BranchRepository();
			List<Branch> branches = branchRepo.GetAllBranches();
			this.branchesGDV.DataSource = null;//clear the data table before adding new data to avoid duplicating
			this.branchesGDV.DataSource = branches;
			//Hide un-necessary columns
			this.branchesGDV.Columns[0].Visible = false;
			this.branchesGDV.Columns[3].Visible = false;
			this.branchesGDV.Columns[4].Visible = false;

			if (branchesGDV.Rows.Count > 0)
			{
				//select the first row by default 
				branchesGDV.Rows[0].Selected = true;
				ShowBranchDetails(0);
			}

			//Hide Add Section
			this.lblBranchName.Visible = false;
			this.lblDeptID.Visible = false;
			this.txtBranchName.Visible = false;
			this.deptIdComboBox.Visible = false;
			this.btnAdd.Visible = false;
			this.label4.Visible = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//Get the user entry from the feilds
			string name = this.txtBranchName.Text;
			int id = this.deptIdComboBox.SelectedIndex;
			id++;
			int deptId = id;
			//CREATE branch obje and set the value of it
			branchRepo = new BranchRepository();
			branch = new Branch();
			branch.name = name;
			branch.department_id = deptId;
			branchRepo.Add(branch);
			RefreshTable();
			this.label4.Visible = true;
			this.label4.Text = "Branch Was Added Successfully";
		}
	}
}
