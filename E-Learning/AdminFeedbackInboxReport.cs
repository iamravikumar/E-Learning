using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using E_Learning.DAL;
using E_Learning.Business;

namespace E_Learning
{
	public partial class AdminFeedbackInboxReport : Form
	{
		private List<Feedback> feedbacks;
		private FeedbackRepository feedbackRepo;
		public AdminFeedbackInboxReport()
		{
			InitializeComponent();
		}

		private void AdminFeedbackInboxReport_Load(object sender, EventArgs e)
		{
			feedbackRepo = new FeedbackRepository();
			PopulateFeedbacks();
		}

		private void PopulateFeedbacks()
		{
			feedbacks = feedbackRepo.GetAllFeedback();
			feedbackGRV.DataSource = null;
			if (feedbacks.Count> 0)
			{
				feedbackGRV.DataSource = feedbacks;
				// Hide un-neccessary columns
				feedbackGRV.Columns[0].Visible = false;
				feedbackGRV.Columns[6].Visible = false;
				feedbackGRV.Columns[7].Visible = false;
				feedbackGRV.Columns[8].Visible = false;
			}
			else
			{
				MessageBox.Show("No Feedback Yet");
			}
		}

		private void btnPrintFeedback_Click(object sender, EventArgs e)
		{

		}

		private void btnShowDetails_Click(object sender, EventArgs e)
		{
			ShowFeedbackDetails();
		}

		private void PrintGridView(PrintPageEventArgs e)
		{
			PrintDocument printDocument = new PrintDocument();
			//create Bitmap and add/draw datagridview to it 
			Bitmap dataGridViewBitmap = new Bitmap(this.feedbackGRV.Width, this.feedbackGRV.Height);
			feedbackGRV.DrawToBitmap(dataGridViewBitmap, new System.Drawing
				.Rectangle(0, 0, this.feedbackGRV.Width, this.feedbackGRV.Height));
			e.Graphics.DrawImage(dataGridViewBitmap, 0, 0);

			PrintDialog printDialog = new PrintDialog();
			PrintDialog dataGridViewPrintDialog = new PrintDialog();
			dataGridViewPrintDialog.Document = printDocument;
			dataGridViewPrintDialog.UseEXDialog = true;
			if (DialogResult.OK == dataGridViewPrintDialog.ShowDialog())
			{
				//Document Name
				printDocument.DocumentName = "Printed DataGridView";
				//Print Datagridview
				printDocument.Print();
			}
		}

	private void ShowFeedbackDetails()
		{
			int index = feedbackGRV.CurrentRow.Index;
			int id = Convert.ToInt32(feedbackGRV.Rows[index].Cells[0].Value.ToString());
			Feedback feedback = feedbackRepo.GetFeedbackById(id);
			//Fill in the feedback text box
			this.txtFeedbackDetails.Text = null;
			txtFeedbackDetails.Text = "Enrollment ID:\t"+ feedback.enrollment_id +"\n"+ 
									  "Feedback Title:\t" + feedback.feedback_title + "\n\n" + 
									  "Feedback Content:\t" + feedback.feedback_text;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			AdminUploadDownloadInfoForm frm = new AdminUploadDownloadInfoForm();
			frm.Show();
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			/*PrintDocument printDocument = new PrintDocument();
			PrintDialog dataGridViewPrintDialog = new PrintDialog();
			dataGridViewPrintDialog.Document = printDataGridViewDocument;
			dataGridViewPrintDialog.UseEXDialog = true;

			DialogResult result = dataGridViewPrintDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				//Document Name
				printDocument.DocumentName = "Printed DataGridView";
				//Print Datagridview
				printDocument.Print();
			}*/			
		}

		private void printDataGridViewDocument_PrintPage_1(object sender, PrintPageEventArgs e)
		{
			//create Bitmap and add/draw datagridview to it 
			Bitmap dataGridViewBitmap = new Bitmap(this.feedbackGRV.Width, this.feedbackGRV.Height);
			feedbackGRV.DrawToBitmap(dataGridViewBitmap, new System.Drawing
				.Rectangle(0, 0, this.feedbackGRV.Width, this.feedbackGRV.Height));
			e.Graphics.DrawImage(dataGridViewBitmap, 0, 0);
		}
	}
}
