﻿namespace AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment
{
    public class InGamePurchaseInvoice
    {
        public string InvoiceReference { get; set; }

        public DateTimeOffset? InvoiceDate { get; set; }

        public string PaymentReference { get; set; }

        public decimal? InvoiceValue { get; set; }

        public decimal? GstValue { get; set; }

        public string WithholdingTaxFlag { get; set; }

        public string InvoiceDescription { get; set; }
    }
}
