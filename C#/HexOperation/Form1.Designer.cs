using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HexOperation
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Main : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            txtfile = new TextBox();
            Label1 = new Label();
            txtvalue = new TextBox();
            Label2 = new Label();
            txtreplace = new TextBox();
            Label3 = new Label();
            btn_browse = new Button();
            btn_browse.Click += new EventHandler(btn_browse_Click);
            btn_replace = new Button();
            btn_replace.Click += new EventHandler(btn_replace_Click);
            SuspendLayout();
            // 
            // txtfile
            // 
            txtfile.Location = new Point(99, 26);
            txtfile.Name = "txtfile";
            txtfile.Size = new Size(196, 20);
            txtfile.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 13);
            Label1.TabIndex = 1;
            Label1.Text = "Location : ";
            // 
            // txtvalue
            // 
            txtvalue.Location = new Point(99, 52);
            txtvalue.Name = "txtvalue";
            txtvalue.Size = new Size(145, 20);
            txtvalue.TabIndex = 0;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 55);
            Label2.Name = "Label2";
            Label2.Size = new Size(81, 13);
            Label2.TabIndex = 1;
            Label2.Text = "Original String : ";
            // 
            // txtreplace
            // 
            txtreplace.Location = new Point(99, 78);
            txtreplace.Name = "txtreplace";
            txtreplace.Size = new Size(145, 20);
            txtreplace.TabIndex = 0;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(12, 81);
            Label3.Name = "Label3";
            Label3.Size = new Size(89, 13);
            Label3.TabIndex = 1;
            Label3.Text = "Replaced String :";
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(301, 24);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(75, 23);
            btn_browse.TabIndex = 2;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            // 
            // btn_replace
            // 
            btn_replace.Location = new Point(301, 76);
            btn_replace.Name = "btn_replace";
            btn_replace.Size = new Size(75, 23);
            btn_replace.TabIndex = 2;
            btn_replace.Text = "Replace";
            btn_replace.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 132);
            Controls.Add(btn_replace);
            Controls.Add(btn_browse);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(txtreplace);
            Controls.Add(txtvalue);
            Controls.Add(txtfile);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hex Operation";
            ResumeLayout(false);
            PerformLayout();

        }

        internal TextBox txtfile;
        internal Label Label1;
        internal TextBox txtvalue;
        internal Label Label2;
        internal TextBox txtreplace;
        internal Label Label3;
        internal Button btn_browse;
        internal Button btn_replace;
    }
}