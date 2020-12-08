using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace BerryClient
{
    public class CountriesClient
        : ICountriesClient
    {
        private readonly IOperationExecutor _executor;

        public CountriesClient(IOperationExecutor executor)
        {
            _executor = executor ?? throw new ArgumentNullException(nameof(executor));
        }

        public Task<IOperationResult<IMyQuery>> MyQueryAsync() =>
            MyQueryAsync(CancellationToken.None);

        public Task<IOperationResult<IMyQuery>> MyQueryAsync(
            CancellationToken cancellationToken)
        {

            return _executor.ExecuteAsync(
                new MyQueryOperation(),
                cancellationToken);
        }
    }
}
