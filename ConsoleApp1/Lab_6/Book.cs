using Lab_6;
namespace Lab_6
{
    public class Book : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
    }
}