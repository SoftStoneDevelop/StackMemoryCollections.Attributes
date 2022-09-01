using System;

namespace StackMemoryAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AsPointerAttribute : Attribute
    {
    }
}