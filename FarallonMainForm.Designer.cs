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
            this.listViewPortfolio = new Farallon.CustomControls.CustomListView();
            this.imageListTrades = new System.Windows.Forms.ImageList(this.components);
            this.labelTrades = new System.Windows.Forms.Label();
            this.listViewProfitAndLoss = new Farallon.CustomControls.CustomListView();
            this.labelProfitAndLoss = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonQuote = new System.Windows.Forms.Button();
            this.panelTrades = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxQuote = new System.Windows.Forms.TextBox();
            this.labelQuoteTicker = new System.Windows.Forms.Label();
            this.labelQuoteData = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.panelTrades.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPortfolio
            // 
            this.listViewPortfolio.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewPortfolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPortfolio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPortfolio.FullRowSelect = true;
            this.listViewPortfolio.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPortfolio.HideSelection = false;
            this.listViewPortfolio.HotTracking = true;
            this.listViewPortfolio.HoverSelection = true;
            this.listViewPortfolio.Location = new System.Drawing.Point(11, 28);
            this.listViewPortfolio.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPortfolio.MultiSelect = false;
            this.listViewPortfolio.Name = "listViewPortfolio";
            this.listViewPortfolio.OwnerDraw = true;
            this.listViewPortfolio.Portfolio = null;
            this.listViewPortfolio.PortfolioViewType = Farallon.Enums.PortfolioViewType.Trades;
            this.listViewPortfolio.ShowGroups = false;
            this.listViewPortfolio.Size = new System.Drawing.Size(962, 285);
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
            this.labelTrades.Location = new System.Drawing.Point(6, 10);
            this.labelTrades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrades.Name = "labelTrades";
            this.labelTrades.Size = new System.Drawing.Size(52, 16);
            this.labelTrades.TabIndex = 0;
            this.labelTrades.Text = "Trades";
            // 
            // listViewProfitAndLoss
            // 
            this.listViewProfitAndLoss.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewProfitAndLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProfitAndLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProfitAndLoss.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProfitAndLoss.FullRowSelect = true;
            this.listViewProfitAndLoss.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProfitAndLoss.HideSelection = false;
            this.listViewProfitAndLoss.HotTracking = true;
            this.listViewProfitAndLoss.HoverSelection = true;
            this.listViewProfitAndLoss.Location = new System.Drawing.Point(9, 29);
            this.listViewProfitAndLoss.Margin = new System.Windows.Forms.Padding(2);
            this.listViewProfitAndLoss.MultiSelect = false;
            this.listViewProfitAndLoss.Name = "listViewProfitAndLoss";
            this.listViewProfitAndLoss.OwnerDraw = true;
            this.listViewProfitAndLoss.Portfolio = null;
            this.listViewProfitAndLoss.PortfolioViewType = Farallon.Enums.PortfolioViewType.ProfitAndLoss;
            this.listViewProfitAndLoss.ShowGroups = false;
            this.listViewProfitAndLoss.Size = new System.Drawing.Size(962, 252);
            this.listViewProfitAndLoss.SmallImageList = this.imageListTrades;
            this.listViewProfitAndLoss.TabIndex = 1;
            this.listViewProfitAndLoss.UseCompatibleStateImageBehavior = false;
            this.listViewProfitAndLoss.View = System.Windows.Forms.View.Details;
            // 
            // labelProfitAndLoss
            // 
            this.labelProfitAndLoss.AutoSize = true;
            this.labelProfitAndLoss.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfitAndLoss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.labelProfitAndLoss.Location = new System.Drawing.Point(8, 11);
            this.labelProfitAndLoss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProfitAndLoss.Name = "labelProfitAndLoss";
            this.labelProfitAndLoss.Size = new System.Drawing.Size(103, 16);
            this.labelProfitAndLoss.TabIndex = 0;
            this.labelProfitAndLoss.Text = "Profit and Loss";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.labelQuoteData);
            this.panelBottom.Controls.Add(this.labelQuoteTicker);
            this.panelBottom.Controls.Add(this.textBoxQuote);
            this.panelBottom.Controls.Add(this.buttonQuote);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 706);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(984, 55);
            this.panelBottom.TabIndex = 2;
            // 
            // buttonQuote
            // 
            this.buttonQuote.Location = new System.Drawing.Point(116, 10);
            this.buttonQuote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuote.Name = "buttonQuote";
            this.buttonQuote.Size = new System.Drawing.Size(89, 32);
            this.buttonQuote.TabIndex = 1;
            this.buttonQuote.Text = "Quote";
            this.buttonQuote.UseVisualStyleBackColor = true;
            this.buttonQuote.Click += new System.EventHandler(this.buttonQuote_Click);
            // 
            // panelTrades
            // 
            this.panelTrades.Controls.Add(this.labelTrades);
            this.panelTrades.Controls.Add(this.listViewPortfolio);
            this.panelTrades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTrades.Location = new System.Drawing.Point(0, 64);
            this.panelTrades.Name = "panelTrades";
            this.panelTrades.Size = new System.Drawing.Size(984, 331);
            this.panelTrades.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelProfitAndLoss);
            this.panel2.Controls.Add(this.listViewProfitAndLoss);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 311);
            this.panel2.TabIndex = 1;
            // 
            // textBoxQuote
            // 
            this.textBoxQuote.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxQuote.Location = new System.Drawing.Point(11, 15);
            this.textBoxQuote.Name = "textBoxQuote";
            this.textBoxQuote.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuote.TabIndex = 0;
            this.textBoxQuote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuote_KeyDown);
            // 
            // labelQuoteTicker
            // 
            this.labelQuoteTicker.AutoSize = true;
            this.labelQuoteTicker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuoteTicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.labelQuoteTicker.Location = new System.Drawing.Point(219, 10);
            this.labelQuoteTicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuoteTicker.Name = "labelQuoteTicker";
            this.labelQuoteTicker.Size = new System.Drawing.Size(50, 16);
            this.labelQuoteTicker.TabIndex = 2;
            this.labelQuoteTicker.Text = "Ticker:";
            // 
            // labelQuoteData
            // 
            this.labelQuoteData.AutoSize = true;
            this.labelQuoteData.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuoteData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(53)))), ((int)(((byte)(117)))));
            this.labelQuoteData.Location = new System.Drawing.Point(219, 26);
            this.labelQuoteData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuoteData.Name = "labelQuoteData";
            this.labelQuoteData.Size = new System.Drawing.Size(51, 16);
            this.labelQuoteData.TabIndex = 3;
            this.labelQuoteData.Text = "Quote:";
            // 
            // FarallonMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTrades);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FarallonMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cecil Kift - Farallon Portfolio Demo";
            this.Load += new System.EventHandler(this.FarallonMainForm_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTrades.ResumeLayout(false);
            this.panelTrades.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomListView listViewPortfolio;
        private System.Windows.Forms.Label labelTrades;
        private System.Windows.Forms.ImageList imageListTrades;
        private CustomListView listViewProfitAndLoss;
        private System.Windows.Forms.Label labelProfitAndLoss;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonQuote;
        private System.Windows.Forms.Panel panelTrades;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxQuote;
        private System.Windows.Forms.Label labelQuoteData;
        private System.Windows.Forms.Label labelQuoteTicker;
    }
}

