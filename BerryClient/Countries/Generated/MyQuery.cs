using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class MyQuery
        : IMyQuery
    {
        public MyQuery(
            IReadOnlyList<ICountry> countries)
        {
            Countries = countries;
        }

        public IReadOnlyList<ICountry> Countries { get; }
    }
}
