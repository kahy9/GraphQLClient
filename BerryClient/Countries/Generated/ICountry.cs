using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public interface ICountry
    {
        string Name { get; }

        string Phone { get; }

        string Capital { get; }
    }
}
