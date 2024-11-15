using Autofac;
using AutoMapper;
using AutoMapperEnjoyments.Core;
using AutoMapperEnjoyments.Core.IdealDataModels;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects;

Console.WriteLine("Hello, Welcome!!!, Hope you will enjoy AutoMapper and Data types exploration");

var container = ConfigureContainer();

using (var scope = container.BeginLifetimeScope())
{
    var mapper = scope.Resolve<IMapper>();

    // Sample test mapping
    var source = new SourceTypeExploration { Name = "John Doe", Age = 30 };
    var destination = mapper.Map <DestinationTypeExploration>(source);

    Console.WriteLine($"Mapped Name: {destination.Name}, Mapped Age: {destination.Age}");
}



static IContainer ConfigureContainer()
{
    var builder = new ContainerBuilder();

    builder.RegisterInstance(MapperConfig.InitializeAutoMapper()).As<IMapper>().SingleInstance();

    return builder.Build();
}