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

            foreach (var columnHeader in columns.Select(column => new CustomColumnHeader
            {
                Text = column.Text,
                TextAlign = column.TextAlign,
                MinimumWidth = column.MinimumWidth
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

        private void PaintItemBackground(DrawListViewItemEventArgs args)
        {
            var backgroundBrush = Brushes.Gainsboro;
            if (args.State == ListViewItemStates.Selected ||
                args.State == ListViewItemStates.Focused ||
                args.State == ListViewItemStates.Hot)
            {
                backgroundBrush = Brushes.White;
            }

            if (args.ItemIndex == Items.Count - 1 && 
                PortfolioViewType == PortfolioViewType.ProfitAndLoss)
            {
                backgroundBrush = Brushes.Gainsboro;
            }

            args.Graphics.FillRectangle(backgroundBrush, args.Bounds);
        }

        private int ColumnsCountWithMinimumWidth()
        {
            return Columns.Cast<CustomColumnHeader>().Count(columnHeader => columnHeader.MinimumWidth != 0);
        }

        private int ColumnsMinimumWidth()
        {
            return Columns.Cast<CustomColumnHeader>().Sum(columnHeader => columnHeader.MinimumWidth);
        }

        private void ApplyLayout()
        {
            var columnsCountWithMinimumWidth = ColumnsCountWithMinimumWidth();
            var defaultColumnWidth = (ClientRectangle.Width - ColumnsMinimumWidth()) / 
                                     Math.Max(Columns.Count - columnsCountWithMinimumWidth, 1);

            foreach (CustomColumnHeader column in Columns)
            {
                column.Width = Math.Max(defaultColumnWidth, column.MinimumWidth);
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
            DrawTopBorderLine(e.Graphics, e.Bounds, 3);
            // Draw a bottom line
            e.Graphics.DrawLine(Pens.DarkGray, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            // Draw the text
            using var stringFormat = StringFormat(e.Header.TextAlign);
            using var headerFont = new Font(Font.Name, Font.Size, FontStyle.Bold);
            var textBounds = e.Bounds;
            textBounds.Inflate(e.ColumnIndex == 0 ? 0 : -5, 0);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawString(e.Header.Text, headerFont, new SolidBrush(ForeColor), textBounds, stringFormat);
        }

        private void DrawTopBorderLine(Graphics graphics, Rectangle bounds, int penWidth)
        {
            using var pen = new Pen(Color.RoyalBlue, penWidth);
            graphics.DrawLine(pen, bounds.Left, bounds.Top, bounds.Right, bounds.Top);
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            PaintItemBackground(e);

            if (e.ItemIndex == Items.Count - 1 &&
                PortfolioViewType == PortfolioViewType.ProfitAndLoss)
            {
                DrawTopBorderLine(e.Graphics, e.Bounds, 2);
            }

            DrawItemText(e.ItemIndex, e.Graphics, e.Item.Text, e.Bounds, HorizontalAlignment.Left);
        }

        private Font ItemTextFont(int itemIndex)
        {
            var fontStyle = Font.Style;

            if (itemIndex == Items.Count - 1 &&
                PortfolioViewType == PortfolioViewType.ProfitAndLoss)
            {
                fontStyle = FontStyle.Bold;
            }

            return new Font(Font, fontStyle);
        }

        private void DrawItemText(int index, Graphics graphics, string text, Rectangle bounds, HorizontalAlignment textAlign)
        {
            using var stringFormat = StringFormat(textAlign);
            using var font = ItemTextFont(index);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            graphics.DrawString(text, font, Brushes.Black, bounds, stringFormat);
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            DrawItemText(e.ItemIndex, e.Graphics, e.SubItem.Text, e.Bounds, e.Header.TextAlign);
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
