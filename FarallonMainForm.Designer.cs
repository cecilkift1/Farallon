using Farallon.CustomControls;

namespace Farallon
{
    partial class FarallonMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarallonMainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.listViewPortfolio = new Farallon.CustomControls.CustomListView();
            this.columnHeaderSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTradeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListTrades = new System.Windows.Forms.ImageList(this.components);
            this.labelTrades = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewPortfolio
            // 
            this.listViewPortfolio.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewPortfolio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPortfolio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderSymbol,
            this.columnHeaderTradeDate,
            this.columnHeaderQuantity,
            this.columnHeaderAction,
            this.columnHeaderPrice,
            this.columnHeaderCost});
            this.listViewPortfolio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPortfolio.FullRowSelect = true;
            this.listViewPortfolio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPortfolio.HideSelection = false;
            this.listViewPortfolio.HotTracking = true;
            this.listViewPortfolio.HoverSelection = true;
            this.listViewPortfolio.Location = new System.Drawing.Point(13, 114);
            this.listViewPortfolio.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPortfolio.MultiSelect = false;
            this.listViewPortfolio.Name = "listViewPortfolio";
            this.listViewPortfolio.OwnerDraw = true;
            this.listViewPortfolio.ShowGroups = false;
            this.listViewPortfolio.Size = new System.Drawing.Size(960, 266);
            this.listViewPortfolio.SmallImageList = this.imageListTrades;
            this.listViewPortfolio.TabIndex = 1;
            this.listViewPortfolio.UseCompatibleStateImageBehavior = false;
            this.listViewPortfolio.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderSymbol
            // 
            this.columnHeaderSymbol.Text = "Symbol";
            this.columnHeaderSymbol.Width = 160;
            // 
            // columnHeaderTradeDate
            // 
            this.columnHeaderTradeDate.Text = "Trade Date";
            this.columnHeaderTradeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTradeDate.Width = 160;
            // 
            // columnHeaderQuantity
            // 
            this.columnHeaderQuantity.Text = "Quantity";
            this.columnHeaderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderQuantity.Width = 160;
            // 
            // columnHeaderAction
            // 
            this.columnHeaderAction.Text = "Action";
            this.columnHeaderAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAction.Width = 160;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Price";
            this.columnHeaderPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderPrice.Width = 160;
            // 
            // columnHeaderCost
            // 
            this.columnHeaderCost.Text = "Cost";
            this.columnHeaderCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderCost.Width = 160;
            // 
            // imageListTrades
            // 
            this.imageListTrades.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListTrades.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListTrades.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelTrades
            // 
            this.labelTrades.AutoSize = true;
            this.labelTrades.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.labelTrades.Location = new System.Drawing.Point(10, 92);
            this.labelTrades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrades.Name = "labelTrades";
            this.labelTrades.Size = new System.Drawing.Size(52, 16);
            this.labelTrades.TabIndex = 2;
            this.labelTrades.Text = "Trades";
            // 
            // FarallonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.labelTrades);
            this.Controls.Add(this.listViewPortfolio);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FarallonMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cecil Kift - Farallon Portfolio Demo";
            this.Load += new System.EventHandler(this.FarallonMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CustomListView listViewPortfolio;
        private System.Windows.Forms.ColumnHeader columnHeaderSymbol;
        private System.Windows.Forms.ColumnHeader columnHeaderQuantity;
        private System.Windows.Forms.ColumnHeader columnHeaderAction;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Label labelTrades;
        private System.Windows.Forms.ColumnHeader columnHeaderTradeDate;
        private System.Windows.Forms.ColumnHeader columnHeaderCost;
        private System.Windows.Forms.ImageList imageListTrades;
    }
}

