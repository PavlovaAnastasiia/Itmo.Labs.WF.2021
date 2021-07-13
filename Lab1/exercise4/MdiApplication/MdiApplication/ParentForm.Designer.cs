
using System;
using System.Windows.Forms;

namespace MdiApplication
{
    partial class ParentForm
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spWin = new System.Windows.Forms.ToolStripStatusLabel();
            this.spData = new System.Windows.Forms.ToolStripStatusLabel();
            this.MdiMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.NewMenuItem,
            this.ExitMenuItem,
            this.WindowMenuItem,
            this.CascadeMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(432, 28);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "WindowMenuItem";
            this.MdiMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileMenuItem.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(53, 24);
            this.NewMenuItem.Text = "New";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(47, 24);
            this.ExitMenuItem.Text = "Exit";
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(78, 24);
            this.WindowMenuItem.Text = "Window";
            // 
            // CascadeMenuItem
            // 
            this.CascadeMenuItem.Name = "CascadeMenuItem";
            this.CascadeMenuItem.Size = new System.Drawing.Size(52, 24);
            this.CascadeMenuItem.Text = "Title";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spWin,
            this.spData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(432, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // spWin
            // 
            this.spWin.Name = "spWin";
            this.spWin.Size = new System.Drawing.Size(49, 20);
            this.spWin.Text = "Status";
            // 
            // spData
            // 
            this.spData.Name = "spData";
            this.spData.Size = new System.Drawing.Size(41, 20);
            this.spData.Text = "Data";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 303);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MdiMenu);
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        public ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem WindowMenuItem;
        private ToolStripMenuItem CascadeMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel spWin;
        private ToolStripStatusLabel spData;
    }
}

