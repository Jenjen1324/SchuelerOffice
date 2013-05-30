namespace SchülerOffice.VocabManager
{
    partial class AddVocabulary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVocabulary));
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_1lang = new System.Windows.Forms.TextBox();
            this.textBox_2lang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_word_desc = new System.Windows.Forms.TextBox();
            this.label_word_desc = new System.Windows.Forms.Label();
            this.textBox_word_2lang = new System.Windows.Forms.TextBox();
            this.textBox_word_1lang = new System.Windows.Forms.TextBox();
            this.label_word_2lang = new System.Windows.Forms.Label();
            this.label_word_1lang = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_1lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_2lang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_abort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(93, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(227, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(93, 38);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(227, 20);
            this.textBox_desc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beschreibung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "1. Sprache:";
            // 
            // textBox_1lang
            // 
            this.textBox_1lang.Location = new System.Drawing.Point(93, 69);
            this.textBox_1lang.Name = "textBox_1lang";
            this.textBox_1lang.Size = new System.Drawing.Size(227, 20);
            this.textBox_1lang.TabIndex = 2;
            // 
            // textBox_2lang
            // 
            this.textBox_2lang.Location = new System.Drawing.Point(93, 95);
            this.textBox_2lang.Name = "textBox_2lang";
            this.textBox_2lang.Size = new System.Drawing.Size(227, 20);
            this.textBox_2lang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "2. Sprache:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_edit);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_word_desc);
            this.groupBox1.Controls.Add(this.label_word_desc);
            this.groupBox1.Controls.Add(this.textBox_word_2lang);
            this.groupBox1.Controls.Add(this.textBox_word_1lang);
            this.groupBox1.Controls.Add(this.label_word_2lang);
            this.groupBox1.Controls.Add(this.label_word_1lang);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 351);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wörter";
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(305, 43);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(94, 23);
            this.button_edit.TabIndex = 8;
            this.button_edit.Text = "Editieren";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(305, 69);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(94, 23);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Entfernen";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(305, 17);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Hinzufügen";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_word_desc
            // 
            this.textBox_word_desc.Location = new System.Drawing.Point(87, 71);
            this.textBox_word_desc.Name = "textBox_word_desc";
            this.textBox_word_desc.Size = new System.Drawing.Size(212, 20);
            this.textBox_word_desc.TabIndex = 6;
            // 
            // label_word_desc
            // 
            this.label_word_desc.AutoSize = true;
            this.label_word_desc.Location = new System.Drawing.Point(6, 74);
            this.label_word_desc.Name = "label_word_desc";
            this.label_word_desc.Size = new System.Drawing.Size(75, 13);
            this.label_word_desc.TabIndex = 11;
            this.label_word_desc.Text = "Beschreibung:";
            // 
            // textBox_word_2lang
            // 
            this.textBox_word_2lang.Location = new System.Drawing.Point(87, 45);
            this.textBox_word_2lang.Name = "textBox_word_2lang";
            this.textBox_word_2lang.Size = new System.Drawing.Size(212, 20);
            this.textBox_word_2lang.TabIndex = 5;
            // 
            // textBox_word_1lang
            // 
            this.textBox_word_1lang.Location = new System.Drawing.Point(87, 19);
            this.textBox_word_1lang.Name = "textBox_word_1lang";
            this.textBox_word_1lang.Size = new System.Drawing.Size(212, 20);
            this.textBox_word_1lang.TabIndex = 4;
            // 
            // label_word_2lang
            // 
            this.label_word_2lang.AutoSize = true;
            this.label_word_2lang.Location = new System.Drawing.Point(6, 48);
            this.label_word_2lang.Name = "label_word_2lang";
            this.label_word_2lang.Size = new System.Drawing.Size(62, 13);
            this.label_word_2lang.TabIndex = 2;
            this.label_word_2lang.Text = "2. Sprache:";
            // 
            // label_word_1lang
            // 
            this.label_word_1lang.AutoSize = true;
            this.label_word_1lang.Location = new System.Drawing.Point(6, 22);
            this.label_word_1lang.Name = "label_word_1lang";
            this.label_word_1lang.Size = new System.Drawing.Size(62, 13);
            this.label_word_1lang.TabIndex = 1;
            this.label_word_1lang.Text = "1. Sprache:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_1lang,
            this.col_2lang,
            this.col_desc,
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(6, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(404, 247);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // col_1lang
            // 
            this.col_1lang.HeaderText = "1. Sprache";
            this.col_1lang.Name = "col_1lang";
            this.col_1lang.ReadOnly = true;
            // 
            // col_2lang
            // 
            this.col_2lang.HeaderText = "2. Sprache";
            this.col_2lang.Name = "col_2lang";
            this.col_2lang.ReadOnly = true;
            // 
            // col_desc
            // 
            this.col_desc.HeaderText = "Beschreibung";
            this.col_desc.Name = "col_desc";
            this.col_desc.ReadOnly = true;
            this.col_desc.Width = 201;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(335, 478);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(87, 23);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // button_abort
            // 
            this.button_abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_abort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button_abort.Location = new System.Drawing.Point(239, 478);
            this.button_abort.Name = "button_abort";
            this.button_abort.Size = new System.Drawing.Size(90, 23);
            this.button_abort.TabIndex = 12;
            this.button_abort.Text = "Abbrechen";
            this.button_abort.UseVisualStyleBackColor = true;
            // 
            // AddVocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 504);
            this.Controls.Add(this.button_abort);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_2lang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_1lang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(456, 394);
            this.Name = "AddVocabulary";
            this.Text = "Vokabular hinzufügen/editieren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(AddVocabulary_FormClosing);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_1lang;
        private System.Windows.Forms.TextBox textBox_2lang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_word_desc;
        private System.Windows.Forms.Label label_word_desc;
        private System.Windows.Forms.TextBox textBox_word_2lang;
        private System.Windows.Forms.TextBox textBox_word_1lang;
        private System.Windows.Forms.Label label_word_2lang;
        private System.Windows.Forms.Label label_word_1lang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_abort;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_1lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_2lang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}