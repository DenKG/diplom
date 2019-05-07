namespace Распределение_нагрузки
{
    partial class Экспорт_в_Excel
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
            this.ЭкспортДанныхПреподавателей_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РаспределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.ЭкспортДанныхПреподавателей_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ЭкспортДанныхПреподавателей_ХПTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ЭкспортДанныхПреподавателей_ХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ЭкспортДанныхПреподавателей_ХПBindingSource
            // 
            this.ЭкспортДанныхПреподавателей_ХПBindingSource.DataMember = "ЭкспортДанныхПреподавателей_ХП";
            this.ЭкспортДанныхПреподавателей_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // РаспределениеНагрузкиDataSet
            // 
            this.РаспределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.РаспределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            reportDataSource1.Value = this.ЭкспортДанныхПреподавателей_ХПBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Распределение_нагрузки.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // Экспорт_в_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Экспорт_в_Excel";
            this.Text = "Экспорт в Excel";
            this.Load += new System.EventHandler(this.Экспорт_в_Excel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ЭкспортДанныхПреподавателей_ХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ЭкспортДанныхПреподавателей_ХПBindingSource;
        private РаспределениеНагрузкиDataSet РаспределениеНагрузкиDataSet;
        private РаспределениеНагрузкиDataSetTableAdapters.ЭкспортДанныхПреподавателей_ХПTableAdapter ЭкспортДанныхПреподавателей_ХПTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}