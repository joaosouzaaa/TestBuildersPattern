namespace TestBuildersPattern.ClassLibrary.Entities;
public sealed class Client
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string Author { get; set; }
    public required int Age { get; set; }
}

