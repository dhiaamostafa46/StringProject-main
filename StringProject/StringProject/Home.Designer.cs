namespace StringProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.do_it = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.input_label = new System.Windows.Forms.Label();
            this.function_proc = new System.Windows.Forms.ComboBox();
            this.function_label = new System.Windows.Forms.Label();
            this.explain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.result_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.input_label3 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.input_label2 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.Button();
            this.explain_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // do_it
            // 
            this.do_it.BackColor = System.Drawing.Color.MediumVioletRed;
            this.do_it.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.do_it.FlatAppearance.BorderSize = 2;
            this.do_it.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.do_it.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.do_it.ForeColor = System.Drawing.Color.White;
            this.do_it.Location = new System.Drawing.Point(356, 137);
            this.do_it.Name = "do_it";
            this.do_it.Size = new System.Drawing.Size(81, 32);
            this.do_it.TabIndex = 0;
            this.do_it.TabStop = false;
            this.do_it.Text = "تنفيذ";
            this.do_it.UseVisualStyleBackColor = false;
            this.do_it.Click += new System.EventHandler(this.button1_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.head.Location = new System.Drawing.Point(137, 4);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(221, 32);
            this.head.TabIndex = 1;
            this.head.Text = "String Functions";
            // 
            // text
            // 
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(152, 90);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(245, 26);
            this.text.TabIndex = 1;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.input_label.Location = new System.Drawing.Point(47, 93);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(99, 18);
            this.input_label.TabIndex = 3;
            this.input_label.Text = "النص المدخل :";
            // 
            // function_proc
            // 
            this.function_proc.DropDownHeight = 100;
            this.function_proc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function_proc.FormattingEnabled = true;
            this.function_proc.IntegralHeight = false;
            this.function_proc.ItemHeight = 18;
            this.function_proc.Items.AddRange(new object[] {
            "ToUpper()",
            "ToLower()",
            "GetHashCode()",
            "GetTypeCode()",
            "GetType()",
            "CompareTo()",
            "Substring()",
            "StartsWith()",
            "EndsWith()",
            "Contains()",
            "Split()",
            "Concat()",
            "Copy()",
            "Clone()",
            "Insert()",
            "Remove()",
            "Replace()",
            "IndexOf()",
            "LastIndexOf()",
            "LastIndexOfAny()",
            "Trim()",
            "TrimStart()",
            "TrimEnd()",
            "Length",
            "ToCharArray()",
            "Format()",
            "CompareOrdinal()",
            "Equals()",
            "CopyTo()",
            "PadLeft()",
            "PadRight()",
            "Join()",
            "IsNullOrEmpty()",
            "Intern()",
            "IsNullOrWhiteSpace()",
            "IsInterned()",
            "IsNormalized()",
            "Normalize()",
            "ToString()"});
            this.function_proc.Location = new System.Drawing.Point(152, 141);
            this.function_proc.Name = "function_proc";
            this.function_proc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.function_proc.Size = new System.Drawing.Size(147, 26);
            this.function_proc.TabIndex = 2;
            this.function_proc.Text = "اختر الدالة";
            this.function_proc.SelectedIndexChanged += new System.EventHandler(this.function_proc_SelectedIndexChanged);
            this.function_proc.Click += new System.EventHandler(this.function_proc_Click);
            // 
            // function_label
            // 
            this.function_label.AutoSize = true;
            this.function_label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function_label.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.function_label.Location = new System.Drawing.Point(61, 144);
            this.function_label.Name = "function_label";
            this.function_label.Size = new System.Drawing.Size(85, 18);
            this.function_label.TabIndex = 5;
            this.function_label.Text = "إسم الدالة :";
            // 
            // explain
            // 
            this.explain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.explain.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.explain.Location = new System.Drawing.Point(50, 226);
            this.explain.Multiline = true;
            this.explain.Name = "explain";
            this.explain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.explain.Size = new System.Drawing.Size(387, 103);
            this.explain.TabIndex = 6;
            this.explain.TabStop = false;
            this.explain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(194, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "( عمل الدالة )";
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.Color.LightYellow;
            this.res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.res.ContextMenuStrip = this.contextMenuStrip1;
            this.res.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.ForeColor = System.Drawing.Color.MediumBlue;
            this.res.Location = new System.Drawing.Point(28, 114);
            this.res.Name = "res";
            this.res.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.res.Size = new System.Drawing.Size(259, 26);
            this.res.TabIndex = 8;
            this.res.TabStop = false;
            this.res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // paste
            // 
            this.paste.Enabled = false;
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(94, 22);
            this.paste.Text = "لصق";
            this.paste.Click += new System.EventHandler(this.لصقToolStripMenuItem_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.ForeColor = System.Drawing.Color.Black;
            this.result_label.Location = new System.Drawing.Point(298, 116);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(60, 18);
            this.result_label.TabIndex = 10;
            this.result_label.Text = "النتيجة :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.input_label3);
            this.groupBox1.Controls.Add(this.text3);
            this.groupBox1.Controls.Add(this.input_label2);
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Controls.Add(this.result_label);
            this.groupBox1.Controls.Add(this.res);
            this.groupBox1.Location = new System.Drawing.Point(50, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // input_label3
            // 
            this.input_label3.AutoSize = true;
            this.input_label3.ContextMenuStrip = this.contextMenuStrip1;
            this.input_label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.input_label3.Location = new System.Drawing.Point(298, 70);
            this.input_label3.Name = "input_label3";
            this.input_label3.Size = new System.Drawing.Size(56, 18);
            this.input_label3.TabIndex = 15;
            this.input_label3.Text = "البداية :";
            this.input_label3.Visible = false;
            // 
            // text3
            // 
            this.text3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text3.ContextMenuStrip = this.contextMenuStrip1;
            this.text3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.ForeColor = System.Drawing.Color.Black;
            this.text3.Location = new System.Drawing.Point(240, 68);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(51, 26);
            this.text3.TabIndex = 4;
            this.text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text3.Visible = false;
            // 
            // input_label2
            // 
            this.input_label2.AutoSize = true;
            this.input_label2.ContextMenuStrip = this.contextMenuStrip1;
            this.input_label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.input_label2.Location = new System.Drawing.Point(275, 24);
            this.input_label2.Name = "input_label2";
            this.input_label2.Size = new System.Drawing.Size(101, 18);
            this.input_label2.TabIndex = 13;
            this.input_label2.Text = "الحرف \\ النص :";
            this.input_label2.Visible = false;
            // 
            // text2
            // 
            this.text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text2.ContextMenuStrip = this.contextMenuStrip1;
            this.text2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.Black;
            this.text2.Location = new System.Drawing.Point(79, 19);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(190, 26);
            this.text2.TabIndex = 3;
            this.text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text2.Visible = false;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.MediumVioletRed;
            this.about.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.about.FlatAppearance.BorderSize = 2;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.White;
            this.about.Location = new System.Drawing.Point(377, 9);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(95, 27);
            this.about.TabIndex = 15;
            this.about.TabStop = false;
            this.about.Text = "إعداد الطلاب";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // explain_button
            // 
            this.explain_button.BackColor = System.Drawing.Color.MediumVioletRed;
            this.explain_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.explain_button.FlatAppearance.BorderSize = 2;
            this.explain_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explain_button.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explain_button.ForeColor = System.Drawing.Color.White;
            this.explain_button.Location = new System.Drawing.Point(50, 192);
            this.explain_button.Name = "explain_button";
            this.explain_button.Size = new System.Drawing.Size(116, 27);
            this.explain_button.TabIndex = 16;
            this.explain_button.TabStop = false;
            this.explain_button.Text = "إخفاء عمل الدالة";
            this.explain_button.UseVisualStyleBackColor = false;
            this.explain_button.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AcceptButton = this.do_it;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(484, 517);
            this.Controls.Add(this.explain_button);
            this.Controls.Add(this.about);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.explain);
            this.Controls.Add(this.function_label);
            this.Controls.Add(this.function_proc);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.text);
            this.Controls.Add(this.head);
            this.Controls.Add(this.do_it);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button do_it;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.ComboBox function_proc;
        private System.Windows.Forms.Label function_label;
        private System.Windows.Forms.TextBox explain;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox text;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button about;
        public System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button explain_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paste;
        public System.Windows.Forms.Label result_label;
        public System.Windows.Forms.Label input_label2;
        public System.Windows.Forms.Label input_label3;
        public System.Windows.Forms.TextBox res;
    }
}

