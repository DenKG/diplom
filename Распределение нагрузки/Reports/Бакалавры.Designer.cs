﻿namespace Распределение_нагрузки
{
    partial class Бакалавры
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.РаспределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.БакалаврыНагрузка_ХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.БакалаврыНагрузка_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.БакалаврыНагрузка_ХПTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.БакалаврыНагрузка_ХПBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.БакалаврыНагрузка_ХПBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Распределение_нагрузки.Бакалавры.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // РаспределениеНагрузкиDataSet
            // 
            this.РаспределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.РаспределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // БакалаврыНагрузка_ХПBindingSource
            // 
            this.БакалаврыНагрузка_ХПBindingSource.DataMember = "БакалаврыНагрузка_ХП";
            this.БакалаврыНагрузка_ХПBindingSource.DataSource = this.РаспределениеНагрузкиDataSet;
            // 
            // БакалаврыНагрузка_ХПTableAdapter
            // 
            this.БакалаврыНагрузка_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // Бакалавры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Бакалавры";
            this.Text = "Бакалавры. Отчет";
            this.Load += new System.EventHandler(this.Бакалавры_Load);
            ((System.ComponentModel.ISupportInitialize)(this.РаспределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.БакалаврыНагрузка_ХПBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource БакалаврыНагрузка_ХПBindingSource;
        private РаспределениеНагрузкиDataSet РаспределениеНагрузкиDataSet;
        private РаспределениеНагрузкиDataSetTableAdapters.БакалаврыНагрузка_ХПTableAdapter БакалаврыНагрузка_ХПTableAdapter;
    }
}