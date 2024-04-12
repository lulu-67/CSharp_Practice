// See https://aka.ms/new-console-template for more information


using ConsoleApp4;

GenericRepository<IEntity> repository = new GenericRepository<IEntity>();
IEntity entity = new Entity();
entity.id = 1;
repository.Add(entity);
Console.WriteLine(repository.GetAll());
Console.WriteLine(repository.GetById(1));
