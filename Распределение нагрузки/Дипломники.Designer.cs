namespace Распределение_нагрузки
{
    partial class Дипломники
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
            this.показатьДипломниковХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.показатьДипломниковХПBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.показатьДипломников_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ПоказатьДипломников_ХПTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колДиплDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьДипломниковХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьДипломниковХПBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
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
            this.iDDataGridViewTextBoxColumn,
            this.Предмет,
            this.фИОDataGridViewTextBoxColumn,
            this.колДиплDataGridViewTextBoxColumn,
            this.часыDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.показатьДипломниковХПBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(728, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // показатьДипломниковХПBindingSource
            // 
            this.показатьДипломниковХПBindingSource.DataMember = "ПоказатьДипломников_ХП";
            this.показатьДипломниковХПBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // показатьДипломниковХПBindingSource1
            // 
            this.показатьДипломниковХПBindingSource1.DataMember = "ПоказатьДипломников_ХП";
            this.показатьДипломниковХПBindingSource1.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назначить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Преподаватель";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.преподавателиBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "ID";
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во дипл.";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(416, 364);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(38, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Коэф. в нагрузку";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(571, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0,5";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // показатьДипломников_ХПTableAdapter
            // 
            this.показатьДипломников_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Предмет
            // 
            this.Предмет.DataPropertyName = "Предмет";
            this.Предмет.HeaderText = "Предмет";
            this.Предмет.Name = "Предмет";
            this.Предмет.ReadOnly = true;
            this.Предмет.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // колДиплDataGridViewTextBoxColumn
            // 
            this.колДиплDataGridViewTextBoxColumn.DataPropertyName = "КолДипл";
            this.колДиплDataGridViewTextBoxColumn.HeaderText = "Количество человек";
            this.колДиплDataGridViewTextBoxColumn.Name = "колДиплDataGridViewTextBoxColumn";
            this.колДиплDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // часыDataGridViewTextBoxColumn
            // 
            this.часыDataGridViewTextBoxColumn.DataPropertyName = "Часы";
            this.часыDataGridViewTextBoxColumn.HeaderText = "Часы";
            this.часыDataGridViewTextBoxColumn.Name = "часыDataGridViewTextBoxColumn";
            this.часыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Удалить";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Дипломники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Дипломники";
            this.Text = "Дипломники";
            this.Load += new System.EventHandler(this.Дипломники_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьДипломниковХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.показатьДипломниковХПBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource показатьДипломниковХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ПоказатьДипломников_ХПTableAdapter показатьДипломников_ХПTableAdapter;
        private System.Windows.Forms.BindingSource показатьДипломниковХПBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Предмет;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колДиплDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}