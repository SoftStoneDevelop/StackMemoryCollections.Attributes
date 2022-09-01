using System;

namespace StackMemoryCollections.Attibutes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class GenerateListAttribute : Attribute
    {
    }
}