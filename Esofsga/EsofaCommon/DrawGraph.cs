#region PROGRAM HEADER
/*
*********************************************************************************************
* FILE NAME      : DrawGraph.cs                                                             *
* DESCRIPTION    : Generates Bar, Line & Pie graph for a set of values [maximum limit= 10]  *
* AUTHOR         : Anoop Unnikrishnan   (AUK)                                               *
* Licence        : CPOL                                                                     *
* CONTACT        : anoopukrish@gmail.com                                                    *
* NOTE           : Permission given to use and modify this script in ANY kind of            *
*                  applications if header lines are left unchanged.                         *
*********************************************************************************************
* DATE       WHO    VERSION                                                                 *
*-------------------------------------------------------------------------------------------*
* 01/02/2008 AUK    1.0                                                                     *
*********************************************************************************************
 */
#endregion
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;


namespace EsofaCommon
{
    public partial class DrawGraph
    {
        #region Global Variables

        string[] valueLabels;
        double [] values;
        string xLabel;     // Label displayed on x axis
        string yLabel;     // Label displayed on y axis
        string fontFormat; // format for labels
        int alpha;      // alpha for graph
        List<Color> colorList;  // Dark colors only

        #endregion

        #region Constructor

        // Constructor used for bar graph
        public DrawGraph(string[] valueLabels, double[] values, string xLabel, string yLabel, string fontFormat, int alpha)
        {
            this.valueLabels = valueLabels;
            this.values = values;
            this.xLabel = xLabel;
            this.yLabel = yLabel;
            this.alpha = alpha;
            this.fontFormat = fontFormat;

            InitColorList();
        }

        #endregion

        #region Private Functions

        // Initiatialize color list with dark color's
        private void InitColorList()
        {
            colorList = new List<Color>();

            foreach (string colorName in Enum.GetNames(typeof(System.Drawing.KnownColor)))
            {
                //Check if color is dark
                if (colorName.StartsWith("D") == true)
                {
                    colorList.Add(System.Drawing.Color.FromName(colorName));
                }
            }
        }

        //Embed axis for bar graphs
        Bitmap EmbedAxis(Bitmap graph, bool showAxis)
        {
            //定义背景画布的尺寸大小：490宽 X 280高
            Bitmap backgroundCanvas = new Bitmap(490, 280);
           
            // 定义Y轴标签图片的尺寸大小：15宽 X 270高
             Bitmap yLabelImage = new Bitmap(15, 270);

            Graphics graphicsBackImage = Graphics.FromImage(backgroundCanvas);
            Graphics objGraphic2 = Graphics.FromImage(graph);
            Graphics objGraphicY = Graphics.FromImage(yLabelImage);
            //定义画笔，颜色为黑色，线条粗细为1.5
            Pen blackPen = new Pen(Color.Black, 1.5f);
            //画笔画线时起点为圆点
            blackPen.StartCap = LineCap.Round;
            //画笔画线时终点为箭头锚点
            blackPen.EndCap = LineCap.ArrowAnchor;
            //Paint the graph canvas white
            //用于画画的画刷的颜色
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            //整个画布背景涂为白色,画布左上为(0,0)，右下为(450,300)
            graphicsBackImage.FillRectangle(whiteBrush, 0, 0, 490, 280); 

            if (showAxis == true)
            {
                //draw lable for y axis

                StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical);
                Font f = new Font(fontFormat, 10);
                SizeF sizef = objGraphicY.MeasureString(yLabel, f, Int32.MaxValue, sf); //("<- " + yLabel, f, Int32.MaxValue, sf);

                RectangleF rf = new RectangleF(0, 0, sizef.Width, sizef.Height);
                //绘制Y轴文字，文字外边框为透明
                objGraphicY.DrawRectangle(Pens.Transparent, rf.Left, rf.Top, rf.Width, rf.Height);
                objGraphicY.DrawString(yLabel, f, Brushes.Black, rf, sf); //((yLabel.Length > 0 ? "<- " : "") + yLabel, f, Brushes.Black, rf, sf);
                graphicsBackImage.DrawString(xLabel, f, Brushes.Black, 230, 255); //(xLabel + (xLabel.Length > 0 ? " ->" : ""), f, Brushes.Black, 230, 260);//绘制x轴文字
                //用黑色笔对画布画x轴
                graphicsBackImage.DrawLine(blackPen, new Point(0, 250), new Point(280, 250));
                //用黑色笔对画布画y轴
                graphicsBackImage.DrawLine(blackPen, new Point(16, 270), new Point(16, 15));
            }
            graphicsBackImage.DrawImage(graph, 20, 20);
            if (showAxis == true)
            {
                graphicsBackImage.DrawImage(yLabelImage, 0, 20);
            }

            return (backgroundCanvas);
        }

