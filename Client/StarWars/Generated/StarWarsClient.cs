using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace Client
{
    public class StarWarsClient
        : IStarWarsClient
    {
        private readonly IOperationExecutor _executor;

        public StarWarsClient(IOperationExecutor executor)
        {
            _executor = executor ?? throw new ArgumentNullException(nameof(executor));
        }

        public Task<IOperationResult<IGetBook>> GetBookAsync() =>
            GetBookAsync(CancellationToken.None);

        public Task<IOperationResult<IGetBook>> GetBookAsync(
            CancellationToken cancellationToken)
        {

            return _executor.ExecuteAsync(
                new GetBookOperation(),
                cancellationToken);
        }
    }
}
