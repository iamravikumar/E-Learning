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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

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

		private void btnShowDetails_Click(object sender, EventArgs e)
		{
			ShowFeedbackDetails();
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
			ExportGridViewToPdf(feedbackGRV, "Feedbacks List");
		}

		private void ExportGridViewToPdf(DataGridView dgv, string fileName)
		{
			BaseFont font = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
			PdfPTable pdf = new PdfPTable(5);
			pdf.DefaultCell.Padding = 3;
			pdf.WidthPercentage = 100;
			pdf.HorizontalAlignment = Element.ALIGN_LEFT;
			pdf.DefaultCell.BorderWidth = 1;
			iTextSharp.text.Font text = new iTextSharp.text.Font(font, 10, iTextSharp.text.Font.NORMAL);

			//Add header
			foreach (DataGridViewColumn item in dgv.Columns)
			{
				if (item.Index != 0 && item.Index != 6 && item.Index != 7 && item.Index != 8)
				{
					PdfPCell cell = new PdfPCell(new Phrase(item.HeaderText, text));
					cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
					pdf.AddCell(cell);
				}
				else
					continue;
			}

			//Add rows
			foreach (DataGridViewRow item in dgv.Rows)
			{
				if (item.Index != 0 && item.Index != 6 && item.Index != 7 && item.Index != 8)
				{
					foreach (DataGridViewCell cell in item.Cells)
					{
						if (cell.ColumnIndex != 0 && cell.ColumnIndex != 6 && cell.ColumnIndex != 7 && cell.ColumnIndex != 8)
						{
							if (cell.Value != null)
								pdf.AddCell(new Phrase(cell.Value.ToString(), text));
						}
						else
							continue;
					}
				}
				else
					continue;
			}

			var saveFile = new SaveFileDialog();
			saveFile.FileName = fileName;
			saveFile.DefaultExt = ".pdf";

			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
				{
					Document doc = new Document(PageSize.A4, 10f, 10f, 10f, 0);
					PdfWriter.GetInstance(doc, stream);
					doc.Open();
					doc.Add(pdf);
					doc.Close();
					stream.Close();
				}
			}
		}
	}
}
