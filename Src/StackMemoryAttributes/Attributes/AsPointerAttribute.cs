using System;

namespace StackMemoryAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class AsPointerAttribute : Attribute
    {
    }
}