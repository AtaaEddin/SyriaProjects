namespace SyriaProjects.Server.Models
{
    public class BaseEntity<T>
    {
        public T Id { get; set; } = default!;
    }
}
