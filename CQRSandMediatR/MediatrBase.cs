using MediatR;

namespace CQRSandMediatR
{
    /// <summary>
    /// Base class for 'Command' instances.
    /// </summary>
    /// <typeparam name="T">Request type.</typeparam>
    public abstract class CommandBase : IRequest { }

    /// <summary>
    /// Base class for 'Query' instances with a return.
    /// </summary>
    /// <typeparam name="T">Response type.</typeparam>
    public abstract class QueryBase<TResult> : IRequest<TResult> { }
}
