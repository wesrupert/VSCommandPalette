// Guids.cs
// MUST match guids.h
using System;

namespace oradev.CommandPalette
{
    static class GuidList
    {
        public const string guidCommandPalettePkgString = "73e075c4-c2b8-4d9f-8eca-424494a01cca";
        public const string guidCommandPaletteCmdSetString = "10d5c22f-ef51-44ec-bc57-cd31d8dcd9c2";

        public static readonly Guid guidCommandPaletteCmdSet = new Guid(guidCommandPaletteCmdSetString);
    };
}