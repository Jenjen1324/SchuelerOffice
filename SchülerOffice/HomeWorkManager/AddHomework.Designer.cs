namespace SchülerOffice.HomeWorkManager
{
    partial class AddHomework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHomework));
            this.label_addHomework_day = new System.Windows.Forms.Label();
            this.textBox_addHomework_day = new System.Windows.Forms.TextBox();
            this.label_addHomework_class = new System.Windows.Forms.Label();
            this.textBox_addHomework_class = new System.Windows.Forms.TextBox();
            this.label_addHomework_task = new System.Windows.Forms.Label();
            this.textBox_addHomework_task = new System.Windows.Forms.TextBox();
            this.button_addHomework_ok = new System.Windows.Forms.Button();
            this.button_addHomework_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_addHomework_day
            // 
            this.label_addHomework_day.AutoSize = true;
            this.label_addHomework_day.Location = new System.Drawing.Point(12, 15);
            this.label_addHomework_day.Name = "label_addHomework_day";
            this.label_addHomework_day.Size = new System.Drawing.Size(41, 13);
            this.label_addHomework_day.TabIndex = 0;
            this.label_addHomework_day.Text = "Datum:";
            // 
            // textBox_addHomework_day
            // 
            this.textBox_addHomework_day.Location = new System.Drawing.Point(77, 12);
            this.textBox_addHomework_day.Name = "textBox_addHomework_day";
            this.textBox_addHomework_day.ReadOnly = true;
            this.textBox_addHomework_day.Size = new System.Drawing.Size(176, 20);
            this.textBox_addHomework_day.TabIndex = 1;
            // 
            // label_addHomework_class
            // 
            this.label_addHomework_class.AutoSize = true;
            this.label_addHomework_class.Location = new System.Drawing.Point(12, 39);
            this.label_addHomework_class.Name = "label_addHomework_class";
            this.label_addHomework_class.Size = new System.Drawing.Size(44, 13);
            this.label_addHomework_class.TabIndex = 2;
            this.label_addHomework_class.Text = "Stunde:";
            // 
            // textBox_addHomework_class
            // 
            this.textBox_addHomework_class.Location = new System.Drawing.Point(77, 36);
            this.textBox_addHomework_class.Name = "textBox_addHomework_class";
            this.textBox_addHomework_class.ReadOnly = true;
            this.textBox_addHomework_class.Size = new System.Drawing.Size(176, 20);
            this.textBox_addHomework_class.TabIndex = 3;
            // 
            // label_addHomework_task
            // 
            this.label_addHomework_task.AutoSize = true;
            this.label_addHomework_task.Location = new System.Drawing.Point(12, 64);
            this.label_addHomework_task.Name = "label_addHomework_task";
            this.label_addHomework_task.Size = new System.Drawing.Size(50, 13);
            this.label_addHomework_task.TabIndex = 4;
            this.label_addHomework_task.Text = "Aufgabe:";
            // 
            // textBox_addHomework_task
            // 
            this.textBox_addHomework_task.Location = new System.Drawing.Point(77, 62);
            this.textBox_addHomework_task.Multiline = true;
            this.textBox_addHomework_task.Name = "textBox_addHomework_task";
            this.textBox_addHomework_task.Size = new System.Drawing.Size(176, 259);
            this.textBox_addHomework_task.TabIndex = 5;
            // 
            // button_addHomework_ok
            // 
            this.button_addHomework_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_addHomework_ok.Location = new System.Drawing.Point(176, 327);
            this.button_addHomework_ok.Name = "button_addHomework_ok";
            this.button_addHomework_ok.Size = new System.Drawing.Size(77, 23);
            this.button_addHomework_ok.TabIndex = 6;
            this.button_addHomework_ok.Text = "OK";
            this.button_addHomework_ok.UseVisualStyleBackColor = true;
            // 
            // button_addHomework_cancel
            // 
            this.button_addHomework_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_addHomework_cancel.Location = new System.Drawing.Point(77, 327);
            this.button_addHomework_cancel.Name = "button_addHomework_cancel";
            this.button_addHomework_cancel.Size = new System.Drawing.Size(93, 23);
            this.button_addHomework_cancel.TabIndex = 7;
            this.button_addHomework_cancel.Text = "Abbrechen";
            this.button_addHomework_cancel.UseVisualStyleBackColor = true;
            // 
            // AddHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 354);
            this.Controls.Add(this.button_addHomework_cancel);
            this.Controls.Add(this.button_addHomework_ok);
            this.Controls.Add(this.textBox_addHomework_task);
            this.Controls.Add(this.label_addHomework_task);
            this.Controls.Add(this.textBox_addHomework_class);
            this.Controls.Add(this.label_addHomework_class);
            this.Controls.Add(this.textBox_addHomework_day);
            this.Controls.Add(this.label_addHomework_day);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddHomework";
            this.Text = "AddHomework";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_addHomework_day;
        private System.Windows.Forms.TextBox textBox_addHomework_day;
        private System.Windows.Forms.Label label_addHomework_class;
        private System.Windows.Forms.TextBox textBox_addHomework_class;
        private System.Windows.Forms.Label label_addHomework_task;
        private System.Windows.Forms.TextBox textBox_addHomework_task;
        private System.Windows.Forms.Button button_addHomework_ok;
        private System.Windows.Forms.Button button_addHomework_cancel;
    }
}