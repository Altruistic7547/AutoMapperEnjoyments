using AutoMapperEnjoyments.Core.IdealDataModels.Purchasing;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.Purchasing;
using Shouldly;

namespace AutoMapperEnjoyments.MapsUnitTests
{
    [TestClass]
    public class PurchasingMapUnitTests : UnitTestBase
    {
        [TestMethod]
        public void ProductDataModel_ProductDto_int_Map_Test()
        {
            var source = new ProductDataModel()
            {
                ProductId = 000989,
                StockQuantity = int.MinValue,
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.ProductId.ShouldBe(source.ProductId);
            destination.StockQuantity.ShouldBe(source.StockQuantity);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_string_Map_Test()
        {
            var source = new ProductDataModel()
            {
                ProductName = "SampleString1",
                Category = "string.Empty",
                ProductDescription = "string.Empty",
                SKU = "string.Empty",
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.ProductName.ShouldBe(source.ProductName);
            destination.Category.ShouldBe(source.Category);
            destination.ProductDescription.ShouldBe(source.ProductDescription);
            destination.SKU.ShouldBe(source.SKU);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_decimal_Map_Test()
        {
            var source = new ProductDataModel()
            {
                Price = 42.42m,
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.Price.ShouldBe(source.Price);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_DateTime_Map_Test()
        {
            var source = new ProductDataModel()
            {
                DateAdded = DateTime.UtcNow.AddYears(2),
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.DateAdded.ShouldBe(source.DateAdded);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_float_Map_Test()
        {
            var source = new ProductDataModel()
            {
                DiscountRate = float.E,
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.DiscountRate.ShouldBe(source.DiscountRate);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_Guid_Map_Test()
        {
            var source = new ProductDataModel()
            {
                SupplierId = Guid.Empty,
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.SupplierId.ShouldBe(source.SupplierId);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_bool_Map_Test()
        {
            var source = new ProductDataModel()
            {
                IsAvailable = false,
            };

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ProductDto>();

            destination.IsAvailable.ShouldBe(source.IsAvailable);
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_Null_Map_Test()
        {
            ProductDataModel source = null;

            var destination = _mapper.Map<ProductDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void ProductDataModel_ProductDto_List_Map_Test()
        {
            var sourceList = new List<ProductDataModel>()
            {
                new ProductDataModel()
                {
                    ProductId = int.MaxValue,
                    ProductName = "TestName",
                    Category = "SampleString1",
                    Price = 123.45m,
                    StockQuantity = int.MinValue,
                    DateAdded = DateTime.Now,
                    DiscountRate = default,
                    Tags = new(){ "","String",null },
                    SupplierId = Guid.Empty,
                    IsAvailable = true,
                    ProductDescription = "TestName",
                    SKU = "ExampleText",
                }
            };

            var destinationList = _mapper.Map<List<ProductDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].ProductId.ShouldBe(sourceList[i].ProductId);
                destinationList[i].ProductName.ShouldBe(sourceList[i].ProductName);
                destinationList[i].Category.ShouldBe(sourceList[i].Category);
                destinationList[i].Price.ShouldBe(sourceList[i].Price);
                destinationList[i].StockQuantity.ShouldBe(sourceList[i].StockQuantity);
                destinationList[i].DateAdded.ShouldBe(sourceList[i].DateAdded);
                destinationList[i].DiscountRate.ShouldBe(sourceList[i].DiscountRate);
                destinationList[i].Tags.ShouldBe(sourceList[i].Tags);
                destinationList[i].SupplierId.ShouldBe(sourceList[i].SupplierId);
                destinationList[i].IsAvailable.ShouldBe(sourceList[i].IsAvailable);
                destinationList[i].ProductDescription.ShouldBe(sourceList[i].ProductDescription);
                destinationList[i].SKU.ShouldBe(sourceList[i].SKU);
            }
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_int_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                OrderId = int.MaxValue,
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.OrderId.ShouldBe(source.OrderId);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_Guid_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                CustomerId = default,
                TransactionId = default,
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.CustomerId.ShouldBe(source.CustomerId);
            destination.TransactionId.ShouldBe(source.TransactionId);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_DateTime_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                OrderDate = DateTime.Now,
                ShipmentDate = DateTime.UtcNow.AddYears(2),
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.OrderDate.ShouldBe(source.OrderDate);
            destination.ShipmentDate.ShouldBe(source.ShipmentDate);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_decimal_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                TotalAmount = 123.45m,
                TaxAmount = 123.45m,
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.TotalAmount.ShouldBe(source.TotalAmount);
            destination.TaxAmount.ShouldBe(source.TaxAmount);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_string_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                OrderStatus = "TestName",
                ShippingAddress = "SampleString1",
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.OrderStatus.ShouldBe(source.OrderStatus);
            destination.ShippingAddress.ShouldBe(source.ShippingAddress);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_bool_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                IsGiftWrapped = false,
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.IsGiftWrapped.ShouldBe(source.IsGiftWrapped);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_char_Map_Test()
        {
            var source = new PurchaseOrderDataModel()
            {
                OrderPriority = default,
            };

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PurchaseOrderDto>();

            destination.OrderPriority.ShouldBe(source.OrderPriority);
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_Null_Map_Test()
        {
            PurchaseOrderDataModel source = null;

            var destination = _mapper.Map<PurchaseOrderDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void PurchaseOrderDataModel_PurchaseOrderDto_List_Map_Test()
        {
            var sourceList = new List<PurchaseOrderDataModel>()
            {
                new PurchaseOrderDataModel()
                {
                    OrderId = 000989,
                    CustomerId = default,
                    OrderDate = DateTime.Now,
                    ShipmentDate = new DateTime(2022, 1, 1),
                    TotalAmount = 42.42m,
                    OrderStatus = "ExampleText",
                    IsGiftWrapped = true,
                    ShippingAddress = "ExampleText",
                    TaxAmount = 123.45m,
                    TransactionId = default,
                    OrderPriority = default,
                }
            };

            var destinationList = _mapper.Map<List<PurchaseOrderDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].OrderId.ShouldBe(sourceList[i].OrderId);
                destinationList[i].CustomerId.ShouldBe(sourceList[i].CustomerId);
                destinationList[i].OrderDate.ShouldBe(sourceList[i].OrderDate);
                destinationList[i].ShipmentDate.ShouldBe(sourceList[i].ShipmentDate);
                destinationList[i].TotalAmount.ShouldBe(sourceList[i].TotalAmount);
                destinationList[i].OrderStatus.ShouldBe(sourceList[i].OrderStatus);
                destinationList[i].IsGiftWrapped.ShouldBe(sourceList[i].IsGiftWrapped);
                destinationList[i].ShippingAddress.ShouldBe(sourceList[i].ShippingAddress);
                destinationList[i].TaxAmount.ShouldBe(sourceList[i].TaxAmount);
                destinationList[i].TransactionId.ShouldBe(sourceList[i].TransactionId);
                destinationList[i].OrderPriority.ShouldBe(sourceList[i].OrderPriority);
            }
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_Guid_Map_Test()
        {
            var source = new SupplierInformationDataModel()
            {
                SupplierId = default,
            };

            var destination = _mapper.Map<SupplierInformationDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplierInformationDto>();

            destination.SupplierId.ShouldBe(source.SupplierId);
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_string_Map_Test()
        {
            var source = new SupplierInformationDataModel()
            {
                CompanyName = "ExampleText",
                ContactPerson = "TestName",
                ContactEmail = "string.Empty",
                PhoneNumber = "string.Empty",
                Country = "ExampleText",
            };

            var destination = _mapper.Map<SupplierInformationDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplierInformationDto>();

            destination.CompanyName.ShouldBe(source.CompanyName);
            destination.ContactPerson.ShouldBe(source.ContactPerson);
            destination.ContactEmail.ShouldBe(source.ContactEmail);
            destination.PhoneNumber.ShouldBe(source.PhoneNumber);
            destination.Country.ShouldBe(source.Country);
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_DateTime_Map_Test()
        {
            var source = new SupplierInformationDataModel()
            {
                ContractStartDate = DateTime.UtcNow.AddYears(2),
                ContractEndDate = DateTime.UtcNow.AddYears(2),
            };

            var destination = _mapper.Map<SupplierInformationDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplierInformationDto>();

            destination.ContractStartDate.ShouldBe(source.ContractStartDate);
            destination.ContractEndDate.ShouldBe(source.ContractEndDate);
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_bool_Map_Test()
        {
            var source = new SupplierInformationDataModel()
            {
                IsPreferredSupplier = false,
            };

            var destination = _mapper.Map<SupplierInformationDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplierInformationDto>();

            destination.IsPreferredSupplier.ShouldBe(source.IsPreferredSupplier);
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_short_Map_Test()
        {
            var source = new SupplierInformationDataModel()
            {
                SupplierRating = default,
            };

            var destination = _mapper.Map<SupplierInformationDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplierInformationDto>();

            destination.SupplierRating.ShouldBe(source.SupplierRating);
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_Null_Map_Test()
        {
            SupplierInformationDataModel source = null;

            var destination = _mapper.Map<SupplierInformationDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void SupplierInformationDataModel_SupplierInformationDto_List_Map_Test()
        {
            var sourceList = new List<SupplierInformationDataModel>()
            {
                new SupplierInformationDataModel()
                {
                    SupplierId = default,
                    CompanyName = "ExampleText",
                    ContactPerson = "ExampleText",
                    ContactEmail = "ExampleText",
                    ContractStartDate = DateTime.Now,
                    ContractEndDate = DateTime.UtcNow.AddYears(2),
                    IsPreferredSupplier = false,
                    PhoneNumber = "string.Empty",
                    SupplierRating = default,
                    Country = "ExampleText",
                }
            };

            var destinationList = _mapper.Map<List<SupplierInformationDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].SupplierId.ShouldBe(sourceList[i].SupplierId);
                destinationList[i].CompanyName.ShouldBe(sourceList[i].CompanyName);
                destinationList[i].ContactPerson.ShouldBe(sourceList[i].ContactPerson);
                destinationList[i].ContactEmail.ShouldBe(sourceList[i].ContactEmail);
                destinationList[i].ContractStartDate.ShouldBe(sourceList[i].ContractStartDate);
                destinationList[i].ContractEndDate.ShouldBe(sourceList[i].ContractEndDate);
                destinationList[i].IsPreferredSupplier.ShouldBe(sourceList[i].IsPreferredSupplier);
                destinationList[i].PhoneNumber.ShouldBe(sourceList[i].PhoneNumber);
                destinationList[i].SupplierRating.ShouldBe(sourceList[i].SupplierRating);
                destinationList[i].Country.ShouldBe(sourceList[i].Country);
            }
        }
    }
}
