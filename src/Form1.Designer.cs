namespace viewer;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxlanguage1 = new System.Windows.Forms.TextBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.textBoxlanguage2 = new System.Windows.Forms.TextBox();
            this.buttoncreate = new System.Windows.Forms.Button();
            this.textBoxlanguage1_1 = new System.Windows.Forms.TextBox();
            this.textBoxlanguage2_1 = new System.Windows.Forms.TextBox();
            this.buttondelete = new System.Windows.Forms.Button();
            this.textBoxmistakes = new System.Windows.Forms.TextBox();
            this.textBoxmistakes1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxfilterlanguage1 = new System.Windows.Forms.TextBox();
            this.textBoxfilterlanguage2 = new System.Windows.Forms.TextBox();
            this.buttonfilter = new System.Windows.Forms.Button();
            this.buttonfilterdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // textBoxlanguage1
            // 
            this.textBoxlanguage1.Location = new System.Drawing.Point(12, 286);
            this.textBoxlanguage1.Name = "textBoxlanguage1";
            this.textBoxlanguage1.Size = new System.Drawing.Size(100, 20);
            this.textBoxlanguage1.TabIndex = 1;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(12, 312);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 2;
            this.buttonsave.Text = "save";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxlanguage2
            // 
            this.textBoxlanguage2.Location = new System.Drawing.Point(118, 286);
            this.textBoxlanguage2.Name = "textBoxlanguage2";
            this.textBoxlanguage2.Size = new System.Drawing.Size(100, 20);
            this.textBoxlanguage2.TabIndex = 3;
            // 
            // buttoncreate
            // 
            this.buttoncreate.Location = new System.Drawing.Point(13, 392);
            this.buttoncreate.Name = "buttoncreate";
            this.buttoncreate.Size = new System.Drawing.Size(75, 23);
            this.buttoncreate.TabIndex = 4;
            this.buttoncreate.Text = "create";
            this.buttoncreate.UseVisualStyleBackColor = true;
            this.buttoncreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxlanguage1_1
            // 
            this.textBoxlanguage1_1.Location = new System.Drawing.Point(13, 366);
            this.textBoxlanguage1_1.Name = "textBoxlanguage1_1";
            this.textBoxlanguage1_1.Size = new System.Drawing.Size(100, 20);
            this.textBoxlanguage1_1.TabIndex = 5;
            // 
            // textBoxlanguage2_1
            // 
            this.textBoxlanguage2_1.Location = new System.Drawing.Point(119, 366);
            this.textBoxlanguage2_1.Name = "textBoxlanguage2_1";
            this.textBoxlanguage2_1.Size = new System.Drawing.Size(100, 20);
            this.textBoxlanguage2_1.TabIndex = 6;
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(93, 312);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(75, 23);
            this.buttondelete.TabIndex = 7;
            this.buttondelete.Text = "delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxmistakes
            // 
            this.textBoxmistakes.Location = new System.Drawing.Point(224, 286);
            this.textBoxmistakes.Name = "textBoxmistakes";
            this.textBoxmistakes.Size = new System.Drawing.Size(100, 20);
            this.textBoxmistakes.TabIndex = 9;
            // 
            // textBoxmistakes1
            // 
            this.textBoxmistakes1.Location = new System.Drawing.Point(225, 366);
            this.textBoxmistakes1.Name = "textBoxmistakes1";
            this.textBoxmistakes1.Size = new System.Drawing.Size(100, 20);
            this.textBoxmistakes1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "language1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "language2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "mistakes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "create entry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "edit or delete?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "language1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "language2:";
            // 
            // textBoxfilterlanguage1
            // 
            this.textBoxfilterlanguage1.Location = new System.Drawing.Point(492, 44);
            this.textBoxfilterlanguage1.Name = "textBoxfilterlanguage1";
            this.textBoxfilterlanguage1.Size = new System.Drawing.Size(100, 20);
            this.textBoxfilterlanguage1.TabIndex = 19;
            // 
            // textBoxfilterlanguage2
            // 
            this.textBoxfilterlanguage2.Location = new System.Drawing.Point(492, 83);
            this.textBoxfilterlanguage2.Name = "textBoxfilterlanguage2";
            this.textBoxfilterlanguage2.Size = new System.Drawing.Size(100, 20);
            this.textBoxfilterlanguage2.TabIndex = 20;
            // 
            // buttonfilter
            // 
            this.buttonfilter.Location = new System.Drawing.Point(492, 109);
            this.buttonfilter.Name = "buttonfilter";
            this.buttonfilter.Size = new System.Drawing.Size(100, 23);
            this.buttonfilter.TabIndex = 21;
            this.buttonfilter.Text = "filter";
            this.buttonfilter.UseVisualStyleBackColor = true;
            this.buttonfilter.Click += new System.EventHandler(this.buttonfilter_Click);
            // 
            // buttonfilterdelete
            // 
            this.buttonfilterdelete.Location = new System.Drawing.Point(492, 138);
            this.buttonfilterdelete.Name = "buttonfilterdelete";
            this.buttonfilterdelete.Size = new System.Drawing.Size(100, 23);
            this.buttonfilterdelete.TabIndex = 22;
            this.buttonfilterdelete.Text = "delete filter";
            this.buttonfilterdelete.UseVisualStyleBackColor = true;
            this.buttonfilterdelete.Click += new System.EventHandler(this.buttonfilterdelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 537);
            this.Controls.Add(this.buttonfilterdelete);
            this.Controls.Add(this.buttonfilter);
            this.Controls.Add(this.textBoxfilterlanguage2);
            this.Controls.Add(this.textBoxfilterlanguage1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxmistakes1);
            this.Controls.Add(this.textBoxmistakes);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.textBoxlanguage2_1);
            this.Controls.Add(this.textBoxlanguage1_1);
            this.Controls.Add(this.buttoncreate);
            this.Controls.Add(this.textBoxlanguage2);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.textBoxlanguage1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
			


    }


    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxlanguage1;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.TextBox textBoxlanguage2;
        private System.Windows.Forms.Button buttoncreate;
        private System.Windows.Forms.TextBox textBoxlanguage1_1;
        private System.Windows.Forms.TextBox textBoxlanguage2_1;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.TextBox textBoxmistakes;
        private System.Windows.Forms.TextBox textBoxmistakes1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxfilterlanguage1;
        private System.Windows.Forms.TextBox textBoxfilterlanguage2;
        private System.Windows.Forms.Button buttonfilter;
        private System.Windows.Forms.Button buttonfilterdelete;
}
