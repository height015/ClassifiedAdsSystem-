using System;
namespace Core.DominLayer.Catalog
{
    public enum AttributeValueType
    {
        /// <summary>
        /// Simple attribute value
        /// </summary>
        Simple = 0,

        /// <summary>
        /// Associated to a product (used when configuring bundled products)
        /// </summary>
        AssociatedToProduct = 10,
    }
}


