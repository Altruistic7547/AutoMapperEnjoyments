using AutoMapperEnjoyments.Core.IdealDataModels;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects;
using Shouldly;

namespace AutoMapperEnjoyments.MapsUnitTests
{
    [TestClass]
    public class ExplorationUnitTests : UnitTestBase
    {

        [TestMethod]
        public void SourceTypeExploration_DestinationTypeExploration_Int_Map_Test()
        {
            var source = new SourceTypeExploration()
            {
                Age = 00030,
                Balance = int.MaxValue
            };

            var destination = _mapper.Map<DestinationTypeExploration>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<DestinationTypeExploration>();

            destination.Age.ShouldBe(destination.Age);
            destination.Balance.ShouldBe(destination.Balance);
        }

        [TestMethod]
        public void SourceTypeExploration_DestinationTypeExploration_String_Map_Test()
        {
            var source = new SourceTypeExploration()
            {
                Name = string.Empty
            };

            var destination = _mapper.Map<DestinationTypeExploration>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<DestinationTypeExploration>();

            destination.Name.ShouldBe(destination.Name);
        }
    }
}
