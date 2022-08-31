
namespace RieltorCompany
{
	partial class ReportsForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataTable1TableAdapter1 = new RieltorCompany.Report1.DataSet1TableAdapters.DataTable1TableAdapter();
			this.dataSet11 = new RieltorCompany.Report1.DataSet1();
			this.dataSet21 = new RieltorCompany.Report2.DataSet2();
			this.dataTable2TableAdapter1 = new RieltorCompany.Report2.DataSet2TableAdapters.DataTable2TableAdapter();
			this.dataSet31 = new RieltorCompany.Report3.DataSet3();
			this.dataTable3TableAdapter1 = new RieltorCompany.Report3.DataSet3TableAdapters.DataTable3TableAdapter();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(609, 107);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.dateTimePicker3);
			this.tabPage1.Controls.Add(this.dateTimePicker4);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(601, 78);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Отчет о сделках компании";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 17);
			this.label2.TabIndex = 56;
			this.label2.Text = "с";
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.CustomFormat = "";
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker3.Location = new System.Drawing.Point(236, 39);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(165, 22);
			this.dateTimePicker3.TabIndex = 55;
			// 
			// dateTimePicker4
			// 
			this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker4.Location = new System.Drawing.Point(29, 40);
			this.dateTimePicker4.Name = "dateTimePicker4";
			this.dateTimePicker4.Size = new System.Drawing.Size(171, 22);
			this.dateTimePicker4.TabIndex = 54;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(206, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 17);
			this.label6.TabIndex = 53;
			this.label6.Text = "по";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(194, 17);
			this.label7.TabIndex = 52;
			this.label7.Text = "Выбор промежутка времени";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(468, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 48);
			this.button1.TabIndex = 41;
			this.button1.Text = "Сформировать отчет";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.dateTimePicker1);
			this.tabPage2.Controls.Add(this.dateTimePicker2);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(601, 78);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Эффективность работы риелторов";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 17);
			this.label1.TabIndex = 61;
			this.label1.Text = "с";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(236, 41);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(165, 22);
			this.dateTimePicker1.TabIndex = 60;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(29, 42);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(171, 22);
			this.dateTimePicker2.TabIndex = 59;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(206, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 17);
			this.label3.TabIndex = 58;
			this.label3.Text = "по";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 17);
			this.label4.TabIndex = 57;
			this.label4.Text = "Выбор промежутка времени";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(468, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 48);
			this.button2.TabIndex = 50;
			this.button2.Text = "Сформировать статистику";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button3);
			this.tabPage4.Controls.Add(this.comboBox4);
			this.tabPage4.Controls.Add(this.label5);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(601, 78);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Формирование договора";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(468, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 48);
			this.button3.TabIndex = 51;
			this.button3.Text = "Вывести на печать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(152, 13);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(166, 24);
			this.comboBox4.TabIndex = 48;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Выбор договора";
			// 
			// dataTable1TableAdapter1
			// 
			this.dataTable1TableAdapter1.ClearBeforeFill = true;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataSet21
			// 
			this.dataSet21.DataSetName = "DataSet2";
			this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataTable2TableAdapter1
			// 
			this.dataTable2TableAdapter1.ClearBeforeFill = true;
			// 
			// dataSet31
			// 
			this.dataSet31.DataSetName = "DataSet3";
			this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataTable3TableAdapter1
			// 
			this.dataTable3TableAdapter1.ClearBeforeFill = true;
			// 
			// ReportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 128);
			this.Controls.Add(this.tabControl1);
			this.Name = "ReportsForm";
			this.Text = "Отчеты";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DateTimePicker dateTimePicker4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Report1.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
		private Report1.DataSet1 dataSet11;
		private Report2.DataSet2 dataSet21;
		private Report2.DataSet2TableAdapters.DataTable2TableAdapter dataTable2TableAdapter1;
		private Report3.DataSet3 dataSet31;
		private Report3.DataSet3TableAdapters.DataTable3TableAdapter dataTable3TableAdapter1;
	}
}