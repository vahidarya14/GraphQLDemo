using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Client
{
    public class GetBookOperation
        : IOperation<IGetBook>
    {
        public string Name => "getBook";

        public IDocument Document => Queries.Default;

        public Type ResultType => typeof(IGetBook);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
