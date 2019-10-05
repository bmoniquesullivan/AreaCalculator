//Student: Barbara Sullivan
//Instructor: Dr. Jerry Mamo
//Class: CIST 2341 – C# Programming – 60485 – Summer 2019
//Lab #1 – Assign 3 
namespace Area
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl_Input_top = new System.Windows.Forms.Label();
            this.lbl_Input_bottom = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txt_Input_top = new System.Windows.Forms.TextBox();
            this.txt_Input_bottom = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.rdoCirc = new System.Windows.Forms.RadioButton();
            this.rdoSqr = new System.Windows.Forms.RadioButton();
            this.rdoRect = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbShapes = new System.Windows.Forms.ComboBox();
            this.comBox_groupBox = new System.Windows.Forms.GroupBox();
            this.comBox_listBox = new System.Windows.Forms.GroupBox();
            this.lstShapes = new System.Windows.Forms.ListBox();
            this.comBox_radioButtons = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.comBox_groupBox.SuspendLayout();
            this.comBox_listBox.SuspendLayout();
            this.comBox_radioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalc.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(119, 368);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(105, 43);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(335, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 43);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Eras Medium ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(544, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // lbl_Input_top
            // 
            this.lbl_Input_top.AutoSize = true;
            this.lbl_Input_top.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input_top.Location = new System.Drawing.Point(78, 48);
            this.lbl_Input_top.Name = "lbl_Input_top";
            this.lbl_Input_top.Size = new System.Drawing.Size(21, 29);
            this.lbl_Input_top.TabIndex = 3;
            this.lbl_Input_top.Text = " ";
            // 
            // lbl_Input_bottom
            // 
            this.lbl_Input_bottom.AutoSize = true;
            this.lbl_Input_bottom.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input_bottom.Location = new System.Drawing.Point(78, 165);
            this.lbl_Input_bottom.Name = "lbl_Input_bottom";
            this.lbl_Input_bottom.Size = new System.Drawing.Size(29, 29);
            this.lbl_Input_bottom.TabIndex = 4;
            this.lbl_Input_bottom.Text = "  ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(582, 112);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(67, 29);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area";
            // 
            // txt_Input_top
            // 
            this.txt_Input_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Input_top.Location = new System.Drawing.Point(76, 96);
            this.txt_Input_top.Name = "txt_Input_top";
            this.txt_Input_top.Size = new System.Drawing.Size(100, 34);
            this.txt_Input_top.TabIndex = 6;
            this.txt_Input_top.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Input_top_KeyPress);
            // 
            // txt_Input_bottom
            // 
            this.txt_Input_bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Input_bottom.Location = new System.Drawing.Point(76, 228);
            this.txt_Input_bottom.Name = "txt_Input_bottom";
            this.txt_Input_bottom.Size = new System.Drawing.Size(100, 34);
            this.txt_Input_bottom.TabIndex = 7;
            this.txt_Input_bottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Input_bottom_KeyPress);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(564, 160);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 34);
            this.txtArea.TabIndex = 8;
            // 
            // rdoCirc
            // 
            this.rdoCirc.AutoSize = true;
            this.rdoCirc.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCirc.Location = new System.Drawing.Point(49, 31);
            this.rdoCirc.Name = "rdoCirc";
            this.rdoCirc.Size = new System.Drawing.Size(66, 22);
            this.rdoCirc.TabIndex = 9;
            this.rdoCirc.TabStop = true;
            this.rdoCirc.Text = "Circle";
            this.rdoCirc.UseVisualStyleBackColor = true;
            this.rdoCirc.CheckedChanged += new System.EventHandler(this.CircRBtn_CheckedChanged);
            // 
            // rdoSqr
            // 
            this.rdoSqr.AutoSize = true;
            this.rdoSqr.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSqr.Location = new System.Drawing.Point(49, 59);
            this.rdoSqr.Name = "rdoSqr";
            this.rdoSqr.Size = new System.Drawing.Size(79, 22);
            this.rdoSqr.TabIndex = 10;
            this.rdoSqr.TabStop = true;
            this.rdoSqr.Text = "Square";
            this.rdoSqr.UseVisualStyleBackColor = true;
            this.rdoSqr.CheckedChanged += new System.EventHandler(this.SqrRBtn_CheckedChanged);
            // 
            // rdoRect
            // 
            this.rdoRect.AutoSize = true;
            this.rdoRect.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRect.Location = new System.Drawing.Point(49, 87);
            this.rdoRect.Name = "rdoRect";
            this.rdoRect.Size = new System.Drawing.Size(97, 22);
            this.rdoRect.TabIndex = 11;
            this.rdoRect.TabStop = true;
            this.rdoRect.Text = "Rectangle";
            this.rdoRect.UseVisualStyleBackColor = true;
            this.rdoRect.CheckedChanged += new System.EventHandler(this.RectRBtn_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.choiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // choiceToolStripMenuItem
            // 
            this.choiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.circleToolStripMenuItem,
            this.squareToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.choiceToolStripMenuItem.Name = "choiceToolStripMenuItem";
            this.choiceToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.choiceToolStripMenuItem.Text = "Choice";
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // cbShapes
            // 
            this.cbShapes.FormattingEnabled = true;
            this.cbShapes.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Rectangle"});
            this.cbShapes.Location = new System.Drawing.Point(33, 31);
            this.cbShapes.Name = "cbShapes";
            this.cbShapes.Size = new System.Drawing.Size(121, 24);
            this.cbShapes.TabIndex = 13;
            this.cbShapes.SelectedIndexChanged += new System.EventHandler(this.shapesCBox_SelectedIndexChanged);
            // 
            // comBox_groupBox
            // 
            this.comBox_groupBox.Controls.Add(this.cbShapes);
            this.comBox_groupBox.Location = new System.Drawing.Point(286, 41);
            this.comBox_groupBox.Name = "comBox_groupBox";
            this.comBox_groupBox.Size = new System.Drawing.Size(200, 75);
            this.comBox_groupBox.TabIndex = 14;
            this.comBox_groupBox.TabStop = false;
            this.comBox_groupBox.Text = "ComboBox";
            // 
            // comBox_listBox
            // 
            this.comBox_listBox.Controls.Add(this.lstShapes);
            this.comBox_listBox.Location = new System.Drawing.Point(286, 126);
            this.comBox_listBox.Name = "comBox_listBox";
            this.comBox_listBox.Size = new System.Drawing.Size(200, 96);
            this.comBox_listBox.TabIndex = 15;
            this.comBox_listBox.TabStop = false;
            this.comBox_listBox.Text = "ListBox";
            // 
            // lstShapes
            // 
            this.lstShapes.FormattingEnabled = true;
            this.lstShapes.ItemHeight = 16;
            this.lstShapes.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Rectangle"});
            this.lstShapes.Location = new System.Drawing.Point(7, 22);
            this.lstShapes.Name = "lstShapes";
            this.lstShapes.Size = new System.Drawing.Size(93, 68);
            this.lstShapes.TabIndex = 0;
            this.lstShapes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comBox_radioButtons
            // 
            this.comBox_radioButtons.Controls.Add(this.rdoSqr);
            this.comBox_radioButtons.Controls.Add(this.rdoCirc);
            this.comBox_radioButtons.Controls.Add(this.rdoRect);
            this.comBox_radioButtons.Location = new System.Drawing.Point(286, 228);
            this.comBox_radioButtons.Name = "comBox_radioButtons";
            this.comBox_radioButtons.Size = new System.Drawing.Size(200, 122);
            this.comBox_radioButtons.TabIndex = 16;
            this.comBox_radioButtons.TabStop = false;
            this.comBox_radioButtons.Text = "RadioButtons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comBox_radioButtons);
            this.Controls.Add(this.comBox_listBox);
            this.Controls.Add(this.comBox_groupBox);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txt_Input_bottom);
            this.Controls.Add(this.txt_Input_top);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lbl_Input_bottom);
            this.Controls.Add(this.lbl_Input_top);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Area";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.comBox_groupBox.ResumeLayout(false);
            this.comBox_listBox.ResumeLayout(false);
            this.comBox_radioButtons.ResumeLayout(false);
            this.comBox_radioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl_Input_top;
        private System.Windows.Forms.Label lbl_Input_bottom;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txt_Input_top;
        private System.Windows.Forms.TextBox txt_Input_bottom;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.RadioButton rdoCirc;
        private System.Windows.Forms.RadioButton rdoSqr;
        private System.Windows.Forms.RadioButton rdoRect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbShapes;
        private System.Windows.Forms.GroupBox comBox_groupBox;
        private System.Windows.Forms.GroupBox comBox_listBox;
        private System.Windows.Forms.ListBox lstShapes;
        private System.Windows.Forms.GroupBox comBox_radioButtons;
    }
}

