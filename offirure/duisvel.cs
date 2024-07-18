using System.Threading;
using System.Threading.Tasks;

public static class PostMethodExtensions
{
    // Extension method definition
    public static Task PostAsync<T>(
        this IHasPostMethodBuilder2<IAsyncPostMethod2, T> postMethod,
        T body,
        CancellationToken cancellationToken)
    {
        // Calls the PostAsync method on the Client property of postMethod
        return postMethod.Client.PostAsync(body, cancellationToken);
    }
}

// Assuming these interfaces exist in your codebase:
public interface IAsyncPostMethod2
{
    Task PostAsync<T>(T body, CancellationToken cancellationToken);
}

public interface IHasPostMethodBuilder2<out TClient, T>
{
    TClient Client { get; }
}
