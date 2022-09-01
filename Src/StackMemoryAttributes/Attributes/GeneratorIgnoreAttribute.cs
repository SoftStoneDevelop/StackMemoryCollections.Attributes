using System;

namespace StackMemoryCollections.Attibutes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class GeneratorIgnoreAttribute : Attribute
    {
    }
}