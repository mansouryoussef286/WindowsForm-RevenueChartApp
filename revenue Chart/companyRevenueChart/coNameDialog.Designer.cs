
namespace companyRevenueChart
{
    partial class coNameDialog
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
            this.companyEdit = new System.Windows.Forms.TabControl();
            this.font = new System.Windows.Forms.TabPage();
            this.size = new System.Windows.Forms.TabPage();
            this.color = new System.Windows.Forms.TabPage();
            this.text = new System.Windows.Forms.TabPage();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.TimesNewRoman = new System.Windows.Forms.RadioButton();
            this.Arial = new System.Windows.Forms.RadioButton();
            this.Courier = new System.Windows.Forms.RadioButton();
            this.size16 = new System.Windows.Forms.RadioButton();
            this.size20 = new System.Windows.Forms.RadioButton();
            this.size24 = new System.Windows.Forms.RadioButton();
            this.openClrPalette = new System.Windows.Forms.Button();
            this.currentName = new System.Windows.Forms.Label();
            this.newName = new System.Windows.Forms.Label();
            this.currentNameBox = new System.Windows.Forms.TextBox();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.applyBtn = new System.Windows.Forms.Button();
            this.companyEdit.SuspendLayout();
            this.font.SuspendLayout();
            this.size.SuspendLayout();
            this.color.SuspendLayout();
            this.text.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyEdit
            // 
            this.companyEdit.AccessibleName = "companyEdit";
            this.companyEdit.Controls.Add(this.font);
            this.companyEdit.Controls.Add(this.size);
            this.companyEdit.Controls.Add(this.color);
            this.companyEdit.Controls.Add(this.text);
            this.companyEdit.Location = new System.Drawing.Point(0, 0);
            this.companyEdit.Name = "companyEdit";
            this.companyEdit.SelectedIndex = 0;
            this.companyEdit.Size = new System.Drawing.Size(361, 267);
            this.companyEdit.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.companyEdit.TabIndex = 0;
            // 
            // font
            // 
            this.font.AccessibleName = "";
            this.font.Controls.Add(this.Courier);
            this.font.Controls.Add(this.Arial);
            this.font.Controls.Add(this.TimesNewRoman);
            this.font.Location = new System.Drawing.Point(4, 22);
            this.font.Name = "font";
            this.font.Padding = new System.Windows.Forms.Padding(3);
            this.font.Size = new System.Drawing.Size(353, 241);
            this.font.TabIndex = 0;
            this.font.Text = "font";
            this.font.UseVisualStyleBackColor = true;
            // 
            // size
            // 
            this.size.Controls.Add(this.size24);
            this.size.Controls.Add(this.size20);
            this.size.Controls.Add(this.size16);
            this.size.Location = new System.Drawing.Point(4, 22);
            this.size.Name = "size";
            this.size.Padding = new System.Windows.Forms.Padding(3);
            this.size.Size = new System.Drawing.Size(353, 241);
            this.size.TabIndex = 1;
            this.size.Text = "size";
            this.size.UseVisualStyleBackColor = true;
            // 
            // color
            // 
            this.color.Controls.Add(this.openClrPalette);
            this.color.Location = new System.Drawing.Point(4, 22);
            this.color.Name = "color";
            this.color.Padding = new System.Windows.Forms.Padding(3);
            this.color.Size = new System.Drawing.Size(353, 241);
            this.color.TabIndex = 2;
            this.color.Text = "color";
            this.color.UseVisualStyleBackColor = true;
            // 
            // text
            // 
            this.text.Controls.Add(this.newNameBox);
            this.text.Controls.Add(this.currentNameBox);
            this.text.Controls.Add(this.newName);
            this.text.Controls.Add(this.currentName);
            this.text.Location = new System.Drawing.Point(4, 22);
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(3);
            this.text.Size = new System.Drawing.Size(353, 241);
            this.text.TabIndex = 3;
            this.text.Text = "text";
            this.text.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(61, 268);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(223, 268);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // TimesNewRoman
            // 
            this.TimesNewRoman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimesNewRoman.AutoSize = true;
            this.TimesNewRoman.Checked = true;
            this.TimesNewRoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimesNewRoman.Location = new System.Drawing.Point(120, 59);
            this.TimesNewRoman.Name = "TimesNewRoman";
            this.TimesNewRoman.Size = new System.Drawing.Size(112, 17);
            this.TimesNewRoman.TabIndex = 0;
            this.TimesNewRoman.TabStop = true;
            this.TimesNewRoman.Text = "Times New Roman";
            this.TimesNewRoman.UseVisualStyleBackColor = true;
            // 
            // Arial
            // 
            this.Arial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Arial.AutoSize = true;
            this.Arial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arial.Location = new System.Drawing.Point(120, 104);
            this.Arial.Name = "Arial";
            this.Arial.Size = new System.Drawing.Size(46, 17);
            this.Arial.TabIndex = 1;
            this.Arial.Text = "Arial";
            this.Arial.UseVisualStyleBackColor = true;
            // 
            // Courier
            // 
            this.Courier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Courier.AutoSize = true;
            this.Courier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Courier.Location = new System.Drawing.Point(120, 154);
            this.Courier.Name = "Courier";
            this.Courier.Size = new System.Drawing.Size(60, 17);
            this.Courier.TabIndex = 2;
            this.Courier.Text = "Courier";
            this.Courier.UseVisualStyleBackColor = true;
            // 
            // size16
            // 
            this.size16.AutoSize = true;
            this.size16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.size16.Location = new System.Drawing.Point(157, 75);
            this.size16.Name = "size16";
            this.size16.Size = new System.Drawing.Size(37, 17);
            this.size16.TabIndex = 0;
            this.size16.Text = "16";
            this.size16.UseVisualStyleBackColor = true;
            // 
            // size20
            // 
            this.size20.AutoSize = true;
            this.size20.Checked = true;
            this.size20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.size20.Location = new System.Drawing.Point(157, 110);
            this.size20.Name = "size20";
            this.size20.Size = new System.Drawing.Size(37, 17);
            this.size20.TabIndex = 1;
            this.size20.TabStop = true;
            this.size20.Text = "20";
            this.size20.UseVisualStyleBackColor = true;
            // 
            // size24
            // 
            this.size24.AutoSize = true;
            this.size24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.size24.Location = new System.Drawing.Point(157, 143);
            this.size24.Name = "size24";
            this.size24.Size = new System.Drawing.Size(37, 17);
            this.size24.TabIndex = 2;
            this.size24.Text = "24";
            this.size24.UseVisualStyleBackColor = true;
            // 
            // openClrPalette
            // 
            this.openClrPalette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openClrPalette.Location = new System.Drawing.Point(115, 99);
            this.openClrPalette.Name = "openClrPalette";
            this.openClrPalette.Size = new System.Drawing.Size(120, 30);
            this.openClrPalette.TabIndex = 0;
            this.openClrPalette.Text = "open color Palette";
            this.openClrPalette.UseVisualStyleBackColor = true;
            this.openClrPalette.Click += new System.EventHandler(this.openClrPalette_Click);
            // 
            // currentName
            // 
            this.currentName.AutoSize = true;
            this.currentName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.currentName.Location = new System.Drawing.Point(75, 73);
            this.currentName.Name = "currentName";
            this.currentName.Size = new System.Drawing.Size(55, 17);
            this.currentName.TabIndex = 0;
            this.currentName.Text = "Current";
            // 
            // newName
            // 
            this.newName.AutoSize = true;
            this.newName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.newName.Location = new System.Drawing.Point(80, 111);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(34, 17);
            this.newName.TabIndex = 1;
            this.newName.Text = "New";
            // 
            // currentNameBox
            // 
            this.currentNameBox.Enabled = false;
            this.currentNameBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.currentNameBox.Location = new System.Drawing.Point(136, 73);
            this.currentNameBox.Name = "currentNameBox";
            this.currentNameBox.Size = new System.Drawing.Size(140, 20);
            this.currentNameBox.TabIndex = 2;
            // 
            // newNameBox
            // 
            this.newNameBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.newNameBox.Location = new System.Drawing.Point(136, 111);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(140, 20);
            this.newNameBox.TabIndex = 3;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(142, 268);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // coNameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 303);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.companyEdit);
            this.Name = "coNameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Company name ";
            this.companyEdit.ResumeLayout(false);
            this.font.ResumeLayout(false);
            this.font.PerformLayout();
            this.size.ResumeLayout(false);
            this.size.PerformLayout();
            this.color.ResumeLayout(false);
            this.text.ResumeLayout(false);
            this.text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl companyEdit;
        private System.Windows.Forms.TabPage font;
        private System.Windows.Forms.TabPage size;
        private System.Windows.Forms.TabPage color;
        private System.Windows.Forms.TabPage text;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.RadioButton Courier;
        private System.Windows.Forms.RadioButton Arial;
        private System.Windows.Forms.RadioButton TimesNewRoman;
        private System.Windows.Forms.RadioButton size24;
        private System.Windows.Forms.RadioButton size20;
        private System.Windows.Forms.RadioButton size16;
        private System.Windows.Forms.Button openClrPalette;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.TextBox currentNameBox;
        private System.Windows.Forms.Label newName;
        private System.Windows.Forms.Label currentName;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button applyBtn;
    }
}