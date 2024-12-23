namespace Shared.DDD
{
    public abstract class Entity<T>: IEntity<T>
    {
        public T Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CrearedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
