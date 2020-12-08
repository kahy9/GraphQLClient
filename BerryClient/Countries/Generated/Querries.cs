using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace BerryClient
{
    public class Querries
        : IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            70,
            106,
            116,
            68,
            48,
            76,
            52,
            120,
            90,
            100,
            118,
            77,
            48,
            67,
            102,
            54,
            103,
            56,
            72,
            116,
            57,
            103,
            61,
            61
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            109,
            121,
            81,
            117,
            101,
            114,
            121,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            99,
            111,
            117,
            110,
            116,
            114,
            105,
            101,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            112,
            104,
            111,
            110,
            101,
            32,
            99,
            97,
            112,
            105,
            116,
            97,
            108,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Querries Default { get; } = new Querries();

        public override string ToString() => 
            @"query myQuery {
              countries {
                name
                phone
                capital
              }
            }";
    }
}
