﻿namespace Распределение_нагрузки
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиButton = new System.Windows.Forms.Button();
            this.группыButton = new System.Windows.Forms.Button();
            this.учебныйПланButton = new System.Windows.Forms.Button();
            this.общаяНагрузкаButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.всеПреподавателиХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.всепреподавателипоказатьХПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.все_преподаватели_показать_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.Все_преподаватели_показать_ХПTableAdapter();
            this.всеПреподаватели_ХПTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.ВсеПреподаватели_ХПTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.всеПреподавателиХПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.всепреподавателипоказатьХПBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(249, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // преподавателиButton
            // 
            this.преподавателиButton.Location = new System.Drawing.Point(12, 40);
            this.преподавателиButton.Name = "преподавателиButton";
            this.преподавателиButton.Size = new System.Drawing.Size(228, 23);
            this.преподавателиButton.TabIndex = 1;
            this.преподавателиButton.Text = "Преподаватели";
            this.преподавателиButton.UseVisualStyleBackColor = true;
            this.преподавателиButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // группыButton
            // 
            this.группыButton.Location = new System.Drawing.Point(12, 69);
            this.группыButton.Name = "группыButton";
            this.группыButton.Size = new System.Drawing.Size(228, 23);
            this.группыButton.TabIndex = 2;
            this.группыButton.Text = "Группы и потоки";
            this.группыButton.UseVisualStyleBackColor = true;
            this.группыButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // учебныйПланButton
            // 
            this.учебныйПланButton.Location = new System.Drawing.Point(12, 98);
            this.учебныйПланButton.Name = "учебныйПланButton";
            this.учебныйПланButton.Size = new System.Drawing.Size(228, 23);
            this.учебныйПланButton.TabIndex = 3;
            this.учебныйПланButton.Text = "Учебный план";
            this.учебныйПланButton.UseVisualStyleBackColor = true;
            this.учебныйПланButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // общаяНагрузкаButton
            // 
            this.общаяНагрузкаButton.Location = new System.Drawing.Point(6, 19);
            this.общаяНагрузкаButton.Name = "общаяНагрузкаButton";
            this.общаяНагрузкаButton.Size = new System.Drawing.Size(216, 23);
            this.общаяНагрузкаButton.TabIndex = 4;
            this.общаяНагрузкаButton.Text = "Академсоветники";
            this.общаяНагрузкаButton.UseVisualStyleBackColor = true;
            this.общаяНагрузкаButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.общаяНагрузкаButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчеты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчет по";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Сформировать отчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.всеПреподавателиХПBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_преподавателя";
            // 
            // всеПреподавателиХПBindingSource
            // 
            this.всеПреподавателиХПBindingSource.DataMember = "ВсеПреподаватели_ХП";
            this.всеПреподавателиХПBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Нагрузка кафедры";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Справочники";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // всепреподавателипоказатьХПBindingSource
            // 
            this.всепреподавателипоказатьХПBindingSource.DataMember = "Все_преподаватели_показать_ХП";
            this.всепреподавателипоказатьХПBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // все_преподаватели_показать_ХПTableAdapter
            // 
            this.все_преподаватели_показать_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // всеПреподаватели_ХПTableAdapter
            // 
            this.всеПреподаватели_ХПTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Пересчитать нагрузку кафедры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.учебныйПланButton);
            this.Controls.Add(this.группыButton);
            this.Controls.Add(this.преподавателиButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.всеПреподавателиХПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.всепреподавателипоказатьХПBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button преподавателиButton;
        private System.Windows.Forms.Button группыButton;
        private System.Windows.Forms.Button учебныйПланButton;
        private System.Windows.Forms.Button общаяНагрузкаButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.BindingSource всепреподавателипоказатьХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.Все_преподаватели_показать_ХПTableAdapter все_преподаватели_показать_ХПTableAdapter;
        private System.Windows.Forms.BindingSource всеПреподавателиХПBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.ВсеПреподаватели_ХПTableAdapter всеПреподаватели_ХПTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

