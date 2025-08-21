using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN product_attribute_value AND product_product
/// </summary>
public partial class ProductAttributeValueProductProductRel
{
    public int AttId { get; set; }

    public int ProdId { get; set; }

    public virtual ProductAttributeValue Att { get; set; } = null!;

    public virtual ProductProduct Prod { get; set; } = null!;
}
