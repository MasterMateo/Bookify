using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>, IBaseCommand
{
}

public interface ICommand<TResponce> : IRequest<Result<TResponce>>, IBaseCommand
{
}

public interface IBaseCommand
{
}
