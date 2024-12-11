namespace WinForms_02
{
    partial class txt_lnput
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
            btn_CircleArea = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_Circumference = new Button();
            txt_Radius = new TextBox();
            lbl_Result = new Label();
            groupBox2 = new GroupBox();
            btn_OutputParameter = new Button();
            txt_Input = new TextBox();
            btn_RelfParameler = new Button();
            txt_Size = new TextBox();
            txt_Letter = new TextBox();
            bin_Triangle01 = new Button();
            txt_Qutput = new TextBox();
            btn_ArrayParameter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CircleArea
            // 
            btn_CircleArea.Location = new Point(226, 52);
            btn_CircleArea.Name = "btn_CircleArea";
            btn_CircleArea.Size = new Size(60, 32);
            btn_CircleArea.TabIndex = 0;
            btn_CircleArea.Text = "พื้นที่";
            btn_CircleArea.UseVisualStyleBackColor = true;
            btn_CircleArea.Click += btn_CircleArea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 58);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "รัศมีวงกลม";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(btn_Circumference);
            groupBox1.Controls.Add(txt_Radius);
            groupBox1.Controls.Add(lbl_Result);
            groupBox1.Controls.Add(btn_CircleArea);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "รูปวงกลม";
            // 
            // btn_Circumference
            // 
            btn_Circumference.Location = new Point(302, 55);
            btn_Circumference.Name = "btn_Circumference";
            btn_Circumference.Size = new Size(71, 29);
            btn_Circumference.TabIndex = 4;
            btn_Circumference.Text = "เส้นรอบวง";
            btn_Circumference.UseVisualStyleBackColor = true;
            btn_Circumference.Click += btn_Circumference_Click;
            // 
            // txt_Radius
            // 
            txt_Radius.Location = new Point(84, 55);
            txt_Radius.Name = "txt_Radius";
            txt_Radius.Size = new Size(125, 27);
            txt_Radius.TabIndex = 3;
            // 
            // lbl_Result
            // 
            lbl_Result.BackColor = SystemColors.Highlight;
            lbl_Result.Location = new Point(84, 126);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(185, 39);
            lbl_Result.TabIndex = 2;
            lbl_Result.Text = "....";
            lbl_Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MistyRose;
            groupBox2.Controls.Add(btn_OutputParameter);
            groupBox2.Controls.Add(txt_Input);
            groupBox2.Controls.Add(btn_RelfParameler);
            groupBox2.Controls.Add(txt_Size);
            groupBox2.Controls.Add(txt_Letter);
            groupBox2.Controls.Add(bin_Triangle01);
            groupBox2.Controls.Add(txt_Qutput);
            groupBox2.Location = new Point(25, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(533, 298);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบ function";
            // 
            // btn_OutputParameter
            // 
            btn_OutputParameter.Location = new Point(293, 253);
            btn_OutputParameter.Name = "btn_OutputParameter";
            btn_OutputParameter.Size = new Size(210, 29);
            btn_OutputParameter.TabIndex = 6;
            btn_OutputParameter.Text = "ทดสอบ Output Parameter";
            btn_OutputParameter.UseVisualStyleBackColor = true;
            btn_OutputParameter.Click += btn_OutputParameter_Click;
            // 
            // txt_Input
            // 
            txt_Input.Location = new Point(291, 157);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(214, 27);
            txt_Input.TabIndex = 5;
            txt_Input.TextChanged += textBox1_TextChanged;
            // 
            // btn_RelfParameler
            // 
            btn_RelfParameler.Location = new Point(291, 190);
            btn_RelfParameler.Name = "btn_RelfParameler";
            btn_RelfParameler.Size = new Size(212, 46);
            btn_RelfParameler.TabIndex = 4;
            btn_RelfParameler.Text = "ทดสอบ referfnce parameter";
            btn_RelfParameler.UseVisualStyleBackColor = true;
            btn_RelfParameler.Click += btn_RelfParameler_Click;
            // 
            // txt_Size
            // 
            txt_Size.Location = new Point(293, 106);
            txt_Size.Name = "txt_Size";
            txt_Size.Size = new Size(125, 27);
            txt_Size.TabIndex = 3;
            txt_Size.Text = "3";
            txt_Size.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_Letter
            // 
            txt_Letter.Location = new Point(293, 43);
            txt_Letter.Name = "txt_Letter";
            txt_Letter.Size = new Size(125, 27);
            txt_Letter.TabIndex = 2;
            txt_Letter.Text = "A";
            txt_Letter.TextAlign = HorizontalAlignment.Center;
            // 
            // bin_Triangle01
            // 
            bin_Triangle01.Location = new Point(443, 61);
            bin_Triangle01.Name = "bin_Triangle01";
            bin_Triangle01.Size = new Size(84, 41);
            bin_Triangle01.TabIndex = 1;
            bin_Triangle01.Text = "Triangle";
            bin_Triangle01.UseVisualStyleBackColor = true;
            bin_Triangle01.Click += bin_Triangle01_Click;
            // 
            // txt_Qutput
            // 
            txt_Qutput.ForeColor = SystemColors.WindowText;
            txt_Qutput.Location = new Point(23, 26);
            txt_Qutput.Multiline = true;
            txt_Qutput.Name = "txt_Qutput";
            txt_Qutput.Size = new Size(246, 214);
            txt_Qutput.TabIndex = 0;
            txt_Qutput.TabStop = false;
            // 
            // btn_ArrayParameter
            // 
            btn_ArrayParameter.Location = new Point(602, 61);
            btn_ArrayParameter.Name = "btn_ArrayParameter";
            btn_ArrayParameter.Size = new Size(158, 62);
            btn_ArrayParameter.TabIndex = 4;
            btn_ArrayParameter.Text = " Parameter แบบ Array";
            btn_ArrayParameter.UseVisualStyleBackColor = true;
            btn_ArrayParameter.Click += btn_ArrayParameter_Click;
            // 
            // txt_lnput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 554);
            Controls.Add(btn_ArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "txt_lnput";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_CircleArea;
        private Label label1;
        private GroupBox groupBox1;
        private Label lbl_Result;
        private Button btn_Circumference;
        private TextBox txt_Radius;
        private GroupBox groupBox2;
        private TextBox txt_Qutput;
        private TextBox txt_Size;
        private TextBox txt_Letter;
        private Button bin_Triangle01;
        private Button btn_RelfParameler;
        private TextBox txt_Input;
        private Button btn_OutputParameter;
        private Button btn_ArrayParameter;
    }
}
