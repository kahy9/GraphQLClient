using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class Country
        : ICountry
    {
        public Country(
            string name, 
            string phone, 
            string capital)
        {
            Name = name;
            Phone = phone;
            Capital = capital;
        }

        public string Name { get; }

        public string Phone { get; }

        public string Capital { get; }
    }
}
