
namespace RieltorCompany
{
	partial class ReferenceDataForm
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
			this.realCompDataSet = new RieltorCompany.RealCompDataSet();
			this.статус_выполнения_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.объектBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.тип_услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.назначение_объектаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.клиентTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.КлиентTableAdapter();
			this.объектTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.ОбъектTableAdapter();
			this.статус_выполнения_услугиTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.Статус_выполнения_услугиTableAdapter();
			this.тип_услугиTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.Тип_услугиTableAdapter();
			this.назначение_объектаTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.Назначение_объектаTableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.статусВыполненияУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.типОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.назнчениеОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.состояниеРемонтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ремонтBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ремонтTableAdapter = new RieltorCompany.RealCompDataSetTableAdapters.РемонтTableAdapter();
			this.tableAdapterManager = new RieltorCompany.RealCompDataSetTableAdapters.TableAdapterManager();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.r20BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.риелторStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.улицаStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.realCompDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.статус_выполнения_услугиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.объектBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.тип_услугиBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.назначение_объектаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.r20BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// realCompDataSet
			// 
			this.realCompDataSet.DataSetName = "RealCompDataSet";
			this.realCompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// статус_выполнения_услугиBindingSource
			// 
			this.статус_выполнения_услугиBindingSource.DataMember = "Статус_выполнения_услуги";
			this.статус_выполнения_услугиBindingSource.DataSource = this.realCompDataSet;
			// 
			// объектBindingSource
			// 
			this.объектBindingSource.DataMember = "Объект";
			this.объектBindingSource.DataSource = this.realCompDataSet;
			// 
			// тип_услугиBindingSource
			// 
			this.тип_услугиBindingSource.DataMember = "Тип_услуги";
			this.тип_услугиBindingSource.DataSource = this.realCompDataSet;
			// 
			// назначение_объектаBindingSource
			// 
			this.назначение_объектаBindingSource.DataMember = "Назначение_объекта";
			this.назначение_объектаBindingSource.DataSource = this.realCompDataSet;
			// 
			// клиентBindingSource
			// 
			this.клиентBindingSource.DataMember = "Клиент";
			this.клиентBindingSource.DataSource = this.realCompDataSet;
			// 
			// клиентTableAdapter
			// 
			this.клиентTableAdapter.ClearBeforeFill = true;
			// 
			// объектTableAdapter
			// 
			this.объектTableAdapter.ClearBeforeFill = true;
			// 
			// статус_выполнения_услугиTableAdapter
			// 
			this.статус_выполнения_услугиTableAdapter.ClearBeforeFill = true;
			// 
			// тип_услугиTableAdapter
			// 
			this.тип_услугиTableAdapter.ClearBeforeFill = true;
			// 
			// назначение_объектаTableAdapter
			// 
			this.назначение_объектаTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1052, 418);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объектыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.услугиToolStripMenuItem,
            this.статусВыполненияУслугиToolStripMenuItem,
            this.улицаStripMenuItem,
            this.типОбъектаToolStripMenuItem,
            this.назнчениеОбъектаToolStripMenuItem,
            this.состояниеРемонтаToolStripMenuItem,
            this.риелторStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// объектыToolStripMenuItem
			// 
			this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
			this.объектыToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
			this.объектыToolStripMenuItem.Text = "Объекты";
			this.объектыToolStripMenuItem.Click += new System.EventHandler(this.объектыToolStripMenuItem_Click);
			// 
			// клиентыToolStripMenuItem
			// 
			this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
			this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			this.клиентыToolStripMenuItem.Text = "Клиенты";
			this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
			// 
			// услугиToolStripMenuItem
			// 
			this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
			this.услугиToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			this.услугиToolStripMenuItem.Text = "Услуги";
			this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
			// 
			// статусВыполненияУслугиToolStripMenuItem
			// 
			this.статусВыполненияУслугиToolStripMenuItem.Name = "статусВыполненияУслугиToolStripMenuItem";
			this.статусВыполненияУслугиToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
			this.статусВыполненияУслугиToolStripMenuItem.Text = "Статус выполнения услуги";
			this.статусВыполненияУслугиToolStripMenuItem.Click += new System.EventHandler(this.статусВыполненияУслугиToolStripMenuItem_Click);
			// 
			// типОбъектаToolStripMenuItem
			// 
			this.типОбъектаToolStripMenuItem.Name = "типОбъектаToolStripMenuItem";
			this.типОбъектаToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
			this.типОбъектаToolStripMenuItem.Text = "Тип объекта";
			this.типОбъектаToolStripMenuItem.Click += new System.EventHandler(this.типОбъектаToolStripMenuItem_Click);
			// 
			// назнчениеОбъектаToolStripMenuItem
			// 
			this.назнчениеОбъектаToolStripMenuItem.Name = "назнчениеОбъектаToolStripMenuItem";
			this.назнчениеОбъектаToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
			this.назнчениеОбъектаToolStripMenuItem.Text = "Назначение объекта";
			this.назнчениеОбъектаToolStripMenuItem.Click += new System.EventHandler(this.назнчениеОбъектаToolStripMenuItem_Click);
			// 
			// состояниеРемонтаToolStripMenuItem
			// 
			this.состояниеРемонтаToolStripMenuItem.Name = "состояниеРемонтаToolStripMenuItem";
			this.состояниеРемонтаToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
			this.состояниеРемонтаToolStripMenuItem.Text = "Состояние ремонта";
			this.состояниеРемонтаToolStripMenuItem.Click += new System.EventHandler(this.состояниеРемонтаToolStripMenuItem_Click);
			// 
			// ремонтBindingSource
			// 
			this.ремонтBindingSource.DataMember = "Ремонт";
			this.ремонтBindingSource.DataSource = this.realCompDataSet;
			// 
			// ремонтTableAdapter
			// 
			this.ремонтTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = RieltorCompany.RealCompDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.ДоговорTableAdapter = null;
			this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
			this.tableAdapterManager.Назначение_объектаTableAdapter = this.назначение_объектаTableAdapter;
			this.tableAdapterManager.ОбъектTableAdapter = this.объектTableAdapter;
			this.tableAdapterManager.РайонTableAdapter = null;
			this.tableAdapterManager.РемонтTableAdapter = this.ремонтTableAdapter;
			this.tableAdapterManager.РиелторTableAdapter = null;
			this.tableAdapterManager.Риелторская_компанияTableAdapter = null;
			this.tableAdapterManager.Состояние_выполнения_услугиTableAdapter = null;
			this.tableAdapterManager.Статус_выполнения_услугиTableAdapter = this.статус_выполнения_услугиTableAdapter;
			this.tableAdapterManager.Тип_объектаTableAdapter = null;
			this.tableAdapterManager.Тип_услугиTableAdapter = this.тип_услугиTableAdapter;
			this.tableAdapterManager.УлицаTableAdapter = null;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1058, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1058, 66);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "Изменить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1058, 101);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 29);
			this.button3.TabIndex = 4;
			this.button3.Text = "Удалить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// r20BindingSource
			// 
			this.r20BindingSource.DataMember = "R_20";
			// 
			// риелторStripMenuItem
			// 
			this.риелторStripMenuItem.Name = "риелторStripMenuItem";
			this.риелторStripMenuItem.Size = new System.Drawing.Size(80, 24);
			this.риелторStripMenuItem.Text = "Риелтор";
			this.риелторStripMenuItem.Click += new System.EventHandler(this.риелторStripMenuItem_Click);
			// 
			// улицаStripMenuItem
			// 
			this.улицаStripMenuItem.Name = "улицаStripMenuItem";
			this.улицаStripMenuItem.Size = new System.Drawing.Size(66, 24);
			this.улицаStripMenuItem.Text = "Улица";
			this.улицаStripMenuItem.Click += new System.EventHandler(this.улицаStripMenuItem_Click);
			// 
			// ReferenceDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1160, 446);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ReferenceDataForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Справочные данные";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.realCompDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.статус_выполнения_услугиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.объектBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.тип_услугиBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.назначение_объектаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ремонтBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.r20BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private RealCompDataSet realCompDataSet;
		private RealCompDataSetTableAdapters.Статус_выполнения_услугиTableAdapter статус_выполнения_услугиTableAdapter;
		private System.Windows.Forms.BindingSource статус_выполнения_услугиBindingSource;
		private RealCompDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
		private System.Windows.Forms.BindingSource клиентBindingSource;
		private RealCompDataSetTableAdapters.ОбъектTableAdapter объектTableAdapter;
		private System.Windows.Forms.BindingSource объектBindingSource;
		private System.Windows.Forms.BindingSource тип_услугиBindingSource;
		private RealCompDataSetTableAdapters.Тип_услугиTableAdapter тип_услугиTableAdapter;
		private System.Windows.Forms.BindingSource назначение_объектаBindingSource;
		private RealCompDataSetTableAdapters.Назначение_объектаTableAdapter назначение_объектаTableAdapter;
		private System.Windows.Forms.BindingSource r20BindingSource;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem состояниеРемонтаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem типОбъектаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem статусВыполненияУслугиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem назнчениеОбъектаToolStripMenuItem;
		private System.Windows.Forms.BindingSource ремонтBindingSource;
		private RealCompDataSetTableAdapters.РемонтTableAdapter ремонтTableAdapter;
		private RealCompDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ToolStripMenuItem риелторStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem улицаStripMenuItem;
	}
}