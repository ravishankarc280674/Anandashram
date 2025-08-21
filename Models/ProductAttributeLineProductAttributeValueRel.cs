using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN product_attribute_line AND product_attribute_value
/// </summary>
public partial class ProductAttributeLineProductAttributeValueRel
{
    public int LineId { get; set; }

    public int ValId { get; set; }

    public virtual ProductAttributeLine Line { get; set; } = null!;

    public virtual ProductAttributeValue Val { get; set; } = null!;
}
