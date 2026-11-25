public sealed record DemoItem(string Id, string Title);

public interface IDemoCatalog
{
    Task<DemoItem?> FindAsync(string id, CancellationToken cancellationToken);
}
