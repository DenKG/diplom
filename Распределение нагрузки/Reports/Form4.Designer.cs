namespace Распределение_нагрузки
{
    partial class Form4
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
            this.ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.РаспределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource
            // 
            this.ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource.DataMember = "ОтчетНагрузкаКафедрыForMatrix_ХП";
            this.ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // РаспределениеНагрузкиDataSet
            // 
            this.РаспределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.РаспределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Распределение_нагрузки.LoadPivot.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter
            // 
            this.ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.Text = "Нагрузка кафедры";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ОтчетНагрузкаКафедрыForMatrix_ХПBindingSource;
        private РаспределениеНагрузкиDataSet РаспределениеНагрузкиDataSet;
        private РаспределениеНагрузкиDataSetTableAdapters.ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter ОтчетНагрузкаКафедрыForMatrix_ХПTableAdapter;
    }
}