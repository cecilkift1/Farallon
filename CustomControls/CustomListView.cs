using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Farallon.CustomControls
{
    public partial class CustomListView : ListView
    {
        private bool _resizing;
        public CustomListView()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.EnableNotifyMessage, true);

            BorderStyle = BorderStyle.None;
            GridLines = false;
            OwnerDraw = true;
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
        }
        public new void EndUpdate()
        {
            base.EndUpdate();
            ApplyLayout();
        }

        public override Color ForeColor
        {
            get => Color.RoyalBlue;
            set { }
        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            // Fill the background
            e.Graphics.FillRectangle(Brushes.Gainsboro, e.Bounds);
            // Draw a top line
            using var pen = new Pen(Color.RoyalBlue, 3);
            e.Graphics.DrawLine(pen, e.Bounds.Left, e.Bounds.Top, e.Bounds.Right, e.Bounds.Top);
            // Draw a bottom line
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            // Draw the text
            using var stringFormat = StringFormat(e.Header.TextAlign);
            using var headerFont = new Font(Font.Name, Font.Size, FontStyle.Bold);
            var textBounds = e.Bounds;
            textBounds.Inflate(e.ColumnIndex == 0 ? 0 : -5, 0);
            e.Graphics.DrawString(e.Header.Text, headerFont, new SolidBrush(ForeColor), textBounds, stringFormat);
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            PaintItemBackground(e.State, e.Graphics, e.Bounds);

            using var stringFormat = StringFormat(HorizontalAlignment.Left);
            using var textBrush = new SolidBrush(ForeColor);
            e.Graphics.DrawString(e.Item.Text, Font, textBrush, e.Bounds, stringFormat);
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            using var stringFormat = StringFormat(e.Header.TextAlign);
            e.Graphics.DrawString(e.SubItem.Text, Font, Brushes.Black, e.Bounds, stringFormat);

            // Draw a bottom line
            e.Graphics.DrawLine(Pens.LightGray, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
        }

        private void PaintItemBackground(ListViewItemStates states, Graphics graphics, Rectangle bounds)
        {
            var backgroundBrush = Brushes.Gainsboro;
            if (states == ListViewItemStates.Selected ||
                states == ListViewItemStates.Focused ||
                states == ListViewItemStates.Hot)
            {
                backgroundBrush = Brushes.White;
            }

            graphics.FillRectangle(backgroundBrush, bounds);
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            if (!_resizing)
            {
                _resizing = true;

                ApplyLayout();
            }

            _resizing = false;
        }

        private void ApplyLayout()
        {
            var columnWidth = ClientRectangle.Width / Columns.Count;

            foreach (ColumnHeader column in Columns)
            {
                column.Width = columnWidth;
            }
        }
        private static StringFormat StringFormat(HorizontalAlignment alignment)
        {
            var stringFormat = new StringFormat
            {
                LineAlignment = StringAlignment.Center
            };

            stringFormat.Alignment = alignment switch
            {
                HorizontalAlignment.Left => StringAlignment.Near,
                HorizontalAlignment.Right => StringAlignment.Far,
                HorizontalAlignment.Center => StringAlignment.Center,
                _ => stringFormat.Alignment
            };

            return stringFormat;
        }
    }
}
