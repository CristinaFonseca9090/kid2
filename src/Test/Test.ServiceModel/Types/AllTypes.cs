﻿using System;
using System.Collections.Generic;

namespace Test.ServiceModel.Types
{
    public class AllTypes
    {
        public int Id { get; set; }
        public int? NullableId { get; set; }
        public byte Byte { get; set; }
        public short Short { get; set; }
        public int Int { get; set; }
        public long Long { get; set; }
        public UInt16 UShort { get; set; }
        public uint UInt { get; set; }
        public ulong ULong { get; set; }
        public float Float { get; set; }
        public double Double { get; set; }
        public decimal Decimal { get; set; }
        public string String { get; set; }
        public DateTime DateTime { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public DateTime? NullableDateTime { get; set; }
        public TimeSpan? NullableTimeSpan { get; set; }
        public List<string> StringList { get; set; }
        public string[] StringArray { get; set; }
        public Dictionary<string, string> StringMap { get; set; }
        public Dictionary<int, string> IntStringMap { get; set; }
        public SubType SubType { get; set; }
    }

    public class AllCollectionTypes
    {
        public int[] IntArray { get; set; }
        public List<int> IntList { get; set; }

        public string[] StringArray { get; set; }
        public List<string> StringList { get; set; }

        public Poco[] PocoArray { get; set; }
        public List<Poco> PocoList { get; set; }
    }

    public class Poco
    {
        public string Name { get; set; }
    }

    public class HelloBase
    {
        public int Id { get; set; }
    }

    public class HelloResponseBase
    {
        public int RefId { get; set; }
    }

    public class HelloType
    {
        public string Result { get; set; }
    }

    public class HelloWithReturnResponse
    {
        public string Result { get; set; }
    }

    public class SubType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}