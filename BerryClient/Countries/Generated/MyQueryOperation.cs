using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class MyQueryOperation
        : IOperation<IMyQuery>
    {
        public string Name => "myQuery";

        public IDocument Document => Querries.Default;

        public Type ResultType => typeof(IMyQuery);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
