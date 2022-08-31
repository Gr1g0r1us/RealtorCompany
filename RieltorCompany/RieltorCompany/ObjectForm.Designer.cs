
namespace RieltorCompany
{
	partial class ObjectForm
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
			this.components = new System.ComponentModel.Container();
			this.тип_объектаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.тип_объектаTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.Тип_объектаTableAdapter();
			this.tableAdapterManager = new RieltorCompany.RealCompDataSetTableAdapters.TableAdapterManager();
			this.объектTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.ОбъектTableAdapter();
			this.объектBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox11 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.тип_объектаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.объектBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
			this.SuspendLayout();
			// 
			// тип_объектаTableAdapter
			// 
			this.тип_объектаTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = RieltorCompany.RealCompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ДоговорTableAdapter = null;
			this.tableAdapterManager.КлиентTableAdapter = null;
			this.tableAdapterManager.Назначение_объектаTableAdapter = null;
			this.tableAdapterManager.ОбъектTableAdapter = this.объектTableAdapter;
			this.tableAdapterManager.РайонTableAdapter = null;
			this.tableAdapterManager.РемонтTableAdapter = null;
			this.tableAdapterManager.РиелторTableAdapter = null;
			this.tableAdapterManager.Риелторская_компанияTableAdapter = null;
			this.tableAdapterManager.Состояние_выполнения_услугиTableAdapter = null;
			this.tableAdapterManager.Статус_выполнения_услугиTableAdapter = null;
			this.tableAdapterManager.Тип_объектаTableAdapter = this.тип_объектаTableAdapter;
			this.tableAdapterManager.Тип_услугиTableAdapter = null;
			this.tableAdapterManager.УлицаTableAdapter = null;
			// 
			// объектTableAdapter
			// 
			this.объектTableAdapter.ClearBeforeFill = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(272, 12);
			this.comboBox1.MaxDropDownItems = 10;
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Тип объекта:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Вид деятельности:";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(272, 42);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 24);
			this.comboBox2.TabIndex = 6;
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(272, 72);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 24);
			this.comboBox4.TabIndex = 8;
			// 
			// comboBox11
			// 
			this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox11.FormattingEnabled = true;
			this.comboBox11.Location = new System.Drawing.Point(272, 298);
			this.comboBox11.Name = "comboBox11";
			this.comboBox11.Size = new System.Drawing.Size(121, 24);
			this.comboBox11.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 17);
			this.label4.TabIndex = 20;
			this.label4.Text = "Улица:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 17);
			this.label5.TabIndex = 21;
			this.label5.Text = "Номер дома:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 17);
			this.label6.TabIndex = 22;
			this.label6.Text = "Номер квартиры:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 492);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 17);
			this.label7.TabIndex = 23;
			this.label7.Text = "Стоимость:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 17);
			this.label8.TabIndex = 24;
			this.label8.Text = "Общая площадь:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 188);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 17);
			this.label9.TabIndex = 25;
			this.label9.Text = "Жилая площадь:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 216);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 17);
			this.label10.TabIndex = 26;
			this.label10.Text = "Площадь кухни:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 244);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(141, 17);
			this.label11.TabIndex = 27;
			this.label11.Text = "Количество комнат:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 272);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(154, 17);
			this.label12.TabIndex = 28;
			this.label12.Text = "Количество санузлов:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(12, 301);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 17);
			this.label13.TabIndex = 29;
			this.label13.Text = "Ремонт:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(12, 333);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(98, 17);
			this.label14.TabIndex = 30;
			this.label14.Text = "Первый этаж:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(12, 367);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 17);
			this.label15.TabIndex = 31;
			this.label15.Text = "Последний этаж:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(12, 404);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(141, 17);
			this.label16.TabIndex = 32;
			this.label16.Text = "Этажность объекта:";
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(272, 242);
			this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(121, 22);
			this.numericUpDown4.TabIndex = 36;
			// 
			// numericUpDown5
			// 
			this.numericUpDown5.Location = new System.Drawing.Point(272, 402);
			this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(121, 22);
			this.numericUpDown5.TabIndex = 37;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(272, 332);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(49, 21);
			this.checkBox1.TabIndex = 38;
			this.checkBox1.Text = "Да";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(272, 366);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(49, 21);
			this.checkBox2.TabIndex = 39;
			this.checkBox2.Text = "Да";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(206, 430);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(187, 53);
			this.textBox3.TabIndex = 40;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 433);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 17);
			this.label3.TabIndex = 42;
			this.label3.Text = "Комментарий:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(272, 517);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 28);
			this.button1.TabIndex = 43;
			this.button1.Text = "Применить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown6
			// 
			this.numericUpDown6.Location = new System.Drawing.Point(272, 270);
			this.numericUpDown6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(121, 22);
			this.numericUpDown6.TabIndex = 44;
			// 
			// numericUpDown7
			// 
			this.numericUpDown7.Location = new System.Drawing.Point(272, 489);
			this.numericUpDown7.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(121, 22);
			this.numericUpDown7.TabIndex = 45;
			// 
			// numericUpDown8
			// 
			this.numericUpDown8.Location = new System.Drawing.Point(272, 102);
			this.numericUpDown8.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(121, 22);
			this.numericUpDown8.TabIndex = 46;
			// 
			// numericUpDown9
			// 
			this.numericUpDown9.Location = new System.Drawing.Point(272, 130);
			this.numericUpDown9.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(121, 22);
			this.numericUpDown9.TabIndex = 47;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(272, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 22);
			this.textBox1.TabIndex = 48;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(272, 185);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(121, 22);
			this.textBox2.TabIndex = 49;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(272, 213);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(121, 22);
			this.textBox4.TabIndex = 50;
			// 
			// ObjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 553);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.numericUpDown9);
			this.Controls.Add(this.numericUpDown8);
			this.Controls.Add(this.numericUpDown7);
			this.Controls.Add(this.numericUpDown6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.numericUpDown5);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox11);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "ObjectForm";
			this.Text = "Объект";
			this.Load += new System.EventHandler(this.Form7_Load);
			((System.ComponentModel.ISupportInitialize)(this.тип_объектаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.объектBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource тип_объектаBindingSource;
		private RealCompDataSetTableAdapters.Тип_объектаTableAdapter тип_объектаTableAdapter;
		private RealCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private RealCompDataSetTableAdapters.ОбъектTableAdapter объектTableAdapter;
		private System.Windows.Forms.BindingSource объектBindingSource;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox11;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.NumericUpDown numericUpDown5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown6;
		private System.Windows.Forms.NumericUpDown numericUpDown7;
		private System.Windows.Forms.NumericUpDown numericUpDown8;
		private System.Windows.Forms.NumericUpDown numericUpDown9;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox4;
	}
}