
namespace E_Learning
{
	partial class AdminFeedbackInboxReport
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
			this.feedbackGRV = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFeedbackDetails = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnShowDetails = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnPrintFeedback = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.printDataGridViewDocument = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.feedbackGRV)).BeginInit();
			this.SuspendLayout();
			// 
			// feedbackGRV
			// 
			this.feedbackGRV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.feedbackGRV.Location = new System.Drawing.Point(30, 96);
			this.feedbackGRV.Name = "feedbackGRV";
			this.feedbackGRV.RowTemplate.Height = 25;
			this.feedbackGRV.Size = new System.Drawing.Size(544, 264);
			this.feedbackGRV.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(388, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Feedback Inbox Report Form";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(30, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Feedbacks List";
			// 
			// txtFeedbackDetails
			// 
			this.txtFeedbackDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.txtFeedbackDetails.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtFeedbackDetails.Location = new System.Drawing.Point(30, 414);
			this.txtFeedbackDetails.Name = "txtFeedbackDetails";
			this.txtFeedbackDetails.Size = new System.Drawing.Size(544, 289);
			this.txtFeedbackDetails.TabIndex = 3;
			this.txtFeedbackDetails.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(30, 390);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Feedback Details";
			// 
			// btnShowDetails
			// 
			this.btnShowDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnShowDetails.Location = new System.Drawing.Point(590, 246);
			this.btnShowDetails.Name = "btnShowDetails";
			this.btnShowDetails.Size = new System.Drawing.Size(178, 38);
			this.btnShowDetails.TabIndex = 5;
			this.btnShowDetails.Text = "Show Feedback Details";
			this.btnShowDetails.UseVisualStyleBackColor = true;
			this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPrint.Location = new System.Drawing.Point(590, 169);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(174, 38);
			this.btnPrint.TabIndex = 6;
			this.btnPrint.Text = "Print Feedback List";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnPrintFeedback
			// 
			this.btnPrintFeedback.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnPrintFeedback.Location = new System.Drawing.Point(590, 665);
			this.btnPrintFeedback.Name = "btnPrintFeedback";
			this.btnPrintFeedback.Size = new System.Drawing.Size(143, 38);
			this.btnPrintFeedback.TabIndex = 7;
			this.btnPrintFeedback.Text = "Print Feedback";
			this.btnPrintFeedback.UseVisualStyleBackColor = true;
			this.btnPrintFeedback.Click += new System.EventHandler(this.btnPrintFeedback_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnBack.Location = new System.Drawing.Point(30, 752);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(119, 38);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnExit.Location = new System.Drawing.Point(169, 752);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(114, 38);
			this.btnExit.TabIndex = 9;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// printDataGridViewDocument
			// 
			this.printDataGridViewDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDataGridViewDocument_PrintPage_1);
			// 
			// AdminFeedbackInboxReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 814);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnPrintFeedback);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnShowDetails);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFeedbackDetails);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.feedbackGRV);
			this.Name = "AdminFeedbackInboxReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminFeedbackInboxReport";
			this.Load += new System.EventHandler(this.AdminFeedbackInboxReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.feedbackGRV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView feedbackGRV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtFeedbackDetails;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnShowDetails;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnPrintFeedback;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnExit;
		private System.Drawing.Printing.PrintDocument printDataGridViewDocument;
	}
}