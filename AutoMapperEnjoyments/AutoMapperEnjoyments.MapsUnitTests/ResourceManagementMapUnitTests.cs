
using AutoMapperEnjoyments.Core.IdealDataModels.ResourceManagement;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.ResourceManagement;
using Shouldly;

namespace AutoMapperEnjoyments.MapsUnitTests
{
    [TestClass]
    public class ResourceManagementMapUnitTests : UnitTestBase
    {
        [TestMethod]
        public void Validate()
        {
            _mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_int_Map_Test()
        {
            var source = new FinanceResourceDataModel()
            {
                BudgetId = 789,
            };

            var destination = _mapper.Map<FinanceResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<FinanceResourceDto>();

            destination.BudgetId.ShouldBe(source.BudgetId);
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_decimal_Map_Test()
        {
            var source = new FinanceResourceDataModel()
            {
                AllocatedAmount = 678.90m,
                SpentAmount = 678.90m,
                RemainingAmount = 123.45m,
            };

            var destination = _mapper.Map<FinanceResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<FinanceResourceDto>();

            destination.AllocatedAmount.ShouldBe(source.AllocatedAmount);
            destination.SpentAmount.ShouldBe(source.SpentAmount);
            destination.RemainingAmount.ShouldBe(source.RemainingAmount);
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_string_Map_Test()
        {
            var source = new FinanceResourceDataModel()
            {
                BudgetType = "TestName",
                ManagerName = "TestName",
                ProjectName = "TestName",
                Currency = "ExampleText",
            };

            var destination = _mapper.Map<FinanceResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<FinanceResourceDto>();

            destination.BudgetType.ShouldBe(source.BudgetType);
            destination.ManagerName.ShouldBe(source.ManagerName);
            destination.ProjectName.ShouldBe(source.ProjectName);
            destination.Currency.ShouldBe(source.Currency);
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_DateTime_Map_Test()
        {
            var source = new FinanceResourceDataModel()
            {
                StartDate = new DateTime(2022, 1, 1),
                EndDate = new DateTime(2022, 1, 1),
                ApprovalDate = DateTime.UtcNow,
            };

            var destination = _mapper.Map<FinanceResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<FinanceResourceDto>();

            destination.StartDate.ShouldBe(source.StartDate);
            destination.EndDate.ShouldBe(source.EndDate);
            destination.ApprovalDate.ShouldBe(source.ApprovalDate);
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_bool_Map_Test()
        {
            var source = new FinanceResourceDataModel()
            {
                IsApproved = true,
            };

            var destination = _mapper.Map<FinanceResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<FinanceResourceDto>();

            destination.IsApproved.ShouldBe(source.IsApproved);
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_Null_Map_Test()
        {
            FinanceResourceDataModel source = null;

            var destination = _mapper.Map<FinanceResourceDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void FinanceResourceDataModel_FinanceResourceDto_List_Map_Test()
        {
            var sourceList = new List<FinanceResourceDataModel>()
            {
                new FinanceResourceDataModel()
                {
                    BudgetId = 123,
                    AllocatedAmount = 123.45m,
                    SpentAmount = 42.42m,
                    RemainingAmount = 42.42m,
                    BudgetType = "SampleString1",
                    StartDate = DateTime.UtcNow,
                    EndDate = DateTime.UtcNow,
                    ManagerName = "SampleString1",
                    IsApproved = false,
                    ApprovalDate = DateTime.Now,
                    ProjectName = "ExampleText",
                    Currency = "SampleString1",
                }
            };

            var destinationList = _mapper.Map<List<FinanceResourceDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].BudgetId.ShouldBe(sourceList[i].BudgetId);
                destinationList[i].AllocatedAmount.ShouldBe(sourceList[i].AllocatedAmount);
                destinationList[i].SpentAmount.ShouldBe(sourceList[i].SpentAmount);
                destinationList[i].RemainingAmount.ShouldBe(sourceList[i].RemainingAmount);
                destinationList[i].BudgetType.ShouldBe(sourceList[i].BudgetType);
                destinationList[i].StartDate.ShouldBe(sourceList[i].StartDate);
                destinationList[i].EndDate.ShouldBe(sourceList[i].EndDate);
                destinationList[i].ManagerName.ShouldBe(sourceList[i].ManagerName);
                destinationList[i].IsApproved.ShouldBe(sourceList[i].IsApproved);
                destinationList[i].ApprovalDate.ShouldBe(sourceList[i].ApprovalDate);
                destinationList[i].ProjectName.ShouldBe(sourceList[i].ProjectName);
                destinationList[i].Currency.ShouldBe(sourceList[i].Currency);
            }
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_int_Map_Test()
        {
            var source = new HumanResourceDataModel()
            {
                EmployeeId = 123,
            };

            var destination = _mapper.Map<HumanResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<HumanResourceDto>();

            destination.EmployeeId.ShouldBe(source.EmployeeId);
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_string_Map_Test()
        {
            var source = new HumanResourceDataModel()
            {
                FirstName = "TestName",
                LastName = "SampleString1",
                Position = "SampleString1",
                Department = "TestName",
                Email = "SampleString1",
                PhoneNumber = "ExampleText",
            };

            var destination = _mapper.Map<HumanResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<HumanResourceDto>();

            destination.FirstName.ShouldBe(source.FirstName);
            destination.LastName.ShouldBe(source.LastName);
            destination.Position.ShouldBe(source.Position);
            destination.Department.ShouldBe(source.Department);
            destination.Email.ShouldBe(source.Email);
            destination.PhoneNumber.ShouldBe(source.PhoneNumber);
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_DateTime_Map_Test()
        {
            var source = new HumanResourceDataModel()
            {
                HireDate = DateTime.UtcNow,
                DateOfBirth = DateTime.Now,
            };

            var destination = _mapper.Map<HumanResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<HumanResourceDto>();

            destination.HireDate.ShouldBe(source.HireDate);
            destination.DateOfBirth.ShouldBe(source.DateOfBirth);
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_decimal_Map_Test()
        {
            var source = new HumanResourceDataModel()
            {
                Salary = 123.45m,
            };

            var destination = _mapper.Map<HumanResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<HumanResourceDto>();

            destination.Salary.ShouldBe(source.Salary);
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_bool_Map_Test()
        {
            var source = new HumanResourceDataModel()
            {
                IsFullTime = true,
                IsActive = false,
            };

            var destination = _mapper.Map<HumanResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<HumanResourceDto>();

            destination.IsFullTime.ShouldBe(source.IsFullTime);
            destination.IsActive.ShouldBe(source.IsActive);
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_Null_Map_Test()
        {
            HumanResourceDataModel source = null;

            var destination = _mapper.Map<HumanResourceDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void HumanResourceDataModel_HumanResourceDto_List_Map_Test()
        {
            var sourceList = new List<HumanResourceDataModel>()
            {
                new HumanResourceDataModel()
                {
                    EmployeeId = 789,
                    FirstName = "ExampleText",
                    LastName = "TestName",
                    Position = "ExampleText",
                    HireDate = DateTime.UtcNow,
                    Salary = 678.90m,
                    IsFullTime = true,
                    DateOfBirth = new DateTime(2022, 1, 1),
                    Department = "ExampleText",
                    Email = "TestName",
                    PhoneNumber = "ExampleText",
                    IsActive = true,
                }
            };

            var destinationList = _mapper.Map<List<HumanResourceDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].EmployeeId.ShouldBe(sourceList[i].EmployeeId);
                destinationList[i].FirstName.ShouldBe(sourceList[i].FirstName);
                destinationList[i].LastName.ShouldBe(sourceList[i].LastName);
                destinationList[i].Position.ShouldBe(sourceList[i].Position);
                destinationList[i].HireDate.ShouldBe(sourceList[i].HireDate);
                destinationList[i].Salary.ShouldBe(sourceList[i].Salary);
                destinationList[i].IsFullTime.ShouldBe(sourceList[i].IsFullTime);
                destinationList[i].DateOfBirth.ShouldBe(sourceList[i].DateOfBirth);
                destinationList[i].Department.ShouldBe(sourceList[i].Department);
                destinationList[i].Email.ShouldBe(sourceList[i].Email);
                destinationList[i].PhoneNumber.ShouldBe(sourceList[i].PhoneNumber);
                destinationList[i].IsActive.ShouldBe(sourceList[i].IsActive);
            }
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_int_Map_Test()
        {
            var source = new ITResourceDataModel()
            {
                ResourceId = int.MaxValue,
            };

            var destination = _mapper.Map<ITResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ITResourceDto>();

            destination.ResourceId.ShouldBe(source.ResourceId);
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_string_Map_Test()
        {
            var source = new ITResourceDataModel()
            {
                ResourceType = "ExampleText",
                AssetTag = "ExampleText",
                SerialNumber = "string.Empty",
                AssigneDto = "SampleString1",
                Location = "string.Empty",
                MaintenanceProvider = "string.Empty",
            };

            var destination = _mapper.Map<ITResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ITResourceDto>();

            destination.ResourceType.ShouldBe(source.ResourceType);
            destination.AssetTag.ShouldBe(source.AssetTag);
            destination.SerialNumber.ShouldBe(source.SerialNumber);
            destination.AssigneDto.ShouldBe(source.AssigneDto);
            destination.Location.ShouldBe(source.Location);
            destination.MaintenanceProvider.ShouldBe(source.MaintenanceProvider);
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_DateTime_Map_Test()
        {
            var source = new ITResourceDataModel()
            {
                PurchaseDate = DateTime.Now,
                WarrantyEndDate = DateTime.Now,
                LastMaintenanceDate = DateTime.Now,
            };

            var destination = _mapper.Map<ITResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ITResourceDto>();

            destination.PurchaseDate.ShouldBe(source.PurchaseDate);
            destination.WarrantyEndDate.ShouldBe(source.WarrantyEndDate);
            destination.LastMaintenanceDate.ShouldBe(source.LastMaintenanceDate);
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_decimal_Map_Test()
        {
            var source = new ITResourceDataModel()
            {
                Cost = 42.42m,
            };

            var destination = _mapper.Map<ITResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ITResourceDto>();

            destination.Cost.ShouldBe(source.Cost);
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_bool_Map_Test()
        {
            var source = new ITResourceDataModel()
            {
                IsOperational = false,
            };

            var destination = _mapper.Map<ITResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<ITResourceDto>();

            destination.IsOperational.ShouldBe(source.IsOperational);
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_Null_Map_Test()
        {
            ITResourceDataModel source = null;

            var destination = _mapper.Map<ITResourceDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void ITResourceDataModel_ITResourceDto_List_Map_Test()
        {
            var sourceList = new List<ITResourceDataModel>()
            {
                new ITResourceDataModel()
                {
                    ResourceId = 000989,
                    ResourceType = "ExampleText",
                    AssetTag = "SampleString1",
                    SerialNumber = "TestName",
                    PurchaseDate = new DateTime(2022, 1, 1),
                    Cost = 42.42m,
                    WarrantyEndDate = new DateTime(2022, 1, 1),
                    AssigneDto = "ExampleText",
                    Location = "TestName",
                    IsOperational = false,
                    LastMaintenanceDate = DateTime.UtcNow.AddYears(2),
                    MaintenanceProvider = "TestName",
                }
            };

            var destinationList = _mapper.Map<List<ITResourceDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].ResourceId.ShouldBe(sourceList[i].ResourceId);
                destinationList[i].ResourceType.ShouldBe(sourceList[i].ResourceType);
                destinationList[i].AssetTag.ShouldBe(sourceList[i].AssetTag);
                destinationList[i].SerialNumber.ShouldBe(sourceList[i].SerialNumber);
                destinationList[i].PurchaseDate.ShouldBe(sourceList[i].PurchaseDate);
                destinationList[i].Cost.ShouldBe(sourceList[i].Cost);
                destinationList[i].WarrantyEndDate.ShouldBe(sourceList[i].WarrantyEndDate);
                destinationList[i].AssigneDto.ShouldBe(sourceList[i].AssigneDto);
                destinationList[i].Location.ShouldBe(sourceList[i].Location);
                destinationList[i].IsOperational.ShouldBe(sourceList[i].IsOperational);
                destinationList[i].LastMaintenanceDate.ShouldBe(sourceList[i].LastMaintenanceDate);
                destinationList[i].MaintenanceProvider.ShouldBe(sourceList[i].MaintenanceProvider);
            }
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_int_Map_Test()
        {
            var source = new PhysicalResourceDataModel()
            {
                FacilityId = 000989,
            };

            var destination = _mapper.Map<PhysicalResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PhysicalResourceDto>();

            destination.FacilityId.ShouldBe(source.FacilityId);
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_string_Map_Test()
        {
            var source = new PhysicalResourceDataModel()
            {
                FacilityName = "string.Empty",
                FacilityType = "ExampleText",
                Location = "ExampleText",
                OwnerContact = "SampleString1",
            };

            var destination = _mapper.Map<PhysicalResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PhysicalResourceDto>();

            destination.FacilityName.ShouldBe(source.FacilityName);
            destination.FacilityType.ShouldBe(source.FacilityType);
            destination.Location.ShouldBe(source.Location);
            destination.OwnerContact.ShouldBe(source.OwnerContact);
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_decimal_Map_Test()
        {
            var source = new PhysicalResourceDataModel()
            {
                TotalArea = 42.42m,
                UtilizedArea = 42.42m,
                LeaseAmount = 123.45m,
            };

            var destination = _mapper.Map<PhysicalResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PhysicalResourceDto>();

            destination.TotalArea.ShouldBe(source.TotalArea);
            destination.UtilizedArea.ShouldBe(source.UtilizedArea);
            destination.LeaseAmount.ShouldBe(source.LeaseAmount);
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_bool_Map_Test()
        {
            var source = new PhysicalResourceDataModel()
            {
                IsLeased = false,
                IsAvailable = true,
            };

            var destination = _mapper.Map<PhysicalResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PhysicalResourceDto>();

            destination.IsLeased.ShouldBe(source.IsLeased);
            destination.IsAvailable.ShouldBe(source.IsAvailable);
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_DateTime_Map_Test()
        {
            var source = new PhysicalResourceDataModel()
            {
                LeaseStartDate = DateTime.Now,
                LeaseEndDate = DateTime.UtcNow.AddYears(2),
            };

            var destination = _mapper.Map<PhysicalResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PhysicalResourceDto>();

            destination.LeaseStartDate.ShouldBe(source.LeaseStartDate);
            destination.LeaseEndDate.ShouldBe(source.LeaseEndDate);
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_Null_Map_Test()
        {
            PhysicalResourceDataModel source = null;

            var destination = _mapper.Map<PhysicalResourceDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void PhysicalResourceDataModel_PhysicalResourceDto_List_Map_Test()
        {
            var sourceList = new List<PhysicalResourceDataModel>()
            {
                new PhysicalResourceDataModel()
                {
                    FacilityId = int.MaxValue,
                    FacilityName = "ExampleText",
                    FacilityType = "TestName",
                    TotalArea = 678.90m,
                    UtilizedArea = 678.90m,
                    Location = "SampleString1",
                    IsLeased = true,
                    LeaseStartDate = DateTime.UtcNow.AddYears(2),
                    LeaseEndDate = new DateTime(2022, 1, 1),
                    LeaseAmount = 123.45m,
                    OwnerContact = "string.Empty",
                    IsAvailable = false,
                }
            };

            var destinationList = _mapper.Map<List<PhysicalResourceDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].FacilityId.ShouldBe(sourceList[i].FacilityId);
                destinationList[i].FacilityName.ShouldBe(sourceList[i].FacilityName);
                destinationList[i].FacilityType.ShouldBe(sourceList[i].FacilityType);
                destinationList[i].TotalArea.ShouldBe(sourceList[i].TotalArea);
                destinationList[i].UtilizedArea.ShouldBe(sourceList[i].UtilizedArea);
                destinationList[i].Location.ShouldBe(sourceList[i].Location);
                destinationList[i].IsLeased.ShouldBe(sourceList[i].IsLeased);
                destinationList[i].LeaseStartDate.ShouldBe(sourceList[i].LeaseStartDate);
                destinationList[i].LeaseEndDate.ShouldBe(sourceList[i].LeaseEndDate);
                destinationList[i].LeaseAmount.ShouldBe(sourceList[i].LeaseAmount);
                destinationList[i].OwnerContact.ShouldBe(sourceList[i].OwnerContact);
                destinationList[i].IsAvailable.ShouldBe(sourceList[i].IsAvailable);
            }
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_int_Map_Test()
        {
            var source = new SupplyChainResourceDataModel()
            {
                SupplyId = int.MaxValue,
                Quantity = 000989,
            };

            var destination = _mapper.Map<SupplyChainResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplyChainResourceDto>();

            destination.SupplyId.ShouldBe(source.SupplyId);
            destination.Quantity.ShouldBe(source.Quantity);
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_string_Map_Test()
        {
            var source = new SupplyChainResourceDataModel()
            {
                ItemName = "string.Empty",
                SupplierName = "TestName",
                WarehouseLocation = "string.Empty",
                ShipmentTrackingNumber = "SampleString1",
                Category = "TestName",
            };

            var destination = _mapper.Map<SupplyChainResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplyChainResourceDto>();

            destination.ItemName.ShouldBe(source.ItemName);
            destination.SupplierName.ShouldBe(source.SupplierName);
            destination.WarehouseLocation.ShouldBe(source.WarehouseLocation);
            destination.ShipmentTrackingNumber.ShouldBe(source.ShipmentTrackingNumber);
            destination.Category.ShouldBe(source.Category);
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_decimal_Map_Test()
        {
            var source = new SupplyChainResourceDataModel()
            {
                UnitPrice = 123.45m,
            };

            var destination = _mapper.Map<SupplyChainResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplyChainResourceDto>();

            destination.UnitPrice.ShouldBe(source.UnitPrice);
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_DateTime_Map_Test()
        {
            var source = new SupplyChainResourceDataModel()
            {
                OrderDate = DateTime.Now,
                ExpectedDeliveryDate = new DateTime(2022, 1, 1),
                DeliveryDate = DateTime.UtcNow.AddYears(2),
            };

            var destination = _mapper.Map<SupplyChainResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplyChainResourceDto>();

            destination.OrderDate.ShouldBe(source.OrderDate);
            destination.ExpectedDeliveryDate.ShouldBe(source.ExpectedDeliveryDate);
            destination.DeliveryDate.ShouldBe(source.DeliveryDate);
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_bool_Map_Test()
        {
            var source = new SupplyChainResourceDataModel()
            {
                IsDelivered = false,
            };

            var destination = _mapper.Map<SupplyChainResourceDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<SupplyChainResourceDto>();

            destination.IsDelivered.ShouldBe(source.IsDelivered);
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_Null_Map_Test()
        {
            SupplyChainResourceDataModel source = null;

            var destination = _mapper.Map<SupplyChainResourceDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void SupplyChainResourceDataModel_SupplyChainResourceDto_List_Map_Test()
        {
            var sourceList = new List<SupplyChainResourceDataModel>()
            {
                new SupplyChainResourceDataModel()
                {
                    SupplyId = int.MinValue,
                    ItemName = "SampleString1",
                    SupplierName = "SampleString1",
                    Quantity = 000989,
                    UnitPrice = 678.90m,
                    OrderDate = new DateTime(2022, 1, 1),
                    ExpectedDeliveryDate = DateTime.Now,
                    WarehouseLocation = "TestName",
                    IsDelivered = false,
                    DeliveryDate = DateTime.Now,
                    ShipmentTrackingNumber = "string.Empty",
                    Category = "SampleString1",
                }
            };

            var destinationList = _mapper.Map<List<SupplyChainResourceDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].SupplyId.ShouldBe(sourceList[i].SupplyId);
                destinationList[i].ItemName.ShouldBe(sourceList[i].ItemName);
                destinationList[i].SupplierName.ShouldBe(sourceList[i].SupplierName);
                destinationList[i].Quantity.ShouldBe(sourceList[i].Quantity);
                destinationList[i].UnitPrice.ShouldBe(sourceList[i].UnitPrice);
                destinationList[i].OrderDate.ShouldBe(sourceList[i].OrderDate);
                destinationList[i].ExpectedDeliveryDate.ShouldBe(sourceList[i].ExpectedDeliveryDate);
                destinationList[i].WarehouseLocation.ShouldBe(sourceList[i].WarehouseLocation);
                destinationList[i].IsDelivered.ShouldBe(sourceList[i].IsDelivered);
                destinationList[i].DeliveryDate.ShouldBe(sourceList[i].DeliveryDate);
                destinationList[i].ShipmentTrackingNumber.ShouldBe(sourceList[i].ShipmentTrackingNumber);
                destinationList[i].Category.ShouldBe(sourceList[i].Category);
            }
        }
    }
}
