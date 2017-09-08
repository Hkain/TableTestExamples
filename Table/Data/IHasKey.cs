namespace Table.Data
{
    public interface IHasKey<TKey>
    {
        TKey Id { get; set; }
    }
}