namespace Распределение_нагрузки
{
    partial class КонсультацииАС
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.показатьАкадСоветниковХПBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet1 = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.распределениеНагрузкиDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.направленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.направленияTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.НаправленияTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.уровниподготовкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.уровни_подготовкиTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.Уровни_подготовкиTableAdapter();
            this.показатьАкадСоветниковХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.показатьАкадСоветников_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ПоказатьАкадСоветников_ХПTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Удалить = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьАкадСоветниковХПBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уровниподготовкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьАкадСоветниковХПBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.направлениеDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.часыDataGridViewTextBoxColumn,
            this.Удалить,
            this.ID,
            this.ID1,
            this.Предмет});
            this.dataGridView1.DataSource = this.показатьАкадСоветниковХПBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1186, 557);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // показатьАкадСоветниковХПBindingSource1
            // 
            this.показатьАкадСоветниковХПBindingSource1.DataMember = "ПоказатьАкадСоветников_ХП";
            this.показатьАкадСоветниковХПBindingSource1.DataSource = this.распределениеНагрузкиDataSet1;
            // 
            // распределениеНагрузкиDataSet1
            // 
            this.распределениеНагрузкиDataSet1.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Преподаватель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Группа";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(675, 579);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1123, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Назначить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Семестр";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(572, 579);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(38, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // распределениеНагрузкиDataSetBindingSource
            // 
            this.распределениеНагрузкиDataSetBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            this.распределениеНагрузкиDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.преподавателиBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(905, 579);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID";
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.распределениеНагрузкиDataSetBindingSource;
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Направление";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.направленияBindingSource;
            this.comboBox4.DisplayMember = "Направление";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(93, 579);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(196, 21);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.ValueMember = "ID";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // направленияBindingSource
            // 
            this.направленияBindingSource.DataMember = "Направления";
            this.направленияBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // направленияTableAdapter
            // 
            this.направленияTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Подготовка";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.уровниподготовкиBindingSource;
            this.comboBox5.DisplayMember = "Уровень_подготовки";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(377, 579);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 11;
            this.comboBox5.ValueMember = "ID";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // уровниподготовкиBindingSource
            // 
            this.уровниподготовкиBindingSource.DataMember = "Уровни_подготовки";
            this.уровниподготовкиBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // уровни_подготовкиTableAdapter
            // 
            this.уровни_подготовкиTableAdapter.ClearBeforeFill = true;
            // 
            // показатьАкадСоветниковХПBindingSource
            // 
            this.показатьАкадСоветниковХПBindingSource.DataMember = "ПоказатьАкадСоветников_ХП";
            this.показатьАкадСоветниковХПBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // показатьАкадСоветников_ХПTableAdapter
            // 
            this.показатьАкадСоветников_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            this.направлениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            this.группаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // дисциплинаDataGridViewTextBoxColumn
            // 
            this.дисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.Name = "дисциплинаDataGridViewTextBoxColumn";
            this.дисциплинаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // часыDataGridViewTextBoxColumn
            // 
            this.часыDataGridViewTextBoxColumn.DataPropertyName = "Часы";
            this.часыDataGridViewTextBoxColumn.HeaderText = "Часы";
            this.часыDataGridViewTextBoxColumn.Name = "часыDataGridViewTextBoxColumn";
            this.часыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Удалить
            // 
            this.Удалить.HeaderText = "";
            this.Удалить.Name = "Удалить";
            this.Удалить.ReadOnly = true;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseColumnTextForButtonValue = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID1
            // 
            this.ID1.DataPropertyName = "ID1";
            this.ID1.HeaderText = "ID1";
            this.ID1.Name = "ID1";
            this.ID1.ReadOnly = true;
            this.ID1.Visible = false;
            // 
            // Предмет
            // 
            this.Предмет.DataPropertyName = "Предмет";
            this.Предмет.HeaderText = "Предмет";
            this.Предмет.Name = "Предмет";
            this.Предмет.ReadOnly = true;
            this.Предмет.Visible = false;
            // 
            // КонсультацииАС
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 609);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "КонсультацииАС";
            this.Text = "КонсультацииАС";
            this.Load += new System.EventHandler(this.КонсультацииАС_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьАкадСоветниковХПBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.направленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уровниподготовкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьАкадСоветниковХПBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource распределениеНагрузкиDataSetBindingSource;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource направленияBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.НаправленияTableAdapter направленияTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource уровниподготовкиBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.Уровни_подготовкиTableAdapter уровни_подготовкиTableAdapter;
        private System.Windows.Forms.BindingSource показатьАкадСоветниковХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ПоказатьАкадСоветников_ХПTableAdapter показатьАкадСоветников_ХПTableAdapter;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet1;
        private System.Windows.Forms.BindingSource показатьАкадСоветниковХПBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Удалить;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Предмет;
    }
}