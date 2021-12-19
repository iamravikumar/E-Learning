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
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			//Get values from the form
			string fName = this.txtBoxFName.Text;
			string lName = this.txtBoxLName.Text;
			string email = this.txtBoxEmail.Text;
			string password = this.txtBoxPassword.Text;

			//store user input into proper objects and create new user
			int index = this.comboBoxRollList.SelectedIndex;

			try
			{
				if (index == 1)//create teacher object
				{
					string qualification = this.txtBoxQualification.Text;
					string brief = this.txtBoxBrief.Text;
					int deptID = this.comboBoxDeptList.SelectedIndex;
					//create a teacher object
					Teacher teacher = new Teacher();
					TeacherRepository teacherRepo = new TeacherRepository();

					teacher.first_name = fName;
					teacher.last_name = lName;
					teacher.email = email;
					teacher.password = password;
					teacher.qualification = qualification;
					teacher.brief = brief;
					teacher.roll_id = 2;
					teacher.department_id = Convert.ToInt32(deptID++);
					//Add the teacher to the databases
					teacherRepo.Add(teacher);
					this.lblSuccessMessage.Text = "Teacher Was Added Successfully.\n User The Email & Password To Login";

					TeacherDashboardForm frm = new TeacherDashboardForm();
					frm.Show();
					this.Hide();
				}
				else if (index == 2)//create student object
				{
					int branchID = this.comboBoxBranchList.SelectedIndex;
					//create student object
					StudentRepository studetRepo = new StudentRepository();
					Student student = new Student();
					
					student.first_name = fName;
					student.last_name = lName;
					student.email = email;
					student.password = password;
					student.branch_id = Convert.ToInt32(branchID++);
					student.roll_id = 3;
					student.num_of_courses_completed = 0;
					//add the student to the database
					studetRepo.Add(student);
					this.lblSuccessMessage.Text = "Student Was Added Successfully.\n User The Email & Password To Login";

					StudentDashboardForm frm = new StudentDashboardForm();
					frm.Show();
					this.Hide();
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void comboBoxRollList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = this.comboBoxRollList.SelectedIndex;
			if (index == 1)//if the roll was teacher
			{
				//Hide student details fields
				this.lblBranch.Visible = false;
				this.comboBoxBranchList.Visible = false;

				//show teacher details fields
				this.lblBrief.Visible = true;
				this.lblDepartment.Visible = true;
				this.lblQualification.Visible = true;
				this.comboBoxDeptList.Visible = true;
				this.txtBoxBrief.Visible = true;
				this.txtBoxQualification.Visible = true;
			}
			else if (index == 2)//if the roll was student
			{
				//Show student details field
				this.lblBranch.Visible = true;
				this.comboBoxBranchList.Visible = true;


				//Hide teacher details fields
				this.lblBrief.Visible = false;
				this.lblDepartment.Visible = false;
				this.lblQualification.Visible = false;
				this.comboBoxDeptList.Visible = false;
				this.txtBoxBrief.Visible = false;
				this.txtBoxQualification.Visible = false;
			}
		}

		private void RegistrationForm_Load(object sender, EventArgs e)
		{
			//Set the message lable as null
			this.lblSuccessMessage.Text = "";

			RollRepository rollRepo = new RollRepository();
			List<Roll> rolls = rollRepo.GetAllRolls();
			this.comboBoxRollList.Items.Clear();

			foreach (Roll roll in rolls)
			{
				//if (roll.name.Equals("Admin")) continue;
				this.comboBoxRollList.Items.Add(roll.name);
			}

			DepartmentRepository deptRepo = new DepartmentRepository();
			List<Department> departments = deptRepo.GetAllDepartments();
			this.comboBoxDeptList.Items.Clear();

			foreach(Department department in departments)
			{
				this.comboBoxDeptList.Items.Add(department.name);
			}

			BranchRepository branchRepo = new BranchRepository();
			List<Branch> branches = branchRepo.GetAllBranches();
			this.comboBoxBranchList.Items.Clear();

			foreach ( Branch branch in branches)
			{
				this.comboBoxBranchList.Items.Add(branch.name);
			}

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			MainLogingForm frm = new MainLogingForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
	}
}