        //Embed x Panel
        Bitmap EmbedXPanel(Bitmap graph)
        {

            Bitmap xPanel = new Bitmap(200, 200);
            Graphics objGraphicPanel = Graphics.FromImage(xPanel);
            Graphics graphicGraph = Graphics.FromImage(graph);

            for (int i = values.Length -1,x=10; i>=0;i--)//(int i = 0, x = 10; i < values.Length; i++)
            {

                //Draw the bar
                SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, colorList[i]));
                objGraphicPanel.FillRectangle(brush, 10, 190 - x, 10, 10);
                //对图例上的权重数值进行格式化，小数点后保留3位小数值
                //string drawString = valueLabels[i] + " = " + string.Format("#.###",values[i].ToString());
                string drawString = valueLabels[i] + " = " + values[i].ToString("0.###");
                Font drawFont = new Font(fontFormat, 10);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                objGraphicPanel.DrawString(drawString, drawFont, drawBrush, 20, 190 - x);

                //x axis spacing by 20
                x += 20;
            }
            //绘制右侧的图例项，起画点的坐标是：x=300, y = 25;由左上到右下进行画图xPanel
            graphicGraph.DrawImage(xPanel, 300, 25);
            return (graph);

        }

        //Embed x Panel [Line graph style]
        Bitmap EmbedXLinePanel(Bitmap graph)
        {

            Bitmap xPanel = new Bitmap(100, 200);
            Graphics objGraphicPanel = Graphics.FromImage(xPanel);
            Graphics graphicGraph = Graphics.FromImage(graph);

            for (int i = 1, x = 10; i < values.Length; i++)
            {

                //Draw the bar
                SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, colorList[i]));
                Pen colorPen = new Pen(brush, 2);
                objGraphicPanel.DrawLine(colorPen, 10, 190 - x, 20, 190 - x);

                string drawString = valueLabels[i - 1].ToString() + " - " + valueLabels[i].ToString();
                Font drawFont = new Font(fontFormat, 9);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                objGraphicPanel.DrawString(drawString, drawFont, drawBrush, 20, 190 - x);

                //x axis spacing by 20
                x += 20;
            }

            graphicGraph.DrawImage(xPanel, 300, 25);
            return (graph);

        }

        #endregion

        #region Public Functions

        //Generate Bar graph
        public Bitmap DrawBarGraph()
        {

            Bitmap objgraph = new Bitmap(250, 230);             // Canvas for graph

            Graphics graphicGraph = Graphics.FromImage(objgraph);

            //Paint the graph canvas white
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            graphicGraph.FillRectangle(whiteBrush, 0, 0, 250, 230);


            double highestValue; //Highest value in the values array

            //Get the highest value 
            double[] tempValue = new double[values.Length];
            for (int j = 0; j < values.Length; j++)
            {
                tempValue[j] = values[j];
            }
            Array.Sort<double>(tempValue);
            highestValue = tempValue[values.Length - 1];

            //Generate bar for each value
            for (int i = 0, x = 10; i < values.Length; i++)
            {
                double barHeight;    //hight of the bar
                barHeight = (values[i] / highestValue) * 200;

                //Draw the bar
                SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, colorList[i]));
                graphicGraph.FillRectangle(brush, x, (int)(230-barHeight), 10, (int)barHeight);

                //x axis spacing by 20
                x += 25;
            }

            //Increase the size of the canvas and draw axis
            objgraph = EmbedAxis(objgraph, true);

            //Draw the key-value pair with repective color code
            objgraph = EmbedXPanel(objgraph);

            return (objgraph);
        }

        //Generate 3D Bar graph
        public Bitmap Draw3dBarGraph()
        {

            Bitmap objgraph = new Bitmap(200, 200);             // Canvas for graph
            Bitmap objXValuePanel = new Bitmap(100, 200);       // Canvas to display x-axis values

            Graphics graphicGraph = Graphics.FromImage(objgraph);
            Graphics graphicXValuePanel = Graphics.FromImage(objXValuePanel);

            //Paint the graph canvas white
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            graphicGraph.FillRectangle(whiteBrush, 0, 0, 200, 200);


            double highestValue; //Highest value in the values array

            //Get the highest value 
            double[] tempValue = new double[values.Length];
            for (int j = 0; j < values.Length; j++)
            {
                tempValue[j] = values[j];
            }
            Array.Sort<double>(tempValue);
            highestValue = tempValue[values.Length - 1];

            //Generate bar for each value
            for (int i = 0, x = 10; i < values.Length; i++)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(alpha, colorList[i]));

                double barHeight;    //hight of the bar
                barHeight = (values[i] / highestValue) * 190;

                //Draw continuous shade for 3D effect
                double shadex = x + 10;
                double shadey = 194 - ((int)barHeight) + 10;
                for (int iLoop2 = 0; iLoop2 < 10; iLoop2++)
                {
                    graphicGraph.FillRectangle(brush, (int)(shadex - iLoop2), (int)(shadey - iLoop2), 10, (int)barHeight);
                }


                //Draw bar
                graphicGraph.FillRectangle(new HatchBrush(HatchStyle.Percent50, brush.Color), x, (int)(194 - barHeight), 10, (int)barHeight);

                //Increment the x position            
                x += 20;

            }

            //Mask bottom with a white line
            Pen whitePen = new Pen(Color.White, 10);
            graphicGraph.DrawLine(whitePen, new Point(10, 200), new Point(230, 200));

            //Increase the size of the canvas and draw axis
            objgraph = EmbedAxis(objgraph, true);

            //Draw the key-value pair with repective color code
            objgraph = EmbedXPanel(objgraph);

            return (objgraph);


        }

        //Generate Pie graph
        public Bitmap DrawPieGraph()
        {
            Bitmap objgraph = new Bitmap(200, 200);

            Graphics graphicGraph = Graphics.FromImage(objgraph);

            // Create location and size of ellipse.
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 100;

            // Create start and sweep angles.
            double sweepAngle = 0;
            double startAngle = 0;
            Random rand = new Random();

            double total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            for (int i = 0; i < values.Length; i++)
            {
                SolidBrush objBrush = new SolidBrush(colorList[i]);
                sweepAngle = (values[i] * 360) / total;
                graphicGraph.SmoothingMode = SmoothingMode.AntiAlias;
                graphicGraph.FillPie(objBrush, x, y, width, height, (float)startAngle, (float)sweepAngle);
                startAngle += sweepAngle;
            }

            //Increase the size of the canvas in which the graph resides
            objgraph = EmbedAxis(objgraph, false);

            //Draw the key-value pair with repective color code
            objgraph = EmbedXPanel(objgraph);

            return (objgraph);

        }

        //Generate Pie graph
        public Bitmap Draw3DPieGraph()
        {
            Bitmap objgraph = new Bitmap(200, 200);
            Graphics graphicGraph = Graphics.FromImage(objgraph);

            // Create location and size of ellipse.
            int x = 0;
            int y = 0;
            int width = 200;
            int height = 100;

            //Find the sum of all values
            double total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }

            //When loop=0 :Draw shadow
            //     loop=1 :Draw graph
            for (int loop = 0; loop < 2; loop++)
            {
                // Create start and sweep angles.
                double sweepAngle = 0;
                double startAngle = 0;

                //Draw pie for each value
                for (int i = 0; i < values.Length; i++)
                {
                    SolidBrush objBrush = new SolidBrush(colorList[i]);
                    sweepAngle = (values[i] * 360) / total;

                    graphicGraph.SmoothingMode = SmoothingMode.AntiAlias;
                    if (loop == 0)
                    {
                        for (int iLoop2 = 0; iLoop2 < 10; iLoop2++)
                            graphicGraph.FillPie(new HatchBrush(HatchStyle.Percent50, objBrush.Color),
                                                x, y + iLoop2, width, height, (float)startAngle, (float)sweepAngle);
                    }
                    else
                    {
                        graphicGraph.FillPie(objBrush, x, y, width, height, (float)startAngle, (float)sweepAngle);
                    }

                    startAngle += sweepAngle;
                }

            }

            //Increase the size of the canvas in which the graph resides
            objgraph = EmbedAxis(objgraph, false);

            //Draw the key-value pair with repective color code
            objgraph = EmbedXPanel(objgraph);

            return (objgraph);

        }

        //Generate Line graph
        public Bitmap DrawLineGraph()
        {
            Bitmap objgraph = new Bitmap(200, 200);             // Canvas for graph

            Graphics graphicGraph = Graphics.FromImage(objgraph);

            //Paint the graph canvas white
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            graphicGraph.FillRectangle(whiteBrush, 0, 0, 200, 200);

            int highestValue; //Highest value in the values array

            //Get the highest value 
            int[] tempValue = new int[values.Length];
            for (int j = 0; j < values.Length; j++)
            {
                tempValue[j] = (int)values[j];
            }
            Array.Sort<int>(tempValue);
            highestValue = tempValue[values.Length - 1];
            int[,] points = new int[values.Length, 2];

            //Generate bar for each value
            for (int i = 0, x = 10; i < values.Length; i++)
            {

                decimal barHeight;    //hight of the bar
                barHeight = (decimal)(values[i] / highestValue * 190);

                points[i, 0] = x;
                barHeight = 194 - barHeight;
                points[i, 1] = (int)Decimal.Round(barHeight, 0);

                Font f = new Font(fontFormat, 8);
                graphicGraph.FillEllipse(Brushes.Black, points[i, 0] - 2, points[i, 1] - 2, 5, 5);
                graphicGraph.DrawString(values[i].ToString(), f, Brushes.Black, new Point(points[i, 0] - 14, points[i, 1] - 5));
                x += 20;
            }

            Random rand = new Random();
            for (int i = 1; i < values.Length; i++)
            {
                Point startPoint = new Point(points[i - 1, 0], points[i - 1, 1]);
                Point endPoint = new Point(points[i, 0], points[i, 1]);
                SolidBrush brush = new SolidBrush(colorList[i]);
                Pen colorPen = new Pen(brush, 2);

                graphicGraph.DrawLine(colorPen, startPoint, endPoint);
            }

            objgraph = EmbedAxis(objgraph, true);
            objgraph = EmbedXLinePanel(objgraph);
            return (objgraph);

        }
        #endregion
    }
}
