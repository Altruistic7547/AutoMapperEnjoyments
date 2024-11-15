using AutoMapper;
using AutoMapperEnjoyments.Core.enums;
using AutoMapperEnjoyments.Core.IdealDataModels.Purchasing;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.Purchasing;

namespace AutoMapperEnjoyments.Core.MappingProfiles
{
    public class PurchasingMappingProfile : Profile
    {
        public PurchasingMappingProfile()
        {
            CreateMap<CustomerProfileDataModel, CustomerProfileDto>()
                .ForMember(x => x.AddressType, z => z.MapFrom(x => x.AddressType == AddressType.Unknown.ToString() ? x.AddressType : null));

            CreateMap<(InvoiceDataModel invoiceData, ProductDataModel productDataModel), InvoiceDto>()
                .ForMember(x => x.SupplierId, z => z.MapFrom(x => x.productDataModel.SupplierId))
                .ForMember(x => x.IsAvailable, z => z.MapFrom(x => x.productDataModel.IsAvailable))
                .ForMember(x => x.ProductDescription, z => z.MapFrom(x => x.productDataModel.ProductDescription))
                .ForMember(x => x.DueDate, z => z.MapFrom(x => x.invoiceData.DueDate))
                .ForMember(x => x.IsPaid, z => z.MapFrom(x => x.invoiceData.IsPaid))
                .ForMember(x => x.PaymentMethod, z => z.MapFrom(x => x.invoiceData.PaymentMethod))
                .ForMember(x => x.Notes, z => z.MapFrom(x => x.invoiceData.Notes))
                .ForMember(x => x.InvoiceId, z => z.MapFrom(x => x.invoiceData.InvoiceId))
                .ForMember(x => x.OrderId, z => z.MapFrom(x => x.invoiceData.OrderId))
                .ForMember(x => x.InvoiceDate, z => z.MapFrom(x => x.invoiceData.InvoiceDate))
                .ForMember(x => x.AmountDue, z => z.MapFrom(x => x.invoiceData.AmountDue))
                .ForMember(x => x.CustomerId, z => z.MapFrom(x => x.invoiceData.CustomerId))
                .ForMember(x => x.LineItems, z => z.MapFrom(x => x.invoiceData.LineItems))
                .ForMember(x => x.LateFee, z => z.MapFrom(x => x.invoiceData.LateFee))
                .ForMember(x => x.CurrencyCode, z => z.MapFrom(x => x.invoiceData.CurrencyCode));


            CreateMap<(PaymentTransactionDataModel paymentTransactionData, ProductDto ProductDto), PaymentTransactionDto>()
                .ForPath(x => x.Product.SupplierId, z => z.MapFrom(v => v.ProductDto.SupplierId))
                .ForPath(x => x.Product.ProductId, z => z.MapFrom(v => v.ProductDto.ProductId))
                .ForPath(x => x.Product.ProductDescription, z => z.MapFrom(v => v.ProductDto.ProductDescription))
                .ForPath(x => x.Product.ProductName, z => z.MapFrom(v => v.ProductDto.ProductName))
                .ForPath(x => x.Product.Price, z => z.MapFrom(v => v.ProductDto.Price))
                .ForPath(x => x.Product.SKU, z => z.MapFrom(v => v.ProductDto.SKU))
                .ForPath(x => x.Product.Category, z => z.MapFrom(v => v.ProductDto.Category))
                .ForPath(x => x.Product.DateAdded, z => z.MapFrom(v => v.ProductDto.DateAdded))

                .ForMember(x => x.OrderId, z => z.MapFrom(v => v.paymentTransactionData.OrderId))
                .ForMember(x => x.CustomerId, z => z.MapFrom(v => v.paymentTransactionData.CustomerId))
                .ForMember(x => x.InvoiceId, z => z.MapFrom(v => v.paymentTransactionData.InvoiceId))
                .ForMember(x => x.TransactionId, z => z.MapFrom(v => v.paymentTransactionData.TransactionId))
                .ForMember(x => x.IsSuccessful, z => z.MapFrom(v => v.paymentTransactionData.IsSuccessful))
                .ForMember(x => x.ConfirmationNumber, z => z.MapFrom(v => v.paymentTransactionData.ConfirmationNumber))
                .ForMember(x => x.Currency, z => z.MapFrom(v => v.paymentTransactionData.Currency))
                .ForMember(x => x.TransactionAmount, z => z.MapFrom(v => v.paymentTransactionData.TransactionAmount))
                .ForMember(x => x.TransactionDate, z => z.MapFrom(v => v.paymentTransactionData.TransactionDate))
                .ForMember(x => x.PaymentType, z => z.MapFrom(v => v.paymentTransactionData.PaymentType))
                .ForMember(x => x.TransactionStatus, z => z.MapFrom(v => v.paymentTransactionData.TransactionStatus))
                .ForMember(x => x.RefundDate, z => z.MapFrom(v => v.paymentTransactionData.RefundDate));

            CreateMap<ProductDataModel, ProductDto>();

            CreateMap<PurchaseOrderDataModel, PurchaseOrderDto>();

            CreateMap<SupplierInformationDataModel, SupplierInformationDto>();
        }
    }
}
