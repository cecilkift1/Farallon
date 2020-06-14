using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Farallon.Constants;
using Farallon.Helpers;
using Farallon.Interfaces;

namespace Farallon
{
    public class ProfitAndLoss : Table
    {
        internal Trades Trades { get; set; }

        [DisplayName("Ticker")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Left,
            ValueStringFormat = FormattingConstants.DefaultFormat)]
        public string Ticker { get; set; }

        [DisplayName("As of Date")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Center,
            ValueStringFormat = FormattingConstants.DateFormat)]
        public DateTime AsOfDate { get; set; }

        [DisplayName("Cost")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal Cost { get; set; }

        [DisplayName("Quantity")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.IntegerFormat)]
        public int Quantity { get; set; }

        [ DisplayName("Price")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal Price { get; set; }

        [DisplayName("Market Value")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal MarketValue { get; set; }

        [DisplayName("Previous Close")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal PreviousClose { get; set; }

        [DisplayName("Daily P&L")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal DailyProfitAndLoss { get; set; }

        [DisplayName("Inception P&L")]
        [Column(
            HorizontalAlignment = HorizontalAlignment.Right,
            ValueStringFormat = FormattingConstants.CurrencyFormat)]
        public decimal InceptionProfitAndLoss { get; set; }

        public override PropertyInfo[] Properties()
        {
            return typeof(ProfitAndLoss).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        public IList<IRow> Rows()
        {
            var rows = new List<IRow>();
            return rows;
        }
    }
}