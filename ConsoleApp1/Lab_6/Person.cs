using Lab_6;
namespace Lab_6
{
    public class Person : IEntity<int>, ICreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}