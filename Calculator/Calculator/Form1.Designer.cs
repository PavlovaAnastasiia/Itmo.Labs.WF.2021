
namespace Calculator
{
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.KeyEqual = new System.Windows.Forms.Button();
            this.KeyPoint = new System.Windows.Forms.Button();
            this.KeyZero = new System.Windows.Forms.Button();
            this.KeySign = new System.Windows.Forms.Button();
            this.KeyPlus = new System.Windows.Forms.Button();
            this.KeyNine = new System.Windows.Forms.Button();
            this.KeyEight = new System.Windows.Forms.Button();
            this.KeySeven = new System.Windows.Forms.Button();
            this.KeyMinus = new System.Windows.Forms.Button();
            this.KeySix = new System.Windows.Forms.Button();
            this.KeyFive = new System.Windows.Forms.Button();
            this.KeyFour = new System.Windows.Forms.Button();
            this.KeyMultiply = new System.Windows.Forms.Button();
            this.KeyThree = new System.Windows.Forms.Button();
            this.KeyTwo = new System.Windows.Forms.Button();
            this.KeyOne = new System.Windows.Forms.Button();
            this.KeyDivide = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.KeyClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VersionInfo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.KeyEqual);
            this.panel1.Controls.Add(this.KeyPoint);
            this.panel1.Controls.Add(this.KeyZero);
            this.panel1.Controls.Add(this.KeySign);
            this.panel1.Controls.Add(this.KeyPlus);
            this.panel1.Controls.Add(this.KeyNine);
            this.panel1.Controls.Add(this.KeyEight);
            this.panel1.Controls.Add(this.KeySeven);
            this.panel1.Controls.Add(this.KeyMinus);
            this.panel1.Controls.Add(this.KeySix);
            this.panel1.Controls.Add(this.KeyFive);
            this.panel1.Controls.Add(this.KeyFour);
            this.panel1.Controls.Add(this.KeyMultiply);
            this.panel1.Controls.Add(this.KeyThree);
            this.panel1.Controls.Add(this.KeyTwo);
            this.panel1.Controls.Add(this.KeyOne);
            this.panel1.Controls.Add(this.KeyDivide);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.KeyClear);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.VersionInfo);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 498);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 30);
            this.button4.TabIndex = 25;
            this.button4.Text = "%";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyEqual
            // 
            this.KeyEqual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyEqual.Location = new System.Drawing.Point(211, 425);
            this.KeyEqual.Name = "KeyEqual";
            this.KeyEqual.Size = new System.Drawing.Size(70, 70);
            this.KeyEqual.TabIndex = 24;
            this.KeyEqual.Text = "=";
            this.KeyEqual.UseVisualStyleBackColor = false;
            this.KeyEqual.Click += new System.EventHandler(this.KeyEqual_Click);
            // 
            // KeyPoint
            // 
            this.KeyPoint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPoint.Location = new System.Drawing.Point(141, 425);
            this.KeyPoint.Name = "KeyPoint";
            this.KeyPoint.Size = new System.Drawing.Size(70, 70);
            this.KeyPoint.TabIndex = 23;
            this.KeyPoint.Text = ",";
            this.KeyPoint.UseVisualStyleBackColor = false;
            this.KeyPoint.Click += new System.EventHandler(this.KeyPoint_Click);
            // 
            // KeyZero
            // 
            this.KeyZero.BackColor = System.Drawing.SystemColors.Info;
            this.KeyZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyZero.Location = new System.Drawing.Point(71, 425);
            this.KeyZero.Name = "KeyZero";
            this.KeyZero.Size = new System.Drawing.Size(70, 70);
            this.KeyZero.TabIndex = 22;
            this.KeyZero.Text = "0";
            this.KeyZero.UseVisualStyleBackColor = false;
            this.KeyZero.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeySign
            // 
            this.KeySign.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeySign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySign.Location = new System.Drawing.Point(2, 425);
            this.KeySign.Name = "KeySign";
            this.KeySign.Size = new System.Drawing.Size(70, 70);
            this.KeySign.TabIndex = 21;
            this.KeySign.Text = "±";
            this.KeySign.UseVisualStyleBackColor = false;
            this.KeySign.Click += new System.EventHandler(this.button21_Click);
            // 
            // KeyPlus
            // 
            this.KeyPlus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPlus.Location = new System.Drawing.Point(211, 355);
            this.KeyPlus.Name = "KeyPlus";
            this.KeyPlus.Size = new System.Drawing.Size(70, 70);
            this.KeyPlus.TabIndex = 20;
            this.KeyPlus.Text = "+";
            this.KeyPlus.UseVisualStyleBackColor = false;
            this.KeyPlus.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeyNine
            // 
            this.KeyNine.BackColor = System.Drawing.SystemColors.Info;
            this.KeyNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyNine.Location = new System.Drawing.Point(141, 355);
            this.KeyNine.Name = "KeyNine";
            this.KeyNine.Size = new System.Drawing.Size(70, 70);
            this.KeyNine.TabIndex = 19;
            this.KeyNine.Text = "9";
            this.KeyNine.UseVisualStyleBackColor = false;
            this.KeyNine.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyEight
            // 
            this.KeyEight.BackColor = System.Drawing.SystemColors.Info;
            this.KeyEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyEight.Location = new System.Drawing.Point(71, 355);
            this.KeyEight.Name = "KeyEight";
            this.KeyEight.Size = new System.Drawing.Size(70, 70);
            this.KeyEight.TabIndex = 18;
            this.KeyEight.Text = "8";
            this.KeyEight.UseVisualStyleBackColor = false;
            this.KeyEight.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeySeven
            // 
            this.KeySeven.BackColor = System.Drawing.SystemColors.Info;
            this.KeySeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeySeven.Location = new System.Drawing.Point(2, 355);
            this.KeySeven.Name = "KeySeven";
            this.KeySeven.Size = new System.Drawing.Size(70, 70);
            this.KeySeven.TabIndex = 17;
            this.KeySeven.Text = "7";
            this.KeySeven.UseVisualStyleBackColor = false;
            this.KeySeven.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyMinus
            // 
            this.KeyMinus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyMinus.Location = new System.Drawing.Point(211, 285);
            this.KeyMinus.Name = "KeyMinus";
            this.KeyMinus.Size = new System.Drawing.Size(70, 70);
            this.KeyMinus.TabIndex = 16;
            this.KeyMinus.Text = "-";
            this.KeyMinus.UseVisualStyleBackColor = false;
            this.KeyMinus.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeySix
            // 
            this.KeySix.BackColor = System.Drawing.SystemColors.Info;
            this.KeySix.Location = new System.Drawing.Point(141, 285);
            this.KeySix.Name = "KeySix";
            this.KeySix.Size = new System.Drawing.Size(70, 70);
            this.KeySix.TabIndex = 15;
            this.KeySix.Text = "6";
            this.KeySix.UseVisualStyleBackColor = false;
            this.KeySix.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyFive
            // 
            this.KeyFive.BackColor = System.Drawing.SystemColors.Info;
            this.KeyFive.Location = new System.Drawing.Point(71, 285);
            this.KeyFive.Name = "KeyFive";
            this.KeyFive.Size = new System.Drawing.Size(70, 70);
            this.KeyFive.TabIndex = 14;
            this.KeyFive.Text = "5";
            this.KeyFive.UseVisualStyleBackColor = false;
            this.KeyFive.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyFour
            // 
            this.KeyFour.BackColor = System.Drawing.SystemColors.Info;
            this.KeyFour.Location = new System.Drawing.Point(2, 285);
            this.KeyFour.Name = "KeyFour";
            this.KeyFour.Size = new System.Drawing.Size(70, 70);
            this.KeyFour.TabIndex = 13;
            this.KeyFour.Text = "4";
            this.KeyFour.UseVisualStyleBackColor = false;
            this.KeyFour.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyMultiply
            // 
            this.KeyMultiply.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyMultiply.Location = new System.Drawing.Point(211, 215);
            this.KeyMultiply.Name = "KeyMultiply";
            this.KeyMultiply.Size = new System.Drawing.Size(70, 70);
            this.KeyMultiply.TabIndex = 12;
            this.KeyMultiply.Text = "×";
            this.KeyMultiply.UseVisualStyleBackColor = false;
            this.KeyMultiply.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // KeyThree
            // 
            this.KeyThree.BackColor = System.Drawing.SystemColors.Info;
            this.KeyThree.Location = new System.Drawing.Point(141, 215);
            this.KeyThree.Name = "KeyThree";
            this.KeyThree.Size = new System.Drawing.Size(70, 70);
            this.KeyThree.TabIndex = 11;
            this.KeyThree.Text = "3";
            this.KeyThree.UseVisualStyleBackColor = false;
            this.KeyThree.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyTwo
            // 
            this.KeyTwo.BackColor = System.Drawing.SystemColors.Info;
            this.KeyTwo.Location = new System.Drawing.Point(71, 215);
            this.KeyTwo.Name = "KeyTwo";
            this.KeyTwo.Size = new System.Drawing.Size(70, 70);
            this.KeyTwo.TabIndex = 10;
            this.KeyTwo.Text = "2";
            this.KeyTwo.UseVisualStyleBackColor = false;
            this.KeyTwo.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyOne
            // 
            this.KeyOne.BackColor = System.Drawing.SystemColors.Info;
            this.KeyOne.Location = new System.Drawing.Point(2, 215);
            this.KeyOne.Name = "KeyOne";
            this.KeyOne.Size = new System.Drawing.Size(70, 70);
            this.KeyOne.TabIndex = 9;
            this.KeyOne.Text = "1";
            this.KeyOne.UseVisualStyleBackColor = false;
            this.KeyOne.Click += new System.EventHandler(this.KeyOne_Click);
            // 
            // KeyDivide
            // 
            this.KeyDivide.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyDivide.Location = new System.Drawing.Point(211, 145);
            this.KeyDivide.Name = "KeyDivide";
            this.KeyDivide.Size = new System.Drawing.Size(70, 70);
            this.KeyDivide.TabIndex = 8;
            this.KeyDivide.Text = "÷";
            this.KeyDivide.UseVisualStyleBackColor = false;
            this.KeyDivide.Click += new System.EventHandler(this.KeyDivide_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button7.Location = new System.Drawing.Point(141, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 7;
            this.button7.Text = "⌫";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Location = new System.Drawing.Point(71, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 6;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // KeyClear
            // 
            this.KeyClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.KeyClear.Location = new System.Drawing.Point(2, 145);
            this.KeyClear.Name = "KeyClear";
            this.KeyClear.Size = new System.Drawing.Size(70, 70);
            this.KeyClear.TabIndex = 5;
            this.KeyClear.Text = "CE";
            this.KeyClear.UseVisualStyleBackColor = false;
            this.KeyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "1/x";
            this.toolTip3.SetToolTip(this.button3, "Позволяет перевернуть выражение");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "√";
            this.toolTip2.SetToolTip(this.button2, "Поиск подкоренного выражения");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(2, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "x²";
            this.toolTip1.SetToolTip(this.button1, "Возведение в квадрат");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VersionInfo
            // 
            this.VersionInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionInfo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.VersionInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VersionInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VersionInfo.Enabled = false;
            this.VersionInfo.Font = new System.Drawing.Font("Yu Gothic UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionInfo.Location = new System.Drawing.Point(0, 28);
            this.VersionInfo.Margin = new System.Windows.Forms.Padding(0);
            this.VersionInfo.MinimumSize = new System.Drawing.Size(2, 85);
            this.VersionInfo.Name = "VersionInfo";
            this.VersionInfo.Size = new System.Drawing.Size(281, 85);
            this.VersionInfo.TabIndex = 0;
            this.VersionInfo.Click += new System.EventHandler(this.VersionInfo_Click);
            this.VersionInfo.TextChanged += new System.EventHandler(this.VersionInfo_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            this.инженерныйToolStripMenuItem.Click += new System.EventHandler(this.инженерныйToolStripMenuItem_Click);
            // 
            // стандартныйToolStripMenuItem
            // 
            this.стандартныйToolStripMenuItem.Name = "стандартныйToolStripMenuItem";
            this.стандартныйToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.стандартныйToolStripMenuItem.Text = "Стандартный";
            this.стандартныйToolStripMenuItem.Click += new System.EventHandler(this.стандартныйToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(45, 24);
            this.toolStripMenuItem2.Text = "info";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(281, 498);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KeyMinus;
        private System.Windows.Forms.Button KeySix;
        private System.Windows.Forms.Button KeyFive;
        private System.Windows.Forms.Button KeyFour;
        private System.Windows.Forms.Button KeyMultiply;
        private System.Windows.Forms.Button KeyThree;
        private System.Windows.Forms.Button KeyTwo;
        private System.Windows.Forms.Button KeyOne;
        private System.Windows.Forms.Button KeyDivide;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button KeyClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VersionInfo;
        private System.Windows.Forms.Button KeyEqual;
        private System.Windows.Forms.Button KeyPoint;
        private System.Windows.Forms.Button KeyZero;
        private System.Windows.Forms.Button KeySign;
        private System.Windows.Forms.Button KeyPlus;
        private System.Windows.Forms.Button KeyNine;
        private System.Windows.Forms.Button KeyEight;
        private System.Windows.Forms.Button KeySeven;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инженерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

