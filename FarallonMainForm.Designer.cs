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
            this.imageListTrades = new System.Windows.Forms.ImageList(this.components);
            this.labelTrades = new System.Windows.Forms.Label();
            this.listViewProfitAndLoss = new Farallon.CustomControls.CustomListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProfitAndLoss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 710);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
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
            this.listViewPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.listViewPortfolio.Portfolio = null;
            this.listViewPortfolio.PortfolioViewType = Farallon.Enums.PortfolioViewType.Trades;
            this.listViewPortfolio.ShowGroups = false;
            this.listViewPortfolio.Size = new System.Drawing.Size(960, 266);
            this.listViewPortfolio.SmallImageList = this.imageListTrades;
            this.listViewPortfolio.TabIndex = 1;
            this.listViewPortfolio.UseCompatibleStateImageBehavior = false;
            this.listViewPortfolio.View = System.Windows.Forms.View.Details;
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
            // listViewProfitAndLoss
            // 
            this.listViewProfitAndLoss.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewProfitAndLoss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProfitAndLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProfitAndLoss.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProfitAndLoss.FullRowSelect = true;
            this.listViewProfitAndLoss.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProfitAndLoss.HideSelection = false;
            this.listViewProfitAndLoss.HotTracking = true;
            this.listViewProfitAndLoss.HoverSelection = true;
            this.listViewProfitAndLoss.Location = new System.Drawing.Point(13, 414);
            this.listViewProfitAndLoss.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProfitAndLoss.MultiSelect = false;
            this.listViewProfitAndLoss.Name = "listViewProfitAndLoss";
            this.listViewProfitAndLoss.OwnerDraw = true;
            this.listViewProfitAndLoss.Portfolio = null;
            this.listViewProfitAndLoss.PortfolioViewType = Farallon.Enums.PortfolioViewType.ProfitAndLoss;
            this.listViewProfitAndLoss.ShowGroups = false;
            this.listViewProfitAndLoss.Size = new System.Drawing.Size(960, 266);
            this.listViewProfitAndLoss.SmallImageList = this.imageListTrades;
            this.listViewProfitAndLoss.TabIndex = 3;
            this.listViewProfitAndLoss.UseCompatibleStateImageBehavior = false;
            this.listViewProfitAndLoss.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Symbol";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Trade Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 20;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 20;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Action";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 20;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Price";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 20;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Cost";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 20;
            // 
            // labelProfitAndLoss
            // 
            this.labelProfitAndLoss.AutoSize = true;
            this.labelProfitAndLoss.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfitAndLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.labelProfitAndLoss.Location = new System.Drawing.Point(11, 396);
            this.labelProfitAndLoss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfitAndLoss.Name = "labelProfitAndLoss";
            this.labelProfitAndLoss.Size = new System.Drawing.Size(103, 16);
            this.labelProfitAndLoss.TabIndex = 4;
            this.labelProfitAndLoss.Text = "Profit and Loss";
            // 
            // FarallonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.labelProfitAndLoss);
            this.Controls.Add(this.listViewProfitAndLoss);
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
        private System.Windows.Forms.Label labelTrades;
        private System.Windows.Forms.ImageList imageListTrades;
        private CustomListView listViewProfitAndLoss;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelProfitAndLoss;
    }
}

