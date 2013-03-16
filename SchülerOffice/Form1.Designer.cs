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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_mark_deleteMark = new System.Windows.Forms.Button();
            this.button_mark_deleteClass = new System.Windows.Forms.Button();
            this.button_mark_addClass = new System.Windows.Forms.Button();
            this.listBox_mark_marks = new System.Windows.Forms.ListBox();
            this.label_mark_marks = new System.Windows.Forms.Label();
            this.groupBox_mark_newMark = new System.Windows.Forms.GroupBox();
            this.monthCalendar_mark_date = new System.Windows.Forms.MonthCalendar();
            this.button_mark_calculateMark = new System.Windows.Forms.Button();
            this.textBox_mark_date = new System.Windows.Forms.TextBox();
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
            this.listBox_mark_classes = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_mark_newMark.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(749, 431);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_mark_deleteMark);
            this.tabPage2.Controls.Add(this.button_mark_deleteClass);
            this.tabPage2.Controls.Add(this.button_mark_addClass);
            this.tabPage2.Controls.Add(this.listBox_mark_marks);
            this.tabPage2.Controls.Add(this.label_mark_marks);
            this.tabPage2.Controls.Add(this.groupBox_mark_newMark);
            this.tabPage2.Controls.Add(this.label_mark_classes);
            this.tabPage2.Controls.Add(this.listBox_mark_classes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Noten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_mark_deleteMark
            // 
            this.button_mark_deleteMark.Location = new System.Drawing.Point(555, 375);
            this.button_mark_deleteMark.Name = "button_mark_deleteMark";
            this.button_mark_deleteMark.Size = new System.Drawing.Size(180, 23);
            this.button_mark_deleteMark.TabIndex = 8;
            this.button_mark_deleteMark.Text = "Entfernen";
            this.button_mark_deleteMark.UseVisualStyleBackColor = true;
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
            // listBox_mark_marks
            // 
            this.listBox_mark_marks.FormattingEnabled = true;
            this.listBox_mark_marks.Location = new System.Drawing.Point(555, 28);
            this.listBox_mark_marks.Name = "listBox_mark_marks";
            this.listBox_mark_marks.Size = new System.Drawing.Size(180, 342);
            this.listBox_mark_marks.TabIndex = 5;
            // 
            // label_mark_marks
            // 
            this.label_mark_marks.AutoSize = true;
            this.label_mark_marks.Location = new System.Drawing.Point(555, 12);
            this.label_mark_marks.Name = "label_mark_marks";
            this.label_mark_marks.Size = new System.Drawing.Size(36, 13);
            this.label_mark_marks.TabIndex = 4;
            this.label_mark_marks.Text = "Noten";
            // 
            // groupBox_mark_newMark
            // 
            this.groupBox_mark_newMark.Controls.Add(this.monthCalendar_mark_date);
            this.groupBox_mark_newMark.Controls.Add(this.button_mark_calculateMark);
            this.groupBox_mark_newMark.Controls.Add(this.textBox_mark_date);
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
            // monthCalendar_mark_date
            // 
            this.monthCalendar_mark_date.Location = new System.Drawing.Point(177, 41);
            this.monthCalendar_mark_date.Name = "monthCalendar_mark_date";
            this.monthCalendar_mark_date.TabIndex = 13;
            this.monthCalendar_mark_date.Visible = false;
            this.monthCalendar_mark_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_mark_date_DateChanged);
            // 
            // button_mark_calculateMark
            // 
            this.button_mark_calculateMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mark_calculateMark.Location = new System.Drawing.Point(270, 91);
            this.button_mark_calculateMark.Name = "button_mark_calculateMark";
            this.button_mark_calculateMark.Size = new System.Drawing.Size(75, 23);
            this.button_mark_calculateMark.TabIndex = 12;
            this.button_mark_calculateMark.Text = "Note Linear \r\nberechnen";
            this.button_mark_calculateMark.UseVisualStyleBackColor = true;
            this.button_mark_calculateMark.Click += new System.EventHandler(this.button_mark_calculateMark_Click);
            // 
            // textBox_mark_date
            // 
            this.textBox_mark_date.Location = new System.Drawing.Point(124, 41);
            this.textBox_mark_date.Name = "textBox_mark_date";
            this.textBox_mark_date.Size = new System.Drawing.Size(224, 20);
            this.textBox_mark_date.TabIndex = 11;
            this.textBox_mark_date.Click += new System.EventHandler(this.textBox_mark_date_Click);
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
            // listBox_mark_classes
            // 
            this.listBox_mark_classes.FormattingEnabled = true;
            this.listBox_mark_classes.Location = new System.Drawing.Point(8, 28);
            this.listBox_mark_classes.Name = "listBox_mark_classes";
            this.listBox_mark_classes.Size = new System.Drawing.Size(180, 316);
            this.listBox_mark_classes.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(741, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hausaufgaben";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(741, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Voci-Trainer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 431);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox_mark_newMark.ResumeLayout(false);
            this.groupBox_mark_newMark.PerformLayout();
            this.ResumeLayout(false);
            /*
            this.label_mark_classes.Text = Data.lang.classes;
            this.label_mark_marks.Text = Data.lang.marks;
            this.label_mark_mark.Text = Data.lang.mark;
            this.label_mark_markDate.Text = Data.lang.markDate;
            this.label_mark_markName.Text = Data.lang.markName;
            this.label_mark_markNote.Text = Data.lang.markNote;
            this.label_mark_markPoints.Text = Data.lang.markPoints;
            this.groupbox_mark_newMark.Text = Data.lang.newMark;
             */

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_mark_classes;
        private System.Windows.Forms.ListBox listBox_mark_classes;
        private System.Windows.Forms.GroupBox groupBox_mark_newMark;
        private System.Windows.Forms.Button button_mark_add;
        private System.Windows.Forms.TextBox textBox_mark_mpoints;
        private System.Windows.Forms.TextBox textBox_mark_points;
        private System.Windows.Forms.Label label_mark_markPoints;
        private System.Windows.Forms.TextBox textBox_mark_mark;
        private System.Windows.Forms.Label label_mark_mark;
        private System.Windows.Forms.ListBox listBox_mark_marks;
        private System.Windows.Forms.Label label_mark_marks;
        private System.Windows.Forms.TextBox textBox_mark_note;
        private System.Windows.Forms.Label label_mark_markNote;
        private System.Windows.Forms.TextBox textBox_mark_name;
        private System.Windows.Forms.Label label_mark_markName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button_mark_deleteClass;
        private System.Windows.Forms.Button button_mark_addClass;
        private System.Windows.Forms.Button button_mark_calculateMark;
        private System.Windows.Forms.TextBox textBox_mark_date;
        private System.Windows.Forms.Label label_mark_markDate;
        private System.Windows.Forms.Button button_mark_deleteMark;
        private System.Windows.Forms.MonthCalendar monthCalendar_mark_date;
    }
}

