using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace Client
{
    public interface IStarWarsClient
    {
        Task<IOperationResult<IGetBook>> GetBookAsync();

        Task<IOperationResult<IGetBook>> GetBookAsync(
            CancellationToken cancellationToken);
    }
}
