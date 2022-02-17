using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace companyRevenueChart
{
    public partial class Form1 : Form
    {
        //initializing the data 2d array
        int[,] annualRevenue = {{1988, 140 },{1989,320},{1990,110}, { 1991, 175 }, { 1992, 200 },
                               {1993, 300 },{1994,120},{1995,240}, { 1996, 210 }, { 1997, 190 }};
        //declaring the graphics of the form
        Graphics g;
        //declaring the used elements
        #region title string
        //declaring the string title variables
        string m_titleStr1;
        string m_titleStr2;
        int m_titleStrSize;
        string m_titlefontName;
        Font m_titlefont;
        Color m_titleColor;
        Brush m_titleBrush;
        SizeF m_titleStr1_size;
        PointF m_titleLoc1;
        SizeF m_titleStr2_size;
        PointF m_titleLoc2;
        //title string properties to be used in the dialog apply button
        public string M_titleStr1 {get{ return m_titleStr1; }set{ m_titleStr1 = value; }}
        public string M_titleStr2 { get { return m_titleStr2; } set { m_titleStr2 = value; } }
        public int M_titleStrSize { get { return m_titleStrSize; } set { m_titleStrSize = value; } }
        public string M_titlefontName { get { return m_titlefontName; } set { m_titlefontName = value; } }
        public Color M_titleColor { get { return m_titleColor; } set { m_titleColor = value; } }
        public Font M_titlefont { get { return m_titlefont; } set { m_titlefont = value; } }
        public Brush M_titleBrush { get { return m_titleBrush; } set { m_titleBrush = value; } }
        public SizeF M_titleStr1_size { get { return m_titleStr1_size; } set { m_titleStr1_size = value; } }
        public SizeF M_titleStr2_size { get { return m_titleStr2_size; } set { m_titleStr2_size = value; } }
        #endregion
        #region table frame
        //declaring the table frame variables
        Pen m_tableFramePen;
        Color m_tableFrameColor;
        Brush m_tableFrameBrush;
        Rectangle m_tableFrame;
        Size m_tableFrameSize;
        Point m_tableFrameLoc;
        //declaring the table columns separator line variables
        Point m_tableSepLoc1;
        Point m_tableSepLoc2;
        //declaring the table rows separator line variables
        Point m_tableRowLoc1;
        Point m_tableRowLoc2;
        int yTableIncrement;
        #endregion
        #region table strings
        //declaring the table strings variables
        string m_tableStr;
        Font m_tablefont;
        Color m_tableColor;
        Brush m_tableBrush;
        PointF m_tableStrLoc;
        #endregion
        #region chart 
        //declaring chart lines variables
        Brush m_chartBrush;
        Color m_chartColor;
        Pen m_chartPen;
        Pen m_incrementPen;
        Point m_chartBaseP;
        Point m_chartP1;
        Point m_chartP2;
        float xChartIncrement;
        float yChartIncrement;
        int revenueIncrement;
        //chart graph 
        Color m_chartGraphColor;
        Brush m_chartGraphBrush;
        DashStyle m_chartGraphPenDashStyle;
        Pen m_chartGraphPen;
        List<Point> m_chartPointsList;
        Point[] m_chartPoints;
        //bar chart
        Color m_BarChartColor;
        HatchStyle m_BarChartHatch;
        HatchBrush m_BarChartBrush;
        Rectangle m_BarChartRect;
        Size m_BarChartSize;
        Point m_BarChartLoc;
        //declaring the chart strings variables
        string m_chartStr;
        Font m_chartfont;
        Color m_chartstrColor;
        Brush m_chartstrBrush;
        SizeF m_chartStr_size;
        PointF m_chartStrLoc;
        #endregion
        #region Main menu
        //main menu strip
        MenuStrip mainMenuBar;
        //top level menu items
        //line
        ToolStripMenuItem lineMainMenuItem;
        //drop down menu items
        ToolStripMenuItem colorLineMenuItem;
        ToolStripMenuItem styleLineMenuItem;
        //sub drop down menu items
        //color
        ToolStripMenuItem redLineMenuItem;
        ToolStripMenuItem greenLineMenuItem;
        ToolStripMenuItem blueLineMenuItem;
        //style
        ToolStripMenuItem solidLineMenuItem;
        ToolStripMenuItem dashLineMenuItem;
        ToolStripMenuItem dottedLineMenuItem;
        //rectangle
        ToolStripMenuItem rectMainMenuItem;
        //drop down menu items
        ToolStripMenuItem colorRectMenuItem;
        ToolStripMenuItem styleRectMenuItem;
        //sub drop down menu items
        //color
        ToolStripMenuItem redRectMenuItem;
        ToolStripMenuItem greenRectMenuItem;
        ToolStripMenuItem blueRectMenuItem;
        //style
        ToolStripMenuItem rightRectMenuItem;
        ToolStripMenuItem leftRectMenuItem;
        ToolStripMenuItem crossRectMenuItem;
        //format
        ToolStripMenuItem formatMainMenuItem;
        //drop down menu items
        ToolStripMenuItem coNameFormatMenuItem;
        #endregion
        #region Context menu
        //context menu strip
        ContextMenuStrip LineContextMenu;

        ToolStripMenuItem colorLineContextMenuItem;
        ToolStripMenuItem styleLineContextMenuItem;
        ToolStripMenuItem redLineContextMenuItem;
        ToolStripMenuItem greenLineContextMenuItem;
        ToolStripMenuItem blueLineContextMenuItem;
        ToolStripMenuItem solidLineContextMenuItem;
        ToolStripMenuItem dashLineContextMenuItem;
        ToolStripMenuItem dottedLineContextMenuItem;
        //rectangle
        ContextMenuStrip rectContextMenu;

        ToolStripMenuItem colorRectContextMenuItem;
        ToolStripMenuItem styleRectContextMenuItem;
        ToolStripMenuItem redRectContextMenuItem;
        ToolStripMenuItem greenRectContextMenuItem;
        ToolStripMenuItem blueRectContextMenuItem;
        ToolStripMenuItem rightRectContextMenuItem;
        ToolStripMenuItem leftRectContextMenuItem;
        ToolStripMenuItem crossRectContextMenuItem;
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            //maximizing the window
            this.WindowState = FormWindowState.Maximized;
            #region visuals
            //initializing the graphics object
            g = this.CreateGraphics();
            //initializing the title fields
            m_titleStr1 = "ABC Company";
            m_titleStr2 = "Annual Revenue";
            m_titleStrSize = 16;
            m_titlefontName = "times new roman";
            m_titlefont = new Font(m_titlefontName, m_titleStrSize, FontStyle.Underline);
            m_titleColor = Color.Red;
            m_titleBrush = new SolidBrush(m_titleColor);
            m_titleStr1_size = g.MeasureString(m_titleStr1, m_titlefont);
            m_titleStr2_size = g.MeasureString(m_titleStr2, m_titlefont);
            //initializing the table frame fields  
            m_tableFrameColor = Color.Black;
            m_tableFrameBrush = new SolidBrush(m_tableFrameColor);
            m_tableFramePen = new Pen(m_tableFrameBrush, 3);
            //initializing the table strings fields
            m_tablefont = new Font("times new roman", 15, FontStyle.Bold);
            m_tableColor = Color.DodgerBlue;
            m_tableBrush = new SolidBrush(m_tableColor);
            //initializing the chart fields
            revenueIncrement = 30;
            m_chartColor = Color.Blue;
            m_chartBrush = new SolidBrush(m_chartColor);
            m_chartPen = new Pen(m_chartBrush, 5);
            m_chartPen.EndCap = LineCap.ArrowAnchor;
            m_incrementPen = new Pen(m_chartBrush, 3);
            //graph chart
            m_chartGraphColor = Color.Blue;
            m_chartGraphBrush = new SolidBrush(m_chartGraphColor);
            m_chartGraphPenDashStyle = DashStyle.Solid;
            m_chartGraphPen = new Pen(m_chartGraphBrush, 3);
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            m_chartfont = new Font("times new roman", 15, FontStyle.Bold);
            m_chartstrColor = Color.Black;
            m_chartstrBrush = new SolidBrush(m_chartstrColor);
            //bar chart
            m_BarChartColor = Color.DarkSeaGreen;
            m_BarChartHatch = HatchStyle.ForwardDiagonal;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            #endregion
            #region menus
            //
            //initializing the menu items
            //
            mainMenuBar = new MenuStrip();
            //line
            lineMainMenuItem = new ToolStripMenuItem("&Line");
            colorLineMenuItem = new ToolStripMenuItem("&Color");
            styleLineMenuItem = new ToolStripMenuItem("&Style");
            redLineMenuItem = new ToolStripMenuItem("&Red");
            greenLineMenuItem = new ToolStripMenuItem("&Green");
            blueLineMenuItem = new ToolStripMenuItem("&Blue");
            solidLineMenuItem = new ToolStripMenuItem("&Solid");
            dashLineMenuItem = new ToolStripMenuItem("&Dash");
            dottedLineMenuItem = new ToolStripMenuItem("Do&tted");
            //assigning the functions to the menu items click
            redLineMenuItem.Click += new EventHandler(this.redLineMenuItem_click);
            greenLineMenuItem.Click += new EventHandler(this.greenLineMenuItem_click);
            blueLineMenuItem.Click += new EventHandler(this.blueLineMenuItem_click);
            solidLineMenuItem.Click += new EventHandler(this.solidLineMenuItem_click);
            dashLineMenuItem.Click += new EventHandler(this.dashLineMenuItem_click);
            dottedLineMenuItem.Click += new EventHandler(this.dottedLineMenuItem_click);

            //rectangle
            rectMainMenuItem = new ToolStripMenuItem("&Rectangle");
            colorRectMenuItem = new ToolStripMenuItem("&Color");
            styleRectMenuItem = new ToolStripMenuItem("&Style");
            redRectMenuItem = new ToolStripMenuItem("&Red");
            greenRectMenuItem = new ToolStripMenuItem("&Green");
            blueRectMenuItem = new ToolStripMenuItem("&Blue");
            rightRectMenuItem = new ToolStripMenuItem("&Right");
            leftRectMenuItem = new ToolStripMenuItem("&Left");
            crossRectMenuItem = new ToolStripMenuItem("&Cross");
            //assigning the functions to the menu items click
            redRectMenuItem.Click += new EventHandler(this.redRectMenuItem_click);
            greenRectMenuItem.Click += new EventHandler(this.greenRectMenuItem_click);
            blueRectMenuItem.Click += new EventHandler(this.blueRectMenuItem_click);
            rightRectMenuItem.Click += new EventHandler(this.rightRectMenuItem_click);
            leftRectMenuItem.Click += new EventHandler(this.leftRectMenuItem_click);
            crossRectMenuItem.Click += new EventHandler(this.crossRectMenuItem_click);

            //format
            formatMainMenuItem = new ToolStripMenuItem("&Format");
            coNameFormatMenuItem = new ToolStripMenuItem("&Company name");
            //assigning the functions to the menu items click
            coNameFormatMenuItem.Click += new EventHandler(this.coNameFormatMenuItem_click);


            //
            //initializing the context menu items
            //
            //line
            LineContextMenu = new ContextMenuStrip();
            colorLineContextMenuItem = new ToolStripMenuItem("&Color");
            styleLineContextMenuItem = new ToolStripMenuItem("&Style");
            redLineContextMenuItem = new ToolStripMenuItem("&Red");
            greenLineContextMenuItem = new ToolStripMenuItem("&Green");
            blueLineContextMenuItem = new ToolStripMenuItem("&Blue");
            solidLineContextMenuItem = new ToolStripMenuItem("&Solid");
            dashLineContextMenuItem = new ToolStripMenuItem("&Dash");
            dottedLineContextMenuItem = new ToolStripMenuItem("Do&tted");
            //assigning the functions to the context menu items click
            redLineContextMenuItem.Click += new EventHandler(this.redLineMenuItem_click);
            greenLineContextMenuItem.Click += new EventHandler(this.greenLineMenuItem_click);
            blueLineContextMenuItem.Click += new EventHandler(this.blueLineMenuItem_click);
            solidLineContextMenuItem.Click += new EventHandler(this.solidLineMenuItem_click);
            dashLineContextMenuItem.Click += new EventHandler(this.dashLineMenuItem_click);
            dottedLineContextMenuItem.Click += new EventHandler(this.dottedLineMenuItem_click);

            //rectangle
            rectContextMenu = new ContextMenuStrip();
            colorRectContextMenuItem = new ToolStripMenuItem("&Color");
            styleRectContextMenuItem = new ToolStripMenuItem("&Style");
            redRectContextMenuItem = new ToolStripMenuItem("&Red");
            greenRectContextMenuItem = new ToolStripMenuItem("&Green");
            blueRectContextMenuItem = new ToolStripMenuItem("&Blue");
            rightRectContextMenuItem = new ToolStripMenuItem("&Right");
            leftRectContextMenuItem = new ToolStripMenuItem("&Left");
            crossRectContextMenuItem = new ToolStripMenuItem("&Cross");
            //assigning the functions to the context menu items click
            redRectContextMenuItem.Click += new EventHandler(this.redRectMenuItem_click);
            greenRectContextMenuItem.Click += new EventHandler(this.greenRectMenuItem_click);
            blueRectContextMenuItem.Click += new EventHandler(this.blueRectMenuItem_click);
            rightRectContextMenuItem.Click += new EventHandler(this.rightRectMenuItem_click);
            leftRectContextMenuItem.Click += new EventHandler(this.leftRectMenuItem_click);
            crossRectContextMenuItem.Click += new EventHandler(this.crossRectMenuItem_click);

            //
            //checking the default choosen styles
            //in the main menu
            blueLineMenuItem.Checked = true;
            solidLineMenuItem.Checked = true;
            leftRectMenuItem.Checked = true;
            greenRectMenuItem.Checked = true;
            //in the context menu
            blueLineContextMenuItem.Checked = true;
            solidLineContextMenuItem.Checked = true;
            leftRectContextMenuItem.Checked = true;
            greenRectContextMenuItem.Checked = true;

            #endregion
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //draw the title 
            drawTitleString();
            //draw the table frame
            drawTableFrame();
            //draw the table strings
            drawTableStrings();
            //draw the chart 
            drawChartOutline();
            //draw the chart itself
            drawBarChartGraph();
            drawChartGraph();
            //draw the menu bars
            drawMainMenu();
            //assign the context menus
            assignContextMenu();
        }

        #region Main Menu Bar and context menus
        public void drawMainMenu()
        {
            //adding the menu bar to the form controls
            this.Controls.Add(mainMenuBar);

            //Adding the top level menu items to the top level menu
            mainMenuBar.Items.AddRange(new ToolStripItem[]
            {
                lineMainMenuItem, rectMainMenuItem, formatMainMenuItem
            });

            //adding the line items......
            //Adding the drop down menu items to the top level menu items
            lineMainMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                colorLineMenuItem, styleLineMenuItem
            });
            //adding the sub menu items to the drop down menu items
            colorLineMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                redLineMenuItem, greenLineMenuItem, blueLineMenuItem
            });
            styleLineMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
               solidLineMenuItem, dashLineMenuItem, dottedLineMenuItem
            });

            //adding the rectangle items......
            //Adding the drop down menu items to the top level menu items
            rectMainMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                colorRectMenuItem, styleRectMenuItem
            });
            //adding the sub menu items to the drop down menu items
            colorRectMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                redRectMenuItem, greenRectMenuItem, blueRectMenuItem
            });
            styleRectMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                rightRectMenuItem, leftRectMenuItem, crossRectMenuItem
            });

            //adding the format items......
            //Adding the drop down menu items to the top level menu items
            formatMainMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                coNameFormatMenuItem
            }); ;
        }

        public void assignContextMenu()
        {
            //
            //adding the whole document context menu
            //
            //Adding the drop down menu items to the context menu 
            LineContextMenu.Items.AddRange(new ToolStripItem[]
            {
                colorLineContextMenuItem, styleLineContextMenuItem
            });
            //adding the sub menu items to the drop down menu items
            colorLineContextMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                redLineContextMenuItem, greenLineContextMenuItem, blueLineContextMenuItem
            });
            styleLineContextMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
               solidLineContextMenuItem, dashLineContextMenuItem, dottedLineContextMenuItem
            });
            //
            //adding the chart context menu
            //
            //Adding the drop down menu items to the context menu 
            rectContextMenu.Items.AddRange(new ToolStripItem[]
            {
                colorRectContextMenuItem, styleRectContextMenuItem
            });
            //adding the sub menu items to the drop down menu items
            colorRectContextMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                redRectContextMenuItem, greenRectContextMenuItem, blueRectContextMenuItem
            });
            styleRectContextMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                rightRectContextMenuItem, leftRectContextMenuItem, crossRectContextMenuItem
            });
        }

        #region change the line shape and color
        public void redLineMenuItem_click(object sender, System.EventArgs e)
        {
            m_chartGraphColor = Color.Red;
            m_chartGraphBrush = new SolidBrush(m_chartGraphColor);
            m_chartGraphPen = new Pen(m_chartGraphBrush, 3);
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            Invalidate();
            unCheckMenuItems("lineColor");
            redLineMenuItem.Checked = true;
            redLineContextMenuItem.Checked = true;
        }
        private void blueLineMenuItem_click(object sender, EventArgs e)
        {
            m_chartGraphColor = Color.Blue;
            m_chartGraphBrush = new SolidBrush(m_chartGraphColor);
            m_chartGraphPen = new Pen(m_chartGraphBrush, 3);
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            Invalidate();
            unCheckMenuItems("lineColor");
            blueLineMenuItem.Checked = true;
            blueLineContextMenuItem.Checked = true;
        }
        private void greenLineMenuItem_click(object sender, EventArgs e)
        {
            m_chartGraphColor = Color.Green;
            m_chartGraphBrush = new SolidBrush(m_chartGraphColor);
            m_chartGraphPen = new Pen(m_chartGraphBrush, 3);
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            Invalidate();
            unCheckMenuItems("lineColor");
            greenLineMenuItem.Checked = true;
            greenLineContextMenuItem.Checked = true;
        }
        private void dottedLineMenuItem_click(object sender, EventArgs e)
        {
            m_chartGraphPenDashStyle = DashStyle.Dot;
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            Invalidate();
            unCheckMenuItems("lineStyle");
            dottedLineMenuItem.Checked = true;
            dottedLineContextMenuItem.Checked = true;
        }
        private void dashLineMenuItem_click(object sender, EventArgs e)
        {
            m_chartGraphPenDashStyle = DashStyle.Dash;
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            Invalidate();
            unCheckMenuItems("lineStyle");
            dashLineMenuItem.Checked = true;
            dashLineContextMenuItem.Checked = true;
        }
        private void solidLineMenuItem_click(object sender, EventArgs e)
        {
            m_chartGraphPenDashStyle = DashStyle.Solid;
            m_chartGraphPen.DashStyle = m_chartGraphPenDashStyle;
            Invalidate();
            unCheckMenuItems("lineStyle");
            solidLineMenuItem.Checked = true;
            solidLineContextMenuItem.Checked = true;
        }
        #endregion
       
        #region change the bars shape and color
        private void redRectMenuItem_click(object sender, EventArgs e)
        {
            m_BarChartColor = Color.Red;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            Invalidate();
            unCheckMenuItems("barColor");
            redRectMenuItem.Checked = true;
            redRectContextMenuItem.Checked = true;
        }
        private void greenRectMenuItem_click(object sender, EventArgs e)
        {
            m_BarChartColor = Color.DarkSeaGreen;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            Invalidate();
            unCheckMenuItems("barColor");
            greenRectMenuItem.Checked = true;
            greenRectContextMenuItem.Checked = true;
        }
        private void blueRectMenuItem_click(object sender, EventArgs e)
        {
            m_BarChartColor = Color.Blue;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            Invalidate();
            unCheckMenuItems("barColor");
            blueRectMenuItem.Checked = true;
            blueRectContextMenuItem.Checked = true;
        }
        private void rightRectMenuItem_click(object sender, EventArgs e)
        {
            m_BarChartHatch = HatchStyle.BackwardDiagonal;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            Invalidate();
            unCheckMenuItems("barHatch");
            rightRectMenuItem.Checked = true;
            rightRectContextMenuItem.Checked = true;
        }
        private void leftRectMenuItem_click(object sender, EventArgs e)
        {
            m_BarChartHatch = HatchStyle.ForwardDiagonal;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            Invalidate();
            unCheckMenuItems("barHatch");
            leftRectMenuItem.Checked = true;
            leftRectContextMenuItem.Checked = true;
        }
        private void crossRectMenuItem_click(object sender, EventArgs e)
        {
            m_BarChartHatch = HatchStyle.Cross;
            m_BarChartBrush = new HatchBrush(m_BarChartHatch, Color.Beige, m_BarChartColor);
            Invalidate();
            unCheckMenuItems("barHatch");
            crossRectMenuItem.Checked = true;
            crossRectContextMenuItem.Checked = true;
        }
        #endregion

        #region change the company name format
        private void coNameFormatMenuItem_click(object sender, EventArgs e)
        {
            coNameDialog coNameDialog = new coNameDialog(this);
            coNameDialog.TitleText = m_titleStr1;
            coNameDialog.TitleSize = m_titleStrSize;
            coNameDialog.TitleFont = m_titlefontName;
            coNameDialog.TitleColor = m_titleColor;
            DialogResult coNameDlgResult;
            coNameDlgResult = coNameDialog.ShowDialog();
            if(coNameDlgResult == DialogResult.OK)
            {
                m_titleStr1 = coNameDialog.TitleText;
                m_titleStrSize = coNameDialog.TitleSize;

                m_titlefontName = coNameDialog.TitleFont;
                m_titleColor = coNameDialog.TitleColor;
            }
            m_titlefont = new Font(m_titlefontName, m_titleStrSize, FontStyle.Underline);
            m_titleBrush = new SolidBrush(m_titleColor);
            m_titleStr1_size = g.MeasureString(m_titleStr1, m_titlefont);
            m_titleStr2_size = g.MeasureString(m_titleStr2, m_titlefont);

            Invalidate();
        }
        #endregion



        //unchecking the main menu bar and context menu
        public void unCheckMenuItems(string menuType)
        {
            switch (menuType)
            {
                case "lineColor":
                    ToolStripMenuItem tempMainMenuItem;
                    ToolStripMenuItem tempContextMenuItem;
                    for (var i = 0; i < colorLineMenuItem.DropDownItems.Count; i++)
                    {
                        tempMainMenuItem = (ToolStripMenuItem)colorLineMenuItem.DropDownItems[i];
                        tempContextMenuItem = (ToolStripMenuItem)colorLineContextMenuItem.DropDownItems[i];
                        tempMainMenuItem.Checked = false;
                        tempContextMenuItem.Checked = false;
                    }
                    break;
                case "lineStyle":
                    for (var i = 0; i < styleLineMenuItem.DropDownItems.Count; i++)
                    {
                        tempMainMenuItem = (ToolStripMenuItem)styleLineMenuItem.DropDownItems[i];
                        tempContextMenuItem = (ToolStripMenuItem)styleLineContextMenuItem.DropDownItems[i];
                        tempMainMenuItem.Checked = false;
                        tempContextMenuItem.Checked = false;
                    }
                    break;
                case "barColor":
                    for (var i = 0; i < colorRectMenuItem.DropDownItems.Count; i++)
                    {
                        tempMainMenuItem = (ToolStripMenuItem)colorRectMenuItem.DropDownItems[i];
                        tempContextMenuItem = (ToolStripMenuItem)colorRectContextMenuItem.DropDownItems[i];
                        tempMainMenuItem.Checked = false;
                        tempContextMenuItem.Checked = false;
                    }
                    break;
                case "barHatch":
                    for (var i = 0; i < styleRectMenuItem.DropDownItems.Count; i++)
                    {
                        tempMainMenuItem = (ToolStripMenuItem)styleRectMenuItem.DropDownItems[i];
                        tempContextMenuItem = (ToolStripMenuItem)styleRectContextMenuItem.DropDownItems[i];
                        tempMainMenuItem.Checked = false;
                        tempContextMenuItem.Checked = false;
                    }
                    break;
            }
        }
        #endregion

        #region drawing the title string
        public void drawTitleString()
        {
            //initializing the location of the title in the method to be dynamic
            m_titleLoc1 = new PointF((this.Width - m_titleStr1_size.Width) / 2, 50);
            m_titleLoc2 = new PointF((this.Width - m_titleStr2_size.Width) / 2, m_titleStr1_size.Height + 50);
            g.DrawString(m_titleStr1, m_titlefont, m_titleBrush, m_titleLoc1);
            g.DrawString(m_titleStr2, m_titlefont, m_titleBrush, m_titleLoc2);
        }
        #endregion

        #region drawing the table frame
        public void drawTableFrame()
        {
            //initializing the increments according to the width and height size
            yTableIncrement = this.Height / 16;
            //initializing the location of the table in the method to be dynamic
            m_tableFrameSize = new Size(annualRevenue.GetLength(1) * 100, annualRevenue.GetLength(0) * yTableIncrement + yTableIncrement);
            m_tableFrameLoc = new Point(this.Width - m_tableFrameSize.Width - 50, 100);
            m_tableFrame = new Rectangle(m_tableFrameLoc, m_tableFrameSize);
            g.DrawRectangle(m_tableFramePen, m_tableFrame);
            drawColumnSeparator();
            drawRowSeparator();
        }
        public void drawColumnSeparator()
        {
            //initializing the location of the table separator in the method to be dynamic
            m_tableSepLoc1 = new Point(m_tableFrameLoc.X + m_tableFrameSize.Width / 2, m_tableFrameLoc.Y);
            m_tableSepLoc2 = new Point(m_tableFrameLoc.X + m_tableFrameSize.Width / 2, m_tableFrameLoc.Y + m_tableFrameSize.Height);
            g.DrawLine(m_tableFramePen, m_tableSepLoc1, m_tableSepLoc2);
        }
        public void drawRowSeparator()
        {
            int y = yTableIncrement;
            for (var i = 0; i < annualRevenue.GetLength(0); i++, y += yTableIncrement)
            {
                m_tableRowLoc1 = new Point(m_tableFrameLoc.X, m_tableFrameLoc.Y + y);
                m_tableRowLoc2 = new Point(m_tableFrameLoc.X + m_tableFrameSize.Width, m_tableFrameLoc.Y + y);
                g.DrawLine(m_tableFramePen, m_tableRowLoc1, m_tableRowLoc2);
            }
        }
        #endregion

        #region strings in the table
        public void drawTableStrings()
        {
            int y = yTableIncrement;
            //table titles
            m_tableStr = "Year";
            m_tableStrLoc = new Point(m_tableFrameLoc.X, m_tableFrameLoc.Y);
            g.DrawString(m_tableStr, m_tablefont, m_tableBrush, m_tableStrLoc);

            m_tableStr = "Revenue";
            m_tableStrLoc = new Point(m_tableFrameLoc.X + 100, m_tableFrameLoc.Y);
            g.DrawString(m_tableStr, m_tablefont, m_tableBrush, m_tableStrLoc);
            for (var i = 0; i < annualRevenue.GetLength(0); i++, y += yTableIncrement)
            {
                // table base point: m_tableFrameLoc;
                m_tableStr = annualRevenue[i, 0].ToString();
                m_tableStrLoc = new Point(m_tableFrameLoc.X, m_tableFrameLoc.Y + y);
                g.DrawString(m_tableStr, m_tablefont, m_tableBrush, m_tableStrLoc);

                m_tableStr = annualRevenue[i, 1].ToString();
                m_tableStrLoc = new Point(m_tableFrameLoc.X + 100, m_tableFrameLoc.Y + y);
                g.DrawString(m_tableStr, m_tablefont, m_tableBrush, m_tableStrLoc);
            }
        }

        #endregion

        #region drawing the chart
        public void drawChartOutline()
        {
            //initializing the chart increments according to the width and height size
            xChartIncrement = this.Width / 18;
            yChartIncrement = this.Height / 18;
            //initializing the location of the table in the method to be dynamic
            m_chartBaseP = new Point(50, this.Height - 100);
            m_chartP1 = new Point((int)((annualRevenue.GetLength(0) + 1) * xChartIncrement + 50), this.Height - 100);
            m_chartP2 = new Point(50, (int)(this.Height - yChartIncrement * 11 - 100));
            g.DrawLine(m_chartPen, m_chartBaseP, m_chartP1);
            g.DrawLine(m_chartPen, m_chartBaseP, m_chartP2);
            drawChartxChartIncrements();
            drawChartyChartIncrements();
        }
        public void drawChartxChartIncrements()
        {
            int x = (int)xChartIncrement;
            for (var i = 0; i < annualRevenue.GetLength(0); i++, x += (int)xChartIncrement)
            {
                //draw the line increment
                m_chartP1 = new Point(m_chartBaseP.X + x, m_chartBaseP.Y + 10);
                m_chartP2 = new Point(m_chartBaseP.X + x, m_chartBaseP.Y - 10);
                g.DrawLine(m_incrementPen, m_chartP1, m_chartP2);
                //draw the label
                m_chartStr = annualRevenue[i, 0].ToString();
                m_chartStr_size = g.MeasureString(m_chartStr, m_chartfont);
                m_chartStrLoc = new Point((m_chartBaseP.X + x) - ((int)(m_chartStr_size.Width) / 2), m_chartBaseP.Y + 15);
                g.DrawString(m_chartStr, m_chartfont, m_chartstrBrush, m_chartStrLoc);
            }
            g.DrawString("Year", m_chartfont, m_chartstrBrush, new Point((int)m_chartStrLoc.X + (int)xChartIncrement, m_chartBaseP.Y + 15));
        }
        public void drawChartyChartIncrements()
        {
            int y = (int)yChartIncrement;
            for (var i = 0; i < 10; i++, y += (int)yChartIncrement)
            {
                //draw the line increment
                m_chartP1 = new Point(m_chartBaseP.X + 10, m_chartBaseP.Y - y);
                m_chartP2 = new Point(m_chartBaseP.X - 10, m_chartBaseP.Y - y);
                g.DrawLine(m_incrementPen, m_chartP1, m_chartP2);
                //draw the label
                m_chartStr = ((i + 1) * revenueIncrement).ToString();
                m_chartStr_size = g.MeasureString(m_chartStr, m_chartfont);
                m_chartStrLoc = new Point(m_chartBaseP.X - 15 - (int)(m_chartStr_size.Width), (m_chartBaseP.Y - y) - ((int)(m_chartStr_size.Height) / 2));
                g.DrawString(m_chartStr, m_chartfont, m_chartstrBrush, m_chartStrLoc);
            }
            m_chartStr_size = g.MeasureString("Revenue", m_chartfont);
            g.DrawString("Revenue", m_chartfont, m_chartstrBrush, new Point(m_chartBaseP.X - (int)(m_chartStr_size.Width/2), (int)m_chartStrLoc.Y - (int)(1.2*yChartIncrement)));
        }
        public void drawChartGraph()
        {
            m_chartPointsList = new List<Point>();
            Point tempPoint;
            float x;
            float y;
            for (var i = 0; i < annualRevenue.GetLength(0); i++)
            {
                //assuming the increment on the graph is 30 in revnue units
                x = m_chartBaseP.X + (xChartIncrement * (i + 1));
                y = m_chartBaseP.Y - (yChartIncrement * (annualRevenue[i, 1] /(float) revenueIncrement));
                tempPoint = new Point((int)x, (int)y);
                m_chartPointsList.Add(tempPoint);
            }
            m_chartPoints = m_chartPointsList.ToArray();
            g.DrawLines(m_chartGraphPen, m_chartPoints);
        }
        public void drawBarChartGraph()
        {
            float x;
            float y;
            float barlength;
            int barWidth = this.Width / 30;
            for (var i = 0; i < annualRevenue.GetLength(0); i++)
            {
                //assuming the increment on the graph is 30 in revnue units
                x = m_chartBaseP.X + (xChartIncrement * (i + 1)) - barWidth / 2;
                y = m_chartBaseP.Y - (yChartIncrement * (annualRevenue[i, 1] / (float)revenueIncrement));
                barlength = yChartIncrement * (annualRevenue[i, 1] / (float)revenueIncrement);
                m_BarChartSize = new Size(barWidth, (int)barlength);
                m_BarChartLoc = new Point((int)x, (int)y);
                m_BarChartRect = new Rectangle(m_BarChartLoc, m_BarChartSize);
                g.FillRectangle(m_BarChartBrush, m_BarChartRect);
            }
        }
        #endregion
        
        #region Form events
        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyPressed = e.KeyChar;
            switch (keyPressed)
            {
                case 2:
                    m_chartGraphColor = Color.Blue;
                    break;
                case 7:
                    m_chartGraphColor = Color.Green;
                    break;
                case 18:
                    m_chartGraphColor = Color.Red;
                    break;
            }
            m_chartGraphBrush = new SolidBrush(m_chartGraphColor);
            m_chartGraphPen = new Pen(m_chartGraphBrush, 3);
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            //if right click display context menu accordingly
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //m_chartp1.X isn't working don't know why!!!!!!
                bool xCondition = (e.X > m_chartBaseP.X) && (e.X < ((annualRevenue.GetLength(0) + 1) * xChartIncrement + 50));
                bool yCondition = (e.Y < m_chartBaseP.Y) && (e.Y > m_chartP2.Y);

                //if x is in the chart area
                if (xCondition && yCondition)
                {
                    //MessageBox.Show("yes inside chart x:" + e.X + " y: " + e.Y);

                    //adding the line context menu bar to the form controls
                    rectContextMenu.Show(this, new Point(e.X, e.Y));    //assign the point to show relative to the control which is (this) the whole form

                    //
                    //rectContextMenu.Show(new Point(e.X, e.Y)); //this overload show it relative to the whole screen
                    //this.ContextMenuStrip = rectContextMenu;   //this assign it to the document only once idk why
                }
                else
                {
                    //adding the line context menu bar to the form controls
                    LineContextMenu.Show(this, new Point(e.X, e.Y));
                }
            }
            //if left click display the revnue, year
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //m_chartp1.X isn't working don't know why!!!!!!
                bool xCondition = (e.X > m_chartBaseP.X) && (e.X < ((annualRevenue.GetLength(0) + 1) * xChartIncrement + 50));
                bool yCondition = (e.Y < m_chartBaseP.Y) && (e.Y > m_chartP2.Y);

                //if x is in the chart area
                if (xCondition && yCondition)
                {
                    int xChartCoor = e.X - m_chartBaseP.X;
                    int yChartCoor = m_chartBaseP.Y - e.Y;

                    float yearIncrements = (float)xChartCoor / xChartIncrement;
                    float revenueIncrements = (float)yChartCoor / yChartIncrement;

                    int year = (int)Math.Round(yearIncrements) - 1;
                    float revenue = revenueIncrements * revenueIncrement;

                    //to handle the external borders to avoid out of array error
                    year = (year < 0) ?  0 :  year;
                    year = (year > annualRevenue.GetLength(0) - 1) ? annualRevenue.GetLength(0) - 1 :  year;

                    MessageBox.Show("Year: " + annualRevenue[year,0] + ", Revenue: " + revenue);
                }
            }
        }

        
        #endregion
    }
}