
namespace companyRevenueChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lineColor = new System.Windows.Forms.ToolStripLabel();
            this.red = new System.Windows.Forms.ToolStripButton();
            this.green = new System.Windows.Forms.ToolStripButton();
            this.blue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lineStyle = new System.Windows.Forms.ToolStripLabel();
            this.solid = new System.Windows.Forms.ToolStripButton();
            this.dash = new System.Windows.Forms.ToolStripButton();
            this.dotted = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BarColor = new System.Windows.Forms.ToolStripLabel();
            this.redBar = new System.Windows.Forms.ToolStripButton();
            this.greenBar = new System.Windows.Forms.ToolStripButton();
            this.blueBar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.barStyle = new System.Windows.Forms.ToolStripLabel();
            this.leftBar = new System.Windows.Forms.ToolStripButton();
            this.rightBar = new System.Windows.Forms.ToolStripButton();
            this.crossBar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineColor,
            this.red,
            this.green,
            this.blue,
            this.toolStripSeparator1,
            this.lineStyle,
            this.solid,
            this.dash,
            this.dotted,
            this.toolStripSeparator2,
            this.BarColor,
            this.redBar,
            this.greenBar,
            this.blueBar,
            this.toolStripSeparator3,
            this.barStyle,
            this.leftBar,
            this.rightBar,
            this.crossBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lineColor
            // 
            this.lineColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineColor.Name = "lineColor";
            this.lineColor.Size = new System.Drawing.Size(61, 22);
            this.lineColor.Text = "Line Color";
            // 
            // red
            // 
            this.red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.red.ForeColor = System.Drawing.Color.Red;
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(31, 22);
            this.red.Text = "Red";
            this.red.Click += new System.EventHandler(this.redLineMenuItem_click);
            // 
            // green
            // 
            this.green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(42, 22);
            this.green.Text = "Green";
            this.green.Click += new System.EventHandler(this.greenLineMenuItem_click);
            // 
            // blue
            // 
            this.blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blue.ForeColor = System.Drawing.Color.Blue;
            this.blue.Image = ((System.Drawing.Image)(resources.GetObject("blue.Image")));
            this.blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(34, 22);
            this.blue.Text = "Blue";
            this.blue.Click += new System.EventHandler(this.blueLineMenuItem_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lineStyle
            // 
            this.lineStyle.Name = "lineStyle";
            this.lineStyle.Size = new System.Drawing.Size(59, 22);
            this.lineStyle.Text = "Line style:";
            // 
            // solid
            // 
            this.solid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.solid.Image = ((System.Drawing.Image)(resources.GetObject("solid.Image")));
            this.solid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(23, 22);
            this.solid.Text = "__";
            this.solid.Click += new System.EventHandler(this.solidLineMenuItem_click);
            // 
            // dash
            // 
            this.dash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dash.Image = ((System.Drawing.Image)(resources.GetObject("dash.Image")));
            this.dash.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(24, 22);
            this.dash.Text = "- -";
            this.dash.Click += new System.EventHandler(this.dashLineMenuItem_click);
            // 
            // dotted
            // 
            this.dotted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dotted.Image = ((System.Drawing.Image)(resources.GetObject("dotted.Image")));
            this.dotted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dotted.Name = "dotted";
            this.dotted.Size = new System.Drawing.Size(26, 22);
            this.dotted.Text = ". . .";
            this.dotted.Click += new System.EventHandler(this.dottedLineMenuItem_click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BarColor
            // 
            this.BarColor.Name = "BarColor";
            this.BarColor.Size = new System.Drawing.Size(57, 22);
            this.BarColor.Text = "Bar color:";
            // 
            // redBar
            // 
            this.redBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.redBar.ForeColor = System.Drawing.Color.Red;
            this.redBar.Image = ((System.Drawing.Image)(resources.GetObject("redBar.Image")));
            this.redBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redBar.Name = "redBar";
            this.redBar.Size = new System.Drawing.Size(31, 22);
            this.redBar.Text = "Red";
            this.redBar.Click += new System.EventHandler(this.redRectMenuItem_click);
            // 
            // greenBar
            // 
            this.greenBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.greenBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenBar.Image = ((System.Drawing.Image)(resources.GetObject("greenBar.Image")));
            this.greenBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenBar.Name = "greenBar";
            this.greenBar.Size = new System.Drawing.Size(42, 22);
            this.greenBar.Text = "Green";
            this.greenBar.Click += new System.EventHandler(this.greenRectMenuItem_click);
            // 
            // blueBar
            // 
            this.blueBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blueBar.ForeColor = System.Drawing.Color.Blue;
            this.blueBar.Image = ((System.Drawing.Image)(resources.GetObject("blueBar.Image")));
            this.blueBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueBar.Name = "blueBar";
            this.blueBar.Size = new System.Drawing.Size(34, 22);
            this.blueBar.Text = "Blue";
            this.blueBar.Click += new System.EventHandler(this.blueRectMenuItem_click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // barStyle
            // 
            this.barStyle.Name = "barStyle";
            this.barStyle.Size = new System.Drawing.Size(54, 22);
            this.barStyle.Text = "Bar style:";
            // 
            // leftBar
            // 
            this.leftBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.leftBar.Image = ((System.Drawing.Image)(resources.GetObject("leftBar.Image")));
            this.leftBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(23, 22);
            this.leftBar.Text = "\\";
            this.leftBar.Click += new System.EventHandler(this.leftRectMenuItem_click);
            // 
            // rightBar
            // 
            this.rightBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rightBar.Image = ((System.Drawing.Image)(resources.GetObject("rightBar.Image")));
            this.rightBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightBar.Name = "rightBar";
            this.rightBar.Size = new System.Drawing.Size(23, 22);
            this.rightBar.Text = "/";
            this.rightBar.Click += new System.EventHandler(this.rightRectMenuItem_click);
            // 
            // crossBar
            // 
            this.crossBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.crossBar.Image = ((System.Drawing.Image)(resources.GetObject("crossBar.Image")));
            this.crossBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.crossBar.Name = "crossBar";
            this.crossBar.Size = new System.Drawing.Size(23, 22);
            this.crossBar.Text = "+";
            this.crossBar.Click += new System.EventHandler(this.crossRectMenuItem_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Revenue Chart";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lineColor;
        private System.Windows.Forms.ToolStripButton red;
        private System.Windows.Forms.ToolStripButton green;
        private System.Windows.Forms.ToolStripButton blue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lineStyle;
        private System.Windows.Forms.ToolStripButton solid;
        private System.Windows.Forms.ToolStripButton dash;
        private System.Windows.Forms.ToolStripButton dotted;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel BarColor;
        private System.Windows.Forms.ToolStripButton redBar;
        private System.Windows.Forms.ToolStripButton greenBar;
        private System.Windows.Forms.ToolStripButton blueBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel barStyle;
        private System.Windows.Forms.ToolStripButton leftBar;
        private System.Windows.Forms.ToolStripButton rightBar;
        private System.Windows.Forms.ToolStripButton crossBar;
    }
}

