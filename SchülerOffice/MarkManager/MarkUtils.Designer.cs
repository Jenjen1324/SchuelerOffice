﻿namespace SchülerOffice
{
    partial class MarkUtils
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkUtils));
            this.comboBox_classes = new System.Windows.Forms.ComboBox();
            this.chart_marks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_additionalMark = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.radioButton_aM_countsAsMark = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.radioButton_aM_countsAsPrecentage = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_calculateTargetMark = new System.Windows.Forms.GroupBox();
            this.button_calcuteTargetMark = new System.Windows.Forms.Button();
            this.textBox_requiredMark = new System.Windows.Forms.TextBox();
            this.label_requiredMark = new System.Windows.Forms.Label();
            this.textBox_targetMark = new System.Windows.Forms.TextBox();
            this.label_targetMark = new System.Windows.Forms.Label();
            this.label_averageMark = new System.Windows.Forms.Label();
            this.textBox_averageMark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_marks)).BeginInit();
            this.groupBox_calculateTargetMark.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_classes
            // 
            this.comboBox_classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_classes.FormattingEnabled = true;
            this.comboBox_classes.Location = new System.Drawing.Point(12, 12);
            this.comboBox_classes.Name = "comboBox_classes";
            this.comboBox_classes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_classes.TabIndex = 0;
            this.comboBox_classes.SelectedIndexChanged += new System.EventHandler(this.comboBox_classes_SelectedIndexChanged);
            // 
            // chart_marks
            // 
            this.chart_marks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart_marks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_marks.Legends.Add(legend1);
            this.chart_marks.Location = new System.Drawing.Point(271, 12);
            this.chart_marks.Name = "chart_marks";
            this.chart_marks.Size = new System.Drawing.Size(312, 298);
            this.chart_marks.TabIndex = 2;
            this.chart_marks.Text = "chart1";
            // 
            // checkBox_additionalMark
            // 
            this.checkBox_additionalMark.AutoSize = true;
            this.checkBox_additionalMark.Location = new System.Drawing.Point(6, 19);
            this.checkBox_additionalMark.Name = "checkBox_additionalMark";
            this.checkBox_additionalMark.Size = new System.Drawing.Size(99, 17);
            this.checkBox_additionalMark.TabIndex = 3;
            this.checkBox_additionalMark.Text = "Mündliche note";
            this.checkBox_additionalMark.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0.25x",
            "0.5x",
            "1x",
            "2x",
            "3x",
            "4x"});
            this.comboBox2.Location = new System.Drawing.Point(172, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "1x";
            // 
            // radioButton_aM_countsAsMark
            // 
            this.radioButton_aM_countsAsMark.AutoSize = true;
            this.radioButton_aM_countsAsMark.Location = new System.Drawing.Point(13, 44);
            this.radioButton_aM_countsAsMark.Name = "radioButton_aM_countsAsMark";
            this.radioButton_aM_countsAsMark.Size = new System.Drawing.Size(92, 17);
            this.radioButton_aM_countsAsMark.TabIndex = 6;
            this.radioButton_aM_countsAsMark.TabStop = true;
            this.radioButton_aM_countsAsMark.Text = "Zählt als note:";
            this.radioButton_aM_countsAsMark.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "10%",
            "20%",
            "50%"});
            this.comboBox3.Location = new System.Drawing.Point(172, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "10%";
            // 
            // radioButton_aM_countsAsPrecentage
            // 
            this.radioButton_aM_countsAsPrecentage.AutoSize = true;
            this.radioButton_aM_countsAsPrecentage.Location = new System.Drawing.Point(12, 71);
            this.radioButton_aM_countsAsPrecentage.Name = "radioButton_aM_countsAsPrecentage";
            this.radioButton_aM_countsAsPrecentage.Size = new System.Drawing.Size(154, 17);
            this.radioButton_aM_countsAsPrecentage.TabIndex = 9;
            this.radioButton_aM_countsAsPrecentage.TabStop = true;
            this.radioButton_aM_countsAsPrecentage.Text = "Zählt gegüber zeugnisnote:";
            this.radioButton_aM_countsAsPrecentage.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(25, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "-";
            // 
            // groupBox_calculateTargetMark
            // 
            this.groupBox_calculateTargetMark.Controls.Add(this.button_calcuteTargetMark);
            this.groupBox_calculateTargetMark.Controls.Add(this.textBox_requiredMark);
            this.groupBox_calculateTargetMark.Controls.Add(this.label_requiredMark);
            this.groupBox_calculateTargetMark.Controls.Add(this.textBox_targetMark);
            this.groupBox_calculateTargetMark.Controls.Add(this.label_targetMark);
            this.groupBox_calculateTargetMark.Location = new System.Drawing.Point(12, 177);
            this.groupBox_calculateTargetMark.Name = "groupBox_calculateTargetMark";
            this.groupBox_calculateTargetMark.Size = new System.Drawing.Size(240, 101);
            this.groupBox_calculateTargetMark.TabIndex = 12;
            this.groupBox_calculateTargetMark.TabStop = false;
            this.groupBox_calculateTargetMark.Text = "Zielnote berechnen";
            // 
            // button_calcuteTargetMark
            // 
            this.button_calcuteTargetMark.Location = new System.Drawing.Point(132, 45);
            this.button_calcuteTargetMark.Name = "button_calcuteTargetMark";
            this.button_calcuteTargetMark.Size = new System.Drawing.Size(97, 23);
            this.button_calcuteTargetMark.TabIndex = 16;
            this.button_calcuteTargetMark.Text = "Berechnen";
            this.button_calcuteTargetMark.UseVisualStyleBackColor = true;
            this.button_calcuteTargetMark.Click += new System.EventHandler(this.button_calcuteTargetMark_Click);
            // 
            // textBox_requiredMark
            // 
            this.textBox_requiredMark.Location = new System.Drawing.Point(132, 74);
            this.textBox_requiredMark.Name = "textBox_requiredMark";
            this.textBox_requiredMark.ReadOnly = true;
            this.textBox_requiredMark.Size = new System.Drawing.Size(97, 20);
            this.textBox_requiredMark.TabIndex = 15;
            // 
            // label_requiredMark
            // 
            this.label_requiredMark.AutoSize = true;
            this.label_requiredMark.Location = new System.Drawing.Point(6, 77);
            this.label_requiredMark.Name = "label_requiredMark";
            this.label_requiredMark.Size = new System.Drawing.Size(120, 13);
            this.label_requiredMark.TabIndex = 14;
            this.label_requiredMark.Text = "Benötigte prüfungsnote:";
            // 
            // textBox_targetMark
            // 
            this.textBox_targetMark.Location = new System.Drawing.Point(132, 19);
            this.textBox_targetMark.Name = "textBox_targetMark";
            this.textBox_targetMark.Size = new System.Drawing.Size(97, 20);
            this.textBox_targetMark.TabIndex = 13;
            // 
            // label_targetMark
            // 
            this.label_targetMark.AutoSize = true;
            this.label_targetMark.Location = new System.Drawing.Point(6, 22);
            this.label_targetMark.Name = "label_targetMark";
            this.label_targetMark.Size = new System.Drawing.Size(48, 13);
            this.label_targetMark.TabIndex = 0;
            this.label_targetMark.Text = "Zielnote:";
            // 
            // label_averageMark
            // 
            this.label_averageMark.AutoSize = true;
            this.label_averageMark.Location = new System.Drawing.Point(9, 46);
            this.label_averageMark.Name = "label_averageMark";
            this.label_averageMark.Size = new System.Drawing.Size(70, 13);
            this.label_averageMark.TabIndex = 13;
            this.label_averageMark.Text = "Durchschnitt:";
            // 
            // textBox_averageMark
            // 
            this.textBox_averageMark.Location = new System.Drawing.Point(184, 43);
            this.textBox_averageMark.Name = "textBox_averageMark";
            this.textBox_averageMark.ReadOnly = true;
            this.textBox_averageMark.Size = new System.Drawing.Size(57, 20);
            this.textBox_averageMark.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_additionalMark);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.radioButton_aM_countsAsMark);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton_aM_countsAsPrecentage);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 102);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mündliche Note";
            // 
            // MarkUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_averageMark);
            this.Controls.Add(this.label_averageMark);
            this.Controls.Add(this.groupBox_calculateTargetMark);
            this.Controls.Add(this.chart_marks);
            this.Controls.Add(this.comboBox_classes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarkUtils";
            this.Text = "MarkUtils";
            ((System.ComponentModel.ISupportInitialize)(this.chart_marks)).EndInit();
            this.groupBox_calculateTargetMark.ResumeLayout(false);
            this.groupBox_calculateTargetMark.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_classes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_marks;
        private System.Windows.Forms.CheckBox checkBox_additionalMark;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.RadioButton radioButton_aM_countsAsMark;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton radioButton_aM_countsAsPrecentage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_calculateTargetMark;
        private System.Windows.Forms.Button button_calcuteTargetMark;
        private System.Windows.Forms.TextBox textBox_requiredMark;
        private System.Windows.Forms.Label label_requiredMark;
        private System.Windows.Forms.TextBox textBox_targetMark;
        private System.Windows.Forms.Label label_targetMark;
        private System.Windows.Forms.Label label_averageMark;
        private System.Windows.Forms.TextBox textBox_averageMark;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}