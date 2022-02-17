using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace companyRevenueChart
{
    public partial class coNameDialog : Form
    {
        Form1 myForm;               //the caller form 
        private Color CurrentColor; //to pass the color from the main form to the color form
        public string TitleText
        {
            get
            {
                if(newNameBox.Text == "")
                {
                    return currentNameBox.Text;
                }
                else
                {
                    return newNameBox.Text ;
                }
            }
            set
            {
                currentNameBox.Text = value;
            }
        }
        public int TitleSize
        {
            get
            {
                RadioButton tempBtn = null;     //used equal null to avoid the error of using unassigned value in the return statement
                bool notFound = true;
                for (var i = 0; i< size.Controls.Count && notFound; i++)
                {
                    tempBtn  = (RadioButton)(size.Controls[i]);
                    if (tempBtn.Checked == true)
                    {
                        notFound = false;
                    }
                }
                return int.Parse(tempBtn.Text);
            }
            set
            {
                if(value == 16 || value == 20 ||value == 24)
                {
                    //uncheck all
                    RadioButton tempBtn;
                    for (var i = 0; i < size.Controls.Count; i++)
                    {
                        tempBtn = (RadioButton)(size.Controls[i]);
                        tempBtn.Checked = false;
                    }
                    //check the correct one
                    switch (value)
                    {
                        case 16:
                            size16.Checked = true;
                            break;
                        case 20:
                            size20.Checked = true;
                            break;
                        case 24:
                            size24.Checked = true;
                            break;
                    }
                }
            }
        }
        public string TitleFont
        {
            get
            {
                //used equal null to avoid the error of using unassigned value in the return statement
                RadioButton tempBtn = null;     
                bool notFound = true;
                for (var i = 0; i < font.Controls.Count && notFound; i++)
                {
                    tempBtn = (RadioButton)(font.Controls[i]);
                    if (tempBtn.Checked == true)
                    {
                        notFound = false;
                    }
                }
                return tempBtn.Text;
            }
            set
            {
                if (value == "Times New Roman" || value == "Arial" || value == "Courier")
                {
                    //uncheck all
                    RadioButton tempBtn;
                    for (var i = 0; i < size.Controls.Count; i++)
                    {
                        tempBtn = (RadioButton)(size.Controls[i]);
                        tempBtn.Checked = false;
                    }
                    //check the correct one
                    switch (value)
                    {
                        case "Times New Roman":
                            TimesNewRoman.Checked = true;
                            break;
                        case "Arial":
                            Arial.Checked = true;
                            break;
                        case "Courier":
                            Courier.Checked = true;
                            break;
                    }
                }
            }
        }
        public Color TitleColor
        {
            get
            {
                return CurrentColor;
            }
            set
            {
                CurrentColor = value;
            }
        }


        public coNameDialog()
        {
            InitializeComponent();
        }
        public coNameDialog(Form1 frm)
        {
            InitializeComponent();
            myForm = frm;
        }

        private void openClrPalette_Click(object sender, EventArgs e)
        {
            DialogResult colorResult;
            colorDialog.Color = CurrentColor;
            colorResult = colorDialog.ShowDialog();
            if(colorResult == DialogResult.OK)
            {
                CurrentColor = colorDialog.Color;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            myForm.M_titleStr1 = this.TitleText;
            myForm.M_titleStrSize = this.TitleSize;
            myForm.M_titlefontName = this.TitleFont;
            myForm.M_titleColor = this.TitleColor;

            myForm.M_titlefont = new Font(myForm.M_titlefontName, myForm.M_titleStrSize, FontStyle.Underline);
            myForm.M_titleBrush = new SolidBrush(myForm.M_titleColor);
            myForm.M_titleStr1_size = myForm.CreateGraphics().MeasureString(myForm.M_titleStr1, myForm.M_titlefont);
            myForm.M_titleStr2_size = myForm.CreateGraphics().MeasureString(myForm.M_titleStr2, myForm.M_titlefont);

            myForm.Invalidate();
        }
    }
}
