namespace Распределение_нагрузки
{
    partial class Добавить_преподавателя
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ФИОTextBox = new System.Windows.Forms.TextBox();
            this.началоТрудовойДеятельностиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.должностьComboBox = new System.Windows.Forms.ComboBox();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.добавитьButton = new System.Windows.Forms.Button();
            this.должностиTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ДолжностиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начало т.д.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность";
            // 
            // ФИОTextBox
            // 
            this.ФИОTextBox.Location = new System.Drawing.Point(85, 15);
            this.ФИОTextBox.Name = "ФИОTextBox";
            this.ФИОTextBox.Size = new System.Drawing.Size(160, 20);
            this.ФИОTextBox.TabIndex = 4;
            this.ФИОTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ФИОTextBox_KeyPress);
            // 
            // началоТрудовойДеятельностиDateTimePicker
            // 
            this.началоТрудовойДеятельностиDateTimePicker.Location = new System.Drawing.Point(85, 41);
            this.началоТрудовойДеятельностиDateTimePicker.Name = "началоТрудовойДеятельностиDateTimePicker";
            this.началоТрудовойДеятельностиDateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.началоТрудовойДеятельностиDateTimePicker.TabIndex = 5;
            // 
            // должностьComboBox
            // 
            this.должностьComboBox.DataSource = this.должностиBindingSource;
            this.должностьComboBox.DisplayMember = "Должность";
            this.должностьComboBox.FormattingEnabled = true;
            this.должностьComboBox.Location = new System.Drawing.Point(85, 67);
            this.должностьComboBox.Name = "должностьComboBox";
            this.должностьComboBox.Size = new System.Drawing.Size(160, 21);
            this.должностьComboBox.TabIndex = 6;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // добавитьButton
            // 
            this.добавитьButton.Location = new System.Drawing.Point(18, 94);
            this.добавитьButton.Name = "добавитьButton";
            this.добавитьButton.Size = new System.Drawing.Size(227, 23);
            this.добавитьButton.TabIndex = 8;
            this.добавитьButton.Text = "Добавить";
            this.добавитьButton.UseVisualStyleBackColor = true;
            this.добавитьButton.Click += new System.EventHandler(this.добавитьButton_Click);
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // Добавить_преподавателя
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 131);
            this.Controls.Add(this.добавитьButton);
            this.Controls.Add(this.должностьComboBox);
            this.Controls.Add(this.началоТрудовойДеятельностиDateTimePicker);
            this.Controls.Add(this.ФИОTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Добавить_преподавателя";
            this.Text = "Добавить_преподавателя";
            this.Load += new System.EventHandler(this.Добавить_преподавателя_Load);
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ФИОTextBox;
        private System.Windows.Forms.DateTimePicker началоТрудовойДеятельностиDateTimePicker;
        private System.Windows.Forms.ComboBox должностьComboBox;
        private System.Windows.Forms.Button добавитьButton;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
    }
}