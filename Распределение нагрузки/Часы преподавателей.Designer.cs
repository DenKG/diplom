namespace Распределение_нагрузки
{
    partial class Часы_преподавателей
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
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.часыПоСтавкеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкаконтрактDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ставкабюджетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.всегоЧасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавателиНеВсеЧасыХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.преподавателиНеВсеЧасы_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиНеВсеЧасы_ХПTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиНеВсеЧасыХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.часыПоСтавкеDataGridViewTextBoxColumn,
            this.ставкаDataGridViewTextBoxColumn,
            this.ставкаконтрактDataGridViewTextBoxColumn,
            this.ставкабюджетDataGridViewTextBoxColumn,
            this.всегоЧасовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.преподавателиНеВсеЧасыХПBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // часыПоСтавкеDataGridViewTextBoxColumn
            // 
            this.часыПоСтавкеDataGridViewTextBoxColumn.DataPropertyName = "Часы по ставке";
            this.часыПоСтавкеDataGridViewTextBoxColumn.HeaderText = "Часы по ставке";
            this.часыПоСтавкеDataGridViewTextBoxColumn.Name = "часыПоСтавкеDataGridViewTextBoxColumn";
            this.часыПоСтавкеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ставкаDataGridViewTextBoxColumn
            // 
            this.ставкаDataGridViewTextBoxColumn.DataPropertyName = "Ставка";
            this.ставкаDataGridViewTextBoxColumn.HeaderText = "Ставка";
            this.ставкаDataGridViewTextBoxColumn.Name = "ставкаDataGridViewTextBoxColumn";
            this.ставкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ставкаконтрактDataGridViewTextBoxColumn
            // 
            this.ставкаконтрактDataGridViewTextBoxColumn.DataPropertyName = "Ставка_контракт";
            this.ставкаконтрактDataGridViewTextBoxColumn.HeaderText = "Ставка_контракт";
            this.ставкаконтрактDataGridViewTextBoxColumn.Name = "ставкаконтрактDataGridViewTextBoxColumn";
            this.ставкаконтрактDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ставкабюджетDataGridViewTextBoxColumn
            // 
            this.ставкабюджетDataGridViewTextBoxColumn.DataPropertyName = "Ставка_бюджет";
            this.ставкабюджетDataGridViewTextBoxColumn.HeaderText = "Ставка_бюджет";
            this.ставкабюджетDataGridViewTextBoxColumn.Name = "ставкабюджетDataGridViewTextBoxColumn";
            this.ставкабюджетDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // всегоЧасовDataGridViewTextBoxColumn
            // 
            this.всегоЧасовDataGridViewTextBoxColumn.DataPropertyName = "Всего часов";
            this.всегоЧасовDataGridViewTextBoxColumn.HeaderText = "Всего часов";
            this.всегоЧасовDataGridViewTextBoxColumn.Name = "всегоЧасовDataGridViewTextBoxColumn";
            this.всегоЧасовDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // преподавателиНеВсеЧасыХПBindingSource
            // 
            this.преподавателиНеВсеЧасыХПBindingSource.DataMember = "ПреподавателиНеВсеЧасы_ХП";
            this.преподавателиНеВсеЧасыХПBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // преподавателиНеВсеЧасы_ХПTableAdapter
            // 
            this.преподавателиНеВсеЧасы_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(169, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Преподавателям, которых нет в списке, предметы не назначены";
            // 
            // Часы_преподавателей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Часы_преподавателей";
            this.Text = "Часы_преподавателей";
            this.Load += new System.EventHandler(this.Часы_преподавателей_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиНеВсеЧасыХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.BindingSource преподавателиНеВсеЧасыХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиНеВсеЧасы_ХПTableAdapter преподавателиНеВсеЧасы_ХПTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn часыПоСтавкеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкаконтрактDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ставкабюджетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn всегоЧасовDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}