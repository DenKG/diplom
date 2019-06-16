namespace Распределение_нагрузки
{
    partial class Преподаватели_для_лабораторных
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
            this.label1 = new System.Windows.Forms.Label();
            this.преподавателиComboBox = new System.Windows.Forms.ComboBox();
            this.ОКButton = new System.Windows.Forms.Button();
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Преподаватель";
            // 
            // преподавателиComboBox
            // 
            this.преподавателиComboBox.DataSource = this.преподавателиBindingSource;
            this.преподавателиComboBox.DisplayMember = "ФИО";
            this.преподавателиComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.преподавателиComboBox.FormattingEnabled = true;
            this.преподавателиComboBox.Location = new System.Drawing.Point(104, 12);
            this.преподавателиComboBox.Name = "преподавателиComboBox";
            this.преподавателиComboBox.Size = new System.Drawing.Size(178, 21);
            this.преподавателиComboBox.TabIndex = 1;
            this.преподавателиComboBox.ValueMember = "ID";
            // 
            // ОКButton
            // 
            this.ОКButton.Location = new System.Drawing.Point(288, 11);
            this.ОКButton.Name = "ОКButton";
            this.ОКButton.Size = new System.Drawing.Size(75, 23);
            this.ОКButton.TabIndex = 2;
            this.ОКButton.Text = "ОК";
            this.ОКButton.UseVisualStyleBackColor = true;
            this.ОКButton.Click += new System.EventHandler(this.ОКButton_Click);
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Преподаватели_для_лабораторных
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 44);
            this.ControlBox = false;
            this.Controls.Add(this.ОКButton);
            this.Controls.Add(this.преподавателиComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Преподаватели_для_лабораторных";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите второго преподавателя";
            this.Load += new System.EventHandler(this.Преподаватели_для_лабораторных_Load);
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox преподавателиComboBox;
        private System.Windows.Forms.Button ОКButton;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
    }
}