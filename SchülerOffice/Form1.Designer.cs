namespace SchülerOffice
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox_tools = new System.Windows.Forms.GroupBox();
            this.button_markUtils = new System.Windows.Forms.Button();
            this.treeView_mark = new System.Windows.Forms.TreeView();
            this.button_mark_deleteClass = new System.Windows.Forms.Button();
            this.button_mark_addClass = new System.Windows.Forms.Button();
            this.groupBox_mark_newMark = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_mark_clear = new System.Windows.Forms.Button();
            this.comboBox_mark_classes = new System.Windows.Forms.ComboBox();
            this.label_mark_class = new System.Windows.Forms.Label();
            this.dateTimePicker_mark = new System.Windows.Forms.DateTimePicker();
            this.button_mark_calculateMark = new System.Windows.Forms.Button();
            this.label_mark_markDate = new System.Windows.Forms.Label();
            this.textBox_mark_note = new System.Windows.Forms.TextBox();
            this.label_mark_markNote = new System.Windows.Forms.Label();
            this.textBox_mark_name = new System.Windows.Forms.TextBox();
            this.label_mark_markName = new System.Windows.Forms.Label();
            this.button_mark_add = new System.Windows.Forms.Button();
            this.textBox_mark_mpoints = new System.Windows.Forms.TextBox();
            this.textBox_mark_points = new System.Windows.Forms.TextBox();
            this.label_mark_markPoints = new System.Windows.Forms.Label();
            this.textBox_mark_mark = new System.Windows.Forms.TextBox();
            this.label_mark_mark = new System.Windows.Forms.Label();
            this.label_mark_classes = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button_homework_add = new System.Windows.Forms.Button();
            this.button_homework_remove = new System.Windows.Forms.Button();
            this.checkedListBox_homework = new System.Windows.Forms.CheckedListBox();
            this.label_week = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_timetable_save = new System.Windows.Forms.Button();
            this.button_timetable_cancel = new System.Windows.Forms.Button();
            this.dataGridView_timeTable = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_wed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_tools.SuspendLayout();
            this.groupBox_mark_newMark.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timeTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Debug 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Debug 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox_tools);
            this.tabPage2.Controls.Add(this.treeView_mark);
            this.tabPage2.Controls.Add(this.button_mark_deleteClass);
            this.tabPage2.Controls.Add(this.button_mark_addClass);
            this.tabPage2.Controls.Add(this.groupBox_mark_newMark);
            this.tabPage2.Controls.Add(this.label_mark_classes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Noten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox_tools
            // 
            this.groupBox_tools.Controls.Add(this.button_markUtils);
            this.groupBox_tools.Location = new System.Drawing.Point(555, 12);
            this.groupBox_tools.Name = "groupBox_tools";
            this.groupBox_tools.Size = new System.Drawing.Size(217, 385);
            this.groupBox_tools.TabIndex = 9;
            this.groupBox_tools.TabStop = false;
            this.groupBox_tools.Text = "Extras";
            // 
            // button_markUtils
            // 
            this.button_markUtils.Location = new System.Drawing.Point(6, 19);
            this.button_markUtils.Name = "button_markUtils";
            this.button_markUtils.Size = new System.Drawing.Size(205, 23);
            this.button_markUtils.TabIndex = 0;
            this.button_markUtils.Text = "Fachübersicht";
            this.button_markUtils.UseVisualStyleBackColor = true;
            // 
            // treeView_mark
            // 
            this.treeView_mark.Location = new System.Drawing.Point(11, 28);
            this.treeView_mark.Name = "treeView_mark";
            this.treeView_mark.ShowNodeToolTips = true;
            this.treeView_mark.Size = new System.Drawing.Size(177, 312);
            this.treeView_mark.TabIndex = 8;
            this.treeView_mark.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_mark_AfterSelect);
            this.treeView_mark.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_mark_AfterNodeDoubleClick);
            // 
            // button_mark_deleteClass
            // 
            this.button_mark_deleteClass.Location = new System.Drawing.Point(8, 375);
            this.button_mark_deleteClass.Name = "button_mark_deleteClass";
            this.button_mark_deleteClass.Size = new System.Drawing.Size(180, 23);
            this.button_mark_deleteClass.TabIndex = 7;
            this.button_mark_deleteClass.Text = "Entfernen";
            this.button_mark_deleteClass.UseVisualStyleBackColor = true;
            this.button_mark_deleteClass.Click += new System.EventHandler(this.button_mark_deleteClass_Click);
            // 
            // button_mark_addClass
            // 
            this.button_mark_addClass.Location = new System.Drawing.Point(8, 346);
            this.button_mark_addClass.Name = "button_mark_addClass";
            this.button_mark_addClass.Size = new System.Drawing.Size(180, 23);
            this.button_mark_addClass.TabIndex = 6;
            this.button_mark_addClass.Text = "Hinzufügen";
            this.button_mark_addClass.UseVisualStyleBackColor = true;
            this.button_mark_addClass.Click += new System.EventHandler(this.button_mark_addClass_Click);
            // 
            // groupBox_mark_newMark
            // 
            this.groupBox_mark_newMark.Controls.Add(this.comboBox1);
            this.groupBox_mark_newMark.Controls.Add(this.button_mark_clear);
            this.groupBox_mark_newMark.Controls.Add(this.comboBox_mark_classes);
            this.groupBox_mark_newMark.Controls.Add(this.label_mark_class);
            this.groupBox_mark_newMark.Controls.Add(this.dateTimePicker_mark);
            this.groupBox_mark_newMark.Controls.Add(this.button_mark_calculateMark);
            this.groupBox_mark_newMark.Controls.Add(this.label_mark_markDate);
            this.groupBox_mark_newMark.Controls.Add(this.textBox_mark_note);
            this.groupBox_mark_newMark.Controls.Add(this.label_mark_markNote);
            this.groupBox_mark_newMark.Controls.Add(this.textBox_mark_name);
            this.groupBox_mark_newMark.Controls.Add(this.label_mark_markName);
            this.groupBox_mark_newMark.Controls.Add(this.button_mark_add);
            this.groupBox_mark_newMark.Controls.Add(this.textBox_mark_mpoints);
            this.groupBox_mark_newMark.Controls.Add(this.textBox_mark_points);
            this.groupBox_mark_newMark.Controls.Add(this.label_mark_markPoints);
            this.groupBox_mark_newMark.Controls.Add(this.textBox_mark_mark);
            this.groupBox_mark_newMark.Controls.Add(this.label_mark_mark);
            this.groupBox_mark_newMark.Location = new System.Drawing.Point(194, 12);
            this.groupBox_mark_newMark.Name = "groupBox_mark_newMark";
            this.groupBox_mark_newMark.Size = new System.Drawing.Size(355, 386);
            this.groupBox_mark_newMark.TabIndex = 2;
            this.groupBox_mark_newMark.TabStop = false;
            this.groupBox_mark_newMark.Text = "Neue Note";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.25x",
            "0.5x",
            "1x",
            "2x",
            "3x",
            "4x"});
            this.comboBox1.Location = new System.Drawing.Point(210, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(50, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "1x";
            // 
            // button_mark_clear
            // 
            this.button_mark_clear.Location = new System.Drawing.Point(181, 184);
            this.button_mark_clear.Name = "button_mark_clear";
            this.button_mark_clear.Size = new System.Drawing.Size(83, 23);
            this.button_mark_clear.TabIndex = 15;
            this.button_mark_clear.Text = "Zurücksetzen";
            this.button_mark_clear.UseVisualStyleBackColor = true;
            this.button_mark_clear.Click += new System.EventHandler(this.button_mark_clear_Click);
            // 
            // comboBox_mark_classes
            // 
            this.comboBox_mark_classes.Location = new System.Drawing.Point(124, 119);
            this.comboBox_mark_classes.Name = "comboBox_mark_classes";
            this.comboBox_mark_classes.Size = new System.Drawing.Size(136, 21);
            this.comboBox_mark_classes.TabIndex = 14;
            // 
            // label_mark_class
            // 
            this.label_mark_class.AutoSize = true;
            this.label_mark_class.Location = new System.Drawing.Point(6, 122);
            this.label_mark_class.Name = "label_mark_class";
            this.label_mark_class.Size = new System.Drawing.Size(31, 13);
            this.label_mark_class.TabIndex = 13;
            this.label_mark_class.Text = "Fach";
            // 
            // dateTimePicker_mark
            // 
            this.dateTimePicker_mark.Location = new System.Drawing.Point(124, 42);
            this.dateTimePicker_mark.Name = "dateTimePicker_mark";
            this.dateTimePicker_mark.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_mark.TabIndex = 9;
            // 
            // button_mark_calculateMark
            // 
            this.button_mark_calculateMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mark_calculateMark.Location = new System.Drawing.Point(270, 64);
            this.button_mark_calculateMark.Name = "button_mark_calculateMark";
            this.button_mark_calculateMark.Size = new System.Drawing.Size(75, 49);
            this.button_mark_calculateMark.TabIndex = 12;
            this.button_mark_calculateMark.Text = "Note Linear berechnen";
            this.button_mark_calculateMark.UseVisualStyleBackColor = true;
            this.button_mark_calculateMark.Click += new System.EventHandler(this.button_mark_calculateMark_Click);
            // 
            // label_mark_markDate
            // 
            this.label_mark_markDate.AutoSize = true;
            this.label_mark_markDate.Location = new System.Drawing.Point(6, 44);
            this.label_mark_markDate.Name = "label_mark_markDate";
            this.label_mark_markDate.Size = new System.Drawing.Size(41, 13);
            this.label_mark_markDate.TabIndex = 10;
            this.label_mark_markDate.Text = "Datum:";
            // 
            // textBox_mark_note
            // 
            this.textBox_mark_note.Location = new System.Drawing.Point(6, 213);
            this.textBox_mark_note.Multiline = true;
            this.textBox_mark_note.Name = "textBox_mark_note";
            this.textBox_mark_note.Size = new System.Drawing.Size(339, 167);
            this.textBox_mark_note.TabIndex = 9;
            // 
            // label_mark_markNote
            // 
            this.label_mark_markNote.AutoSize = true;
            this.label_mark_markNote.Location = new System.Drawing.Point(3, 197);
            this.label_mark_markNote.Name = "label_mark_markNote";
            this.label_mark_markNote.Size = new System.Drawing.Size(64, 13);
            this.label_mark_markNote.TabIndex = 8;
            this.label_mark_markNote.Text = "Bemerkung:";
            // 
            // textBox_mark_name
            // 
            this.textBox_mark_name.Location = new System.Drawing.Point(124, 16);
            this.textBox_mark_name.Name = "textBox_mark_name";
            this.textBox_mark_name.Size = new System.Drawing.Size(224, 20);
            this.textBox_mark_name.TabIndex = 7;
            // 
            // label_mark_markName
            // 
            this.label_mark_markName.AutoSize = true;
            this.label_mark_markName.Location = new System.Drawing.Point(6, 19);
            this.label_mark_markName.Name = "label_mark_markName";
            this.label_mark_markName.Size = new System.Drawing.Size(38, 13);
            this.label_mark_markName.TabIndex = 6;
            this.label_mark_markName.Text = "Name:";
            // 
            // button_mark_add
            // 
            this.button_mark_add.Location = new System.Drawing.Point(270, 184);
            this.button_mark_add.Name = "button_mark_add";
            this.button_mark_add.Size = new System.Drawing.Size(75, 23);
            this.button_mark_add.TabIndex = 5;
            this.button_mark_add.Text = "Hinzufügen";
            this.button_mark_add.UseVisualStyleBackColor = true;
            this.button_mark_add.Click += new System.EventHandler(this.button_mark_add_Click);
            // 
            // textBox_mark_mpoints
            // 
            this.textBox_mark_mpoints.Location = new System.Drawing.Point(210, 93);
            this.textBox_mark_mpoints.Name = "textBox_mark_mpoints";
            this.textBox_mark_mpoints.Size = new System.Drawing.Size(50, 20);
            this.textBox_mark_mpoints.TabIndex = 4;
            // 
            // textBox_mark_points
            // 
            this.textBox_mark_points.Location = new System.Drawing.Point(154, 93);
            this.textBox_mark_points.Name = "textBox_mark_points";
            this.textBox_mark_points.Size = new System.Drawing.Size(50, 20);
            this.textBox_mark_points.TabIndex = 3;
            // 
            // label_mark_markPoints
            // 
            this.label_mark_markPoints.AutoSize = true;
            this.label_mark_markPoints.Location = new System.Drawing.Point(6, 96);
            this.label_mark_markPoints.Name = "label_mark_markPoints";
            this.label_mark_markPoints.Size = new System.Drawing.Size(132, 13);
            this.label_mark_markPoints.TabIndex = 2;
            this.label_mark_markPoints.Text = "Punkte / Punktemaximum:";
            // 
            // textBox_mark_mark
            // 
            this.textBox_mark_mark.Location = new System.Drawing.Point(154, 67);
            this.textBox_mark_mark.Name = "textBox_mark_mark";
            this.textBox_mark_mark.Size = new System.Drawing.Size(50, 20);
            this.textBox_mark_mark.TabIndex = 1;
            // 
            // label_mark_mark
            // 
            this.label_mark_mark.AutoSize = true;
            this.label_mark_mark.Location = new System.Drawing.Point(6, 70);
            this.label_mark_mark.Name = "label_mark_mark";
            this.label_mark_mark.Size = new System.Drawing.Size(33, 13);
            this.label_mark_mark.TabIndex = 0;
            this.label_mark_mark.Text = "Note:";
            // 
            // label_mark_classes
            // 
            this.label_mark_classes.AutoSize = true;
            this.label_mark_classes.Location = new System.Drawing.Point(8, 12);
            this.label_mark_classes.Name = "label_mark_classes";
            this.label_mark_classes.Size = new System.Drawing.Size(40, 13);
            this.label_mark_classes.TabIndex = 1;
            this.label_mark_classes.Text = "Fächer";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button_homework_add);
            this.tabPage3.Controls.Add(this.button_homework_remove);
            this.tabPage3.Controls.Add(this.checkedListBox_homework);
            this.tabPage3.Controls.Add(this.label_week);
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.button_timetable_save);
            this.tabPage3.Controls.Add(this.button_timetable_cancel);
            this.tabPage3.Controls.Add(this.dataGridView_timeTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hausaufgaben";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_homework_add
            // 
            this.button_homework_add.Location = new System.Drawing.Point(582, 345);
            this.button_homework_add.Name = "button_homework_add";
            this.button_homework_add.Size = new System.Drawing.Size(190, 23);
            this.button_homework_add.TabIndex = 9;
            this.button_homework_add.Text = "Hausaufgabe Hinzufügen";
            this.button_homework_add.UseVisualStyleBackColor = true;
            this.button_homework_add.Click += new System.EventHandler(this.button_homework_add_Click);
            // 
            // button_homework_remove
            // 
            this.button_homework_remove.Location = new System.Drawing.Point(582, 374);
            this.button_homework_remove.Name = "button_homework_remove";
            this.button_homework_remove.Size = new System.Drawing.Size(190, 23);
            this.button_homework_remove.TabIndex = 8;
            this.button_homework_remove.Text = "Hausaufgabe Löschen";
            this.button_homework_remove.UseVisualStyleBackColor = true;
            this.button_homework_remove.Click += new System.EventHandler(this.button_homework_remove_Click);
            // 
            // checkedListBox_homework
            // 
            this.checkedListBox_homework.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_homework.FormattingEnabled = true;
            this.checkedListBox_homework.Location = new System.Drawing.Point(582, 27);
            this.checkedListBox_homework.Name = "checkedListBox_homework";
            this.checkedListBox_homework.Size = new System.Drawing.Size(190, 375);
            this.checkedListBox_homework.TabIndex = 7;
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Location = new System.Drawing.Point(209, 9);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(48, 13);
            this.label_week.TabIndex = 5;
            this.label_week.Text = "Woche: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button_timetable_save
            // 
            this.button_timetable_save.Enabled = false;
            this.button_timetable_save.Location = new System.Drawing.Point(89, 374);
            this.button_timetable_save.Name = "button_timetable_save";
            this.button_timetable_save.Size = new System.Drawing.Size(75, 23);
            this.button_timetable_save.TabIndex = 3;
            this.button_timetable_save.Text = "Speichern";
            this.button_timetable_save.UseVisualStyleBackColor = true;
            this.button_timetable_save.Click += new System.EventHandler(this.button_timetable_save_Click);
            // 
            // button_timetable_cancel
            // 
            this.button_timetable_cancel.Enabled = false;
            this.button_timetable_cancel.Location = new System.Drawing.Point(8, 374);
            this.button_timetable_cancel.Name = "button_timetable_cancel";
            this.button_timetable_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_timetable_cancel.TabIndex = 2;
            this.button_timetable_cancel.Text = "Verwerfen";
            this.button_timetable_cancel.UseVisualStyleBackColor = true;
            this.button_timetable_cancel.Click += new System.EventHandler(this.button_timetable_cancel_Click);
            // 
            // dataGridView_timeTable
            // 
            this.dataGridView_timeTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_timeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_timeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_timeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime,
            this.column_mon,
            this.Column_tue,
            this.Column_wed,
            this.Column_thu,
            this.Column_fri});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_timeTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_timeTable.Location = new System.Drawing.Point(8, 27);
            this.dataGridView_timeTable.MultiSelect = false;
            this.dataGridView_timeTable.Name = "dataGridView_timeTable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_timeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_timeTable.RowHeadersVisible = false;
            this.dataGridView_timeTable.Size = new System.Drawing.Size(568, 341);
            this.dataGridView_timeTable.TabIndex = 0;
            this.dataGridView_timeTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView_timeTable_CellChanged);
            // 
            // colTime
            // 
            this.colTime.HeaderText = "Time:";
            this.colTime.Name = "colTime";
            this.colTime.Width = 65;
            // 
            // column_mon
            // 
            this.column_mon.HeaderText = "Montag";
            this.column_mon.Name = "column_mon";
            // 
            // Column_tue
            // 
            this.Column_tue.HeaderText = "Dienstag";
            this.Column_tue.Name = "Column_tue";
            // 
            // Column_wed
            // 
            this.Column_wed.HeaderText = "Mittwoch";
            this.Column_wed.Name = "Column_wed";
            // 
            // Column_thu
            // 
            this.Column_thu.HeaderText = "Donnerstag";
            this.Column_thu.Name = "Column_thu";
            // 
            // Column_fri
            // 
            this.Column_fri.HeaderText = "Freitag";
            this.Column_fri.Name = "Column_fri";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.treeView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Voci-Trainer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(175, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Alles anzeigen";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Prüfen";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Lernen!";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(175, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Löschen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Editieren";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Neu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(166, 394);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 431);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(804, 469);
            this.MinimumSize = new System.Drawing.Size(804, 469);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox_tools.ResumeLayout(false);
            this.groupBox_mark_newMark.ResumeLayout(false);
            this.groupBox_mark_newMark.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timeTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_mark_classes;
        private System.Windows.Forms.GroupBox groupBox_mark_newMark;
        private System.Windows.Forms.Button button_mark_add;
        private System.Windows.Forms.TextBox textBox_mark_mpoints;
        private System.Windows.Forms.TextBox textBox_mark_points;
        private System.Windows.Forms.Label label_mark_markPoints;
        private System.Windows.Forms.TextBox textBox_mark_mark;
        private System.Windows.Forms.Label label_mark_mark;
        private System.Windows.Forms.TextBox textBox_mark_note;
        private System.Windows.Forms.Label label_mark_markNote;
        private System.Windows.Forms.TextBox textBox_mark_name;
        private System.Windows.Forms.Label label_mark_markName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_mark_deleteClass;
        private System.Windows.Forms.Button button_mark_addClass;
        private System.Windows.Forms.Button button_mark_calculateMark;
        private System.Windows.Forms.Label label_mark_markDate;
        private System.Windows.Forms.TreeView treeView_mark;
        private System.Windows.Forms.DateTimePicker dateTimePicker_mark;
        private System.Windows.Forms.ComboBox comboBox_mark_classes;
        private System.Windows.Forms.Label label_mark_class;
        private System.Windows.Forms.Button button_mark_clear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_tools;
        private System.Windows.Forms.Button button_markUtils;
        private System.Windows.Forms.DataGridView dataGridView_timeTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_wed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_fri;
        private System.Windows.Forms.Button button_timetable_save;
        private System.Windows.Forms.Button button_timetable_cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.CheckedListBox checkedListBox_homework;
        private System.Windows.Forms.Button button_homework_add;
        private System.Windows.Forms.Button button_homework_remove;
    }
}

