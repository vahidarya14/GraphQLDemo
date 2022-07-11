using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace Client
{
    public class Queries
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
            90,
            109,
            90,
            85,
            51,
            90,
            80,
            103,
            112,
            114,
            75,
            97,
            51,
            67,
            119,
            67,
            103,
            53,
            117,
            82,
            98,
            119,
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
            103,
            101,
            116,
            66,
            111,
            111,
            107,
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
            98,
            111,
            111,
            107,
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
            116,
            105,
            116,
            108,
            101,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query getBook {
              book {
                title
              }
            }";
    }
}
