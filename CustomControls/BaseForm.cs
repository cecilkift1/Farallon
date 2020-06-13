using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Farallon.Constants;
using Farallon.Properties;

namespace Farallon.CustomControls
{
    public partial class BaseForm : Form
    {
        private Portfolio _portfolio;
        public BaseForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected void LoadPortfolio(CustomListView listView)
        {
            if (_portfolio == null)
            {
                _portfolio = new Portfolio();
                var path = Path.GetDirectoryName(Application.ExecutablePath) ?? string.Empty;
                _portfolio.Initialize(Path.Combine(path, @"TradesSampleData\Portfolio.xml"), listView);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           
            PaintLogo(e.Graphics);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            PaintHeader(e.Graphics);
        }

        private void PaintHeader(Graphics graphics)
        {
            using var pen = new Pen(Color.DarkGray);
            graphics.DrawLine(pen, ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Right, ClientRectangle.Top);
            graphics.DrawLine(pen, ClientRectangle.Left, ClientRectangle.Top + DrawingConstants.MainFormHeaderHeight, ClientRectangle.Right, ClientRectangle.Top + DrawingConstants.MainFormHeaderHeight);
        }

        private void PaintLogo(Graphics graphics)
        { 
            try
            {
                var logo = (Image)Resources.ResourceManager.GetObject("farallon_logo");

                if (logo != null)
                {
                    var sourceRect = new Rectangle(0, 0, logo.Width, logo.Height);
                    var destinationHeight = DrawingConstants.MainFormHeaderHeight - DrawingConstants.MainFormHeaderMargins.Top - DrawingConstants.MainFormHeaderMargins.Bottom;
                    var destinationWidth = destinationHeight * logo.Width / logo.Height;
                    var destinationStartPoint = new Point(ClientRectangle.Left + DrawingConstants.MainFormHeaderMargins.Left, ClientRectangle.Top + DrawingConstants.MainFormHeaderMargins.Top);
                    using var brush = new SolidBrush(Color.White);
                    graphics.FillRectangle(brush, new Rectangle(destinationStartPoint.X, destinationStartPoint.Y, destinationWidth, DrawingConstants.MainFormHeaderHeight - DrawingConstants.MainFormHeaderMargins.Bottom));
                    graphics.DrawImage(logo, new Rectangle(destinationStartPoint.X, destinationStartPoint.Y, destinationWidth, destinationHeight), sourceRect, GraphicsUnit.Pixel);
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load the Logo from the ResourceManager, Error: {e.Message}");
            }
        }
    }
}
