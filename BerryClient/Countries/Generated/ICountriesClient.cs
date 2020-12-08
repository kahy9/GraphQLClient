using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BerryClient
{
    public interface ICountriesClient
    {
        Task<IOperationResult<IMyQuery>> MyQueryAsync();

        Task<IOperationResult<IMyQuery>> MyQueryAsync(
            CancellationToken cancellationToken);
    }
}
