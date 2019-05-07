namespace Распределение_нагрузки
{
    partial class Предметы
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКФайлуButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сохранитьButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.дистантникиRadioButton = new System.Windows.Forms.RadioButton();
            this.магистрыRadioButton = new System.Windows.Forms.RadioButton();
            this.бакалаврыRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ИБRB = new System.Windows.Forms.RadioButton();
            this.ПИRB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.курсComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.направлениеComboBox = new System.Windows.Forms.ComboBox();
            this.направленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet1 = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.важностьComboBox = new System.Windows.Forms.ComboBox();
            this.важностьпредметаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.распределениеНагрузкиDataSet = new Распределение_нагрузки.РаспределениеНагрузкиDataSet();
            this.уровеньПодготовкиComboBox = new System.Windows.Forms.ComboBox();
            this.уровниподготовкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.уровни_подготовкиTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.Уровни_подготовкиTableAdapter();
            this.важность_предметаTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.Важность_предметаTableAdapter();
            this.направленияTableAdapter = new Распределение_нагрузки.РаспределениеНагрузкиDataSetTableAdapters.НаправленияTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.направленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.важностьпредметаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.уровниподготовкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 24);
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
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.справкаToolStripMenuItem.Text = "Помощь";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // путьКФайлуButton
            // 
            this.путьКФайлуButton.Location = new System.Drawing.Point(401, 70);
            this.путьКФайлуButton.Name = "путьКФайлуButton";
            this.путьКФайлуButton.Size = new System.Drawing.Size(114, 23);
            this.путьКФайлуButton.TabIndex = 2;
            this.путьКФайлуButton.Text = "Выбрать файл";
            this.путьКФайлуButton.UseVisualStyleBackColor = true;
            this.путьКФайлуButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1428, 586);
            this.dataGridView1.TabIndex = 3;
            // 
            // сохранитьButton
            // 
            this.сохранитьButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.сохранитьButton.Enabled = false;
            this.сохранитьButton.Location = new System.Drawing.Point(1284, 69);
            this.сохранитьButton.Name = "сохранитьButton";
            this.сохранитьButton.Size = new System.Drawing.Size(154, 23);
            this.сохранитьButton.TabIndex = 4;
            this.сохранитьButton.Text = "Сохранить в базе данных";
            this.сохранитьButton.UseVisualStyleBackColor = true;
            this.сохранитьButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(10, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.дистантникиRadioButton);
            this.groupBox1.Controls.Add(this.магистрыRadioButton);
            this.groupBox1.Controls.Add(this.бакалаврыRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Уровень подготовки";
            // 
            // дистантникиRadioButton
            // 
            this.дистантникиRadioButton.AutoSize = true;
            this.дистантникиRadioButton.Location = new System.Drawing.Point(94, 19);
            this.дистантникиRadioButton.Name = "дистантникиRadioButton";
            this.дистантникиRadioButton.Size = new System.Drawing.Size(149, 17);
            this.дистантникиRadioButton.TabIndex = 2;
            this.дистантникиRadioButton.TabStop = true;
            this.дистантникиRadioButton.Text = "Бакалавры-дистантники";
            this.дистантникиRadioButton.UseVisualStyleBackColor = true;
            // 
            // магистрыRadioButton
            // 
            this.магистрыRadioButton.AutoSize = true;
            this.магистрыRadioButton.Location = new System.Drawing.Point(249, 19);
            this.магистрыRadioButton.Name = "магистрыRadioButton";
            this.магистрыRadioButton.Size = new System.Drawing.Size(76, 17);
            this.магистрыRadioButton.TabIndex = 1;
            this.магистрыRadioButton.TabStop = true;
            this.магистрыRadioButton.Text = "Магистры";
            this.магистрыRadioButton.UseVisualStyleBackColor = true;
            // 
            // бакалаврыRadioButton
            // 
            this.бакалаврыRadioButton.AutoSize = true;
            this.бакалаврыRadioButton.Location = new System.Drawing.Point(6, 19);
            this.бакалаврыRadioButton.Name = "бакалаврыRadioButton";
            this.бакалаврыRadioButton.Size = new System.Drawing.Size(82, 17);
            this.бакалаврыRadioButton.TabIndex = 0;
            this.бакалаврыRadioButton.TabStop = true;
            this.бакалаврыRadioButton.Text = "Бакалавры";
            this.бакалаврыRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ИБRB);
            this.groupBox2.Controls.Add(this.ПИRB);
            this.groupBox2.Location = new System.Drawing.Point(343, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Направление";
            // 
            // ИБRB
            // 
            this.ИБRB.AutoSize = true;
            this.ИБRB.Location = new System.Drawing.Point(163, 19);
            this.ИБRB.Name = "ИБRB";
            this.ИБRB.Size = new System.Drawing.Size(189, 17);
            this.ИБRB.TabIndex = 1;
            this.ИБRB.TabStop = true;
            this.ИБRB.Text = "Информационная безопасность";
            this.ИБRB.UseVisualStyleBackColor = true;
            // 
            // ПИRB
            // 
            this.ПИRB.AutoSize = true;
            this.ПИRB.Location = new System.Drawing.Point(6, 19);
            this.ПИRB.Name = "ПИRB";
            this.ПИRB.Size = new System.Drawing.Size(155, 17);
            this.ПИRB.TabIndex = 0;
            this.ПИRB.TabStop = true;
            this.ПИRB.Text = "Программная инженерия";
            this.ПИRB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.сохранитьButton);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.путьКФайлуButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1444, 103);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Внести учебный план";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.курсComboBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.направлениеComboBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.важностьComboBox);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.уровеньПодготовкиComboBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1444, 644);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Показать учебный план";
            // 
            // курсComboBox
            // 
            this.курсComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.курсComboBox.FormattingEnabled = true;
            this.курсComboBox.Location = new System.Drawing.Point(955, 19);
            this.курсComboBox.Name = "курсComboBox";
            this.курсComboBox.Size = new System.Drawing.Size(36, 21);
            this.курсComboBox.TabIndex = 7;
            this.курсComboBox.SelectedIndexChanged += new System.EventHandler(this.курсComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(918, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Курс";
            // 
            // направлениеComboBox
            // 
            this.направлениеComboBox.DataSource = this.направленияBindingSource;
            this.направлениеComboBox.DisplayMember = "Направление";
            this.направлениеComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.направлениеComboBox.FormattingEnabled = true;
            this.направлениеComboBox.Location = new System.Drawing.Point(343, 19);
            this.направлениеComboBox.Name = "направлениеComboBox";
            this.направлениеComboBox.Size = new System.Drawing.Size(199, 21);
            this.направлениеComboBox.TabIndex = 5;
            this.направлениеComboBox.ValueMember = "ID";
            this.направлениеComboBox.SelectedIndexChanged += new System.EventHandler(this.направлениеComboBox_SelectedIndexChanged);
            // 
            // направленияBindingSource
            // 
            this.направленияBindingSource.DataMember = "Направления";
            this.направленияBindingSource.DataSource = this.распределениеНагрузкиDataSet1;
            // 
            // распределениеНагрузкиDataSet1
            // 
            this.распределениеНагрузкиDataSet1.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Направление";
            // 
            // важностьComboBox
            // 
            this.важностьComboBox.DataSource = this.важностьпредметаBindingSource;
            this.важностьComboBox.DisplayMember = "Важность";
            this.важностьComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.важностьComboBox.FormattingEnabled = true;
            this.важностьComboBox.Location = new System.Drawing.Point(739, 19);
            this.важностьComboBox.Name = "важностьComboBox";
            this.важностьComboBox.Size = new System.Drawing.Size(173, 21);
            this.важностьComboBox.TabIndex = 3;
            this.важностьComboBox.ValueMember = "ID";
            this.важностьComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // важностьпредметаBindingSource
            // 
            this.важностьпредметаBindingSource.DataMember = "Важность_предмета";
            this.важностьпредметаBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // распределениеНагрузкиDataSet
            // 
            this.распределениеНагрузкиDataSet.DataSetName = "РаспределениеНагрузкиDataSet";
            this.распределениеНагрузкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // уровеньПодготовкиComboBox
            // 
            this.уровеньПодготовкиComboBox.DataSource = this.уровниподготовкиBindingSource;
            this.уровеньПодготовкиComboBox.DisplayMember = "Уровень_подготовки";
            this.уровеньПодготовкиComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.уровеньПодготовкиComboBox.FormattingEnabled = true;
            this.уровеньПодготовкиComboBox.Location = new System.Drawing.Point(80, 19);
            this.уровеньПодготовкиComboBox.Name = "уровеньПодготовкиComboBox";
            this.уровеньПодготовкиComboBox.Size = new System.Drawing.Size(173, 21);
            this.уровеньПодготовкиComboBox.TabIndex = 2;
            this.уровеньПодготовкиComboBox.ValueMember = "ID";
            this.уровеньПодготовкиComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // уровниподготовкиBindingSource
            // 
            this.уровниподготовкиBindingSource.DataMember = "Уровни_подготовки";
            this.уровниподготовкиBindingSource.DataSource = this.распределениеНагрузкиDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Обязательный/КПВ/Факультатив";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подготовка";
            // 
            // уровни_подготовкиTableAdapter
            // 
            this.уровни_подготовкиTableAdapter.ClearBeforeFill = true;
            // 
            // важность_предметаTableAdapter
            // 
            this.важность_предметаTableAdapter.ClearBeforeFill = true;
            // 
            // направленияTableAdapter
            // 
            this.направленияTableAdapter.ClearBeforeFill = true;
            // 
            // Предметы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 792);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Предметы";
            this.Text = "Учебный план";
            this.Load += new System.EventHandler(this.Предметы_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.направленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.важностьпредметаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.распределениеНагрузкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.уровниподготовкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button путьКФайлуButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button сохранитьButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton дистантникиRadioButton;
        private System.Windows.Forms.RadioButton магистрыRadioButton;
        private System.Windows.Forms.RadioButton бакалаврыRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ИБRB;
        private System.Windows.Forms.RadioButton ПИRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox важностьComboBox;
        private System.Windows.Forms.ComboBox уровеньПодготовкиComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet;
        private System.Windows.Forms.BindingSource уровниподготовкиBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.Уровни_подготовкиTableAdapter уровни_подготовкиTableAdapter;
        private System.Windows.Forms.BindingSource важностьпредметаBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.Важность_предметаTableAdapter важность_предметаTableAdapter;
        private System.Windows.Forms.ComboBox направлениеComboBox;
        private System.Windows.Forms.Label label3;
        private РаспределениеНагрузкиDataSet распределениеНагрузкиDataSet1;
        private System.Windows.Forms.BindingSource направленияBindingSource;
        private РаспределениеНагрузкиDataSetTableAdapters.НаправленияTableAdapter направленияTableAdapter;
        private System.Windows.Forms.ComboBox курсComboBox;
        private System.Windows.Forms.Label label4;
    }
}