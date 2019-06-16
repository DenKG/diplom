namespace Распределение_нагрузки
{
    partial class Отчет_по_преподавателям
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ОтчетПоПреподавателю_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РаспределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.ОтчетНагрузкаКафедры_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ОтчетОбщаяНагрузка_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ОтчетОбщаяНагрузка_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ОтчетОбщаяНагрузка_ХПTableAdapter();
            this.ОтчетНагрузкаКафедры_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ОтчетНагрузкаКафедры_ХПTableAdapter();
            this.ЭкспортДанныхПреподавателей_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ЭкспортДанныхПреподавателей_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ЭкспортДанныхПреподавателей_ХПTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ОтчетПоПреподавателю_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ОтчетПоПреподавателю_ХПTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетПоПреподавателю_ХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетНагрузкаКафедры_ХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетОбщаяНагрузка_ХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЭкспортДанныхПреподавателей_ХПBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ОтчетПоПреподавателю_ХПBindingSource
            // 
            this.ОтчетПоПреподавателю_ХПBindingSource.DataMember = "ОтчетПоПреподавателю_ХП";
            this.ОтчетПоПреподавателю_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // РаспределениеНагрузкиDataSet
            // 
            this.РаспределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.РаспределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ОтчетНагрузкаКафедры_ХПBindingSource
            // 
            this.ОтчетНагрузкаКафедры_ХПBindingSource.DataMember = "ОтчетНагрузкаКафедры_ХП";
            this.ОтчетНагрузкаКафедры_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // ОтчетОбщаяНагрузка_ХПBindingSource
            // 
            this.ОтчетОбщаяНагрузка_ХПBindingSource.DataMember = "ОтчетОбщаяНагрузка_ХП";
            this.ОтчетОбщаяНагрузка_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // ОтчетОбщаяНагрузка_ХПTableAdapter
            // 
            this.ОтчетОбщаяНагрузка_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // ОтчетНагрузкаКафедры_ХПTableAdapter
            // 
            this.ОтчетНагрузкаКафедры_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // ЭкспортДанныхПреподавателей_ХПBindingSource
            // 
            this.ЭкспортДанныхПреподавателей_ХПBindingSource.DataMember = "ЭкспортДанныхПреподавателей_ХП";
            this.ЭкспортДанныхПреподавателей_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // ЭкспортДанныхПреподавателей_ХПTableAdapter
            // 
            this.ЭкспортДанныхПреподавателей_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ОтчетПоПреподавателю_ХПBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Распределение_нагрузки.TeachersReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // ОтчетПоПреподавателю_ХПTableAdapter
            // 
            this.ОтчетПоПреподавателю_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // Отчет_по_преподавателям
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчет_по_преподавателям";
            this.Text = "Отчет_по_преподавателям";
            this.Load += new System.EventHandler(this.Отчет_по_преподавателям_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетПоПреподавателю_ХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетНагрузкаКафедры_ХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетОбщаяНагрузка_ХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ЭкспортДанныхПреподавателей_ХПBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ОтчетОбщаяНагрузка_ХПBindingSource;
        private РаспределениеНагрузкиDataSet РаспределениеНагрузкиDataSet;
        private РаспределениеНагрузкиDataSetTableAdapters.ОтчетОбщаяНагрузка_ХПTableAdapter ОтчетОбщаяНагрузка_ХПTableAdapter;
        private System.Windows.Forms.BindingSource ОтчетНагрузкаКафедры_ХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ОтчетНагрузкаКафедры_ХПTableAdapter ОтчетНагрузкаКафедры_ХПTableAdapter;
        private System.Windows.Forms.BindingSource ЭкспортДанныхПреподавателей_ХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ЭкспортДанныхПреподавателей_ХПTableAdapter ЭкспортДанныхПреподавателей_ХПTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ОтчетПоПреподавателю_ХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ОтчетПоПреподавателю_ХПTableAdapter ОтчетПоПреподавателю_ХПTableAdapter;
    }
}