using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Farallon.Enums;
using Farallon.Interfaces;

namespace Farallon.CustomControls
{
    public partial class CustomListView : ListView
    {
        private bool _resizing;
        private IPortfolio _portfolio;

        public CustomListView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.EnableNotifyMessage, true);

            BorderStyle = BorderStyle.None;
            GridLines = false;
            OwnerDraw = true;
        }

        public PortfolioViewType PortfolioViewType { get; set; } = PortfolioViewType.Trades;

        public IPortfolio Portfolio
        {
            get => _portfolio;
            set
            {
                _portfolio = value;

                Bind();
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

        private void Bind()
        {
            try
            {
                BeginUpdate();
                Clear();
                CreateColumns();
                CreateRows();
            }
            finally
            {
                EndUpdate();
            }
        }

        private void CreateColumns()
        {
            var columns = Portfolio?.Columns(PortfolioViewType) ?? new List<IColumn>();

            foreach (var columnHeader in columns.Select(column => new ColumnHeader
            {
                Text = column.Text,
                TextAlign = column.TextAlign
            }))
            {
                Columns.Add(columnHeader);
            }
        }

        private void CreateRows()
        {
            var rows = Portfolio?.Rows(PortfolioViewType) ?? new List<IRow>();

            foreach (var row in rows)
            {
                ListViewItem listViewItem = null;
                foreach (var rowValue in row.Values)
                {
                    if (listViewItem == null)
                    {
                        listViewItem = new ListViewItem
                        {
                            Text = rowValue
                        };

                        Items.Add(listViewItem);
                    }
                    else
                    {
                        listViewItem.SubItems.Add(rowValue);
                    }
                }
            }
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

        private void ApplyLayout()
        {
            var columnWidth = ClientRectangle.Width / Math.Max(Columns.Count, 1);

            foreach (ColumnHeader column in Columns)
            {
                column.Width = columnWidth;
            }
        }

        protected override void OnNotifyMessage(Message m)
        {
            //Filter out the WM_ERASEBKGND message
            if (m.Msg != 0x14)
            {
                base.OnNotifyMessage(m);
            }
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

        protected override void OnSizeChanged(EventArgs e)
        {
            if (!_resizing)
            {
                _resizing = true;

                ApplyLayout();
            }

            _resizing = false;
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
