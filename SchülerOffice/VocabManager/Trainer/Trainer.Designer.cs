namespace SchülerOffice.VocabManager.Trainer
{
    partial class Trainer
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
            this.textBox_1lang = new System.Windows.Forms.TextBox();
            this.textBox_2lang = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label_1lang = new System.Windows.Forms.Label();
            this.label_2lang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ctime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_cremaining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cright = new System.Windows.Forms.TextBox();
            this.textBox_cwrong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_continue = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_response = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_1lang
            // 
            this.textBox_1lang.Location = new System.Drawing.Point(96, 13);
            this.textBox_1lang.Name = "textBox_1lang";
            this.textBox_1lang.ReadOnly = true;
            this.textBox_1lang.Size = new System.Drawing.Size(185, 20);
            this.textBox_1lang.TabIndex = 0;
            // 
            // textBox_2lang
            // 
            this.textBox_2lang.Location = new System.Drawing.Point(96, 39);
            this.textBox_2lang.Name = "textBox_2lang";
            this.textBox_2lang.Size = new System.Drawing.Size(185, 20);
            this.textBox_2lang.TabIndex = 1;
            // 
            // button_check
            // 
            this.button_check.Enabled = false;
            this.button_check.Location = new System.Drawing.Point(182, 65);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(99, 23);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "Kontrollieren";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_1lang
            // 
            this.label_1lang.AutoSize = true;
            this.label_1lang.Location = new System.Drawing.Point(6, 16);
            this.label_1lang.Name = "label_1lang";
            this.label_1lang.Size = new System.Drawing.Size(43, 13);
            this.label_1lang.TabIndex = 3;
            this.label_1lang.Text = "1. Lang";
            // 
            // label_2lang
            // 
            this.label_2lang.AutoSize = true;
            this.label_2lang.Location = new System.Drawing.Point(6, 42);
            this.label_2lang.Name = "label_2lang";
            this.label_2lang.Size = new System.Drawing.Size(43, 13);
            this.label_2lang.TabIndex = 4;
            this.label_2lang.Text = "2. Lang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Falsch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Richtig:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ctime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_cremaining);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_cright);
            this.groupBox1.Controls.Add(this.textBox_cwrong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // textBox_ctime
            // 
            this.textBox_ctime.Location = new System.Drawing.Point(90, 91);
            this.textBox_ctime.Name = "textBox_ctime";
            this.textBox_ctime.ReadOnly = true;
            this.textBox_ctime.Size = new System.Drawing.Size(24, 20);
            this.textBox_ctime.TabIndex = 14;
            this.textBox_ctime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Zeit:";
            // 
            // textBox_cremaining
            // 
            this.textBox_cremaining.Location = new System.Drawing.Point(90, 65);
            this.textBox_cremaining.Name = "textBox_cremaining";
            this.textBox_cremaining.ReadOnly = true;
            this.textBox_cremaining.Size = new System.Drawing.Size(24, 20);
            this.textBox_cremaining.TabIndex = 12;
            this.textBox_cremaining.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Übrige Wörter:";
            // 
            // textBox_cright
            // 
            this.textBox_cright.Location = new System.Drawing.Point(90, 39);
            this.textBox_cright.Name = "textBox_cright";
            this.textBox_cright.ReadOnly = true;
            this.textBox_cright.Size = new System.Drawing.Size(24, 20);
            this.textBox_cright.TabIndex = 10;
            this.textBox_cright.Text = "0";
            // 
            // textBox_cwrong
            // 
            this.textBox_cwrong.Location = new System.Drawing.Point(90, 13);
            this.textBox_cwrong.Name = "textBox_cwrong";
            this.textBox_cwrong.ReadOnly = true;
            this.textBox_cwrong.Size = new System.Drawing.Size(24, 20);
            this.textBox_cwrong.TabIndex = 9;
            this.textBox_cwrong.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_1lang);
            this.groupBox2.Controls.Add(this.textBox_1lang);
            this.groupBox2.Controls.Add(this.label_2lang);
            this.groupBox2.Controls.Add(this.textBox_2lang);
            this.groupBox2.Controls.Add(this.button_check);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_continue);
            this.groupBox3.Controls.Add(this.button_stop);
            this.groupBox3.Controls.Add(this.button_pause);
            this.groupBox3.Controls.Add(this.button_start);
            this.groupBox3.Location = new System.Drawing.Point(143, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 120);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // button_continue
            // 
            this.button_continue.Enabled = false;
            this.button_continue.Location = new System.Drawing.Point(6, 65);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(144, 23);
            this.button_continue.TabIndex = 2;
            this.button_continue.Text = "Weitermachen";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // button_stop
            // 
            this.button_stop.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button_stop.Location = new System.Drawing.Point(6, 91);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(144, 23);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "Aufhören";
            this.button_stop.UseVisualStyleBackColor = true;
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(6, 37);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(144, 23);
            this.button_pause.TabIndex = 1;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(6, 11);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(144, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Starten";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_response);
            this.groupBox4.Location = new System.Drawing.Point(12, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 82);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // textBox_response
            // 
            this.textBox_response.Location = new System.Drawing.Point(6, 14);
            this.textBox_response.Multiline = true;
            this.textBox_response.Name = "textBox_response";
            this.textBox_response.Size = new System.Drawing.Size(275, 62);
            this.textBox_response.TabIndex = 0;
            // 
            // Trainer
            // 
            this.AcceptButton = this.button_check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 334);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Trainer";
            this.Text = "Trainer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_1lang;
        private System.Windows.Forms.TextBox textBox_2lang;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_1lang;
        private System.Windows.Forms.Label label_2lang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ctime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_cremaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cright;
        private System.Windows.Forms.TextBox textBox_cwrong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_response;
    }
}