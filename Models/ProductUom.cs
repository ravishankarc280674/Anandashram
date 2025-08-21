using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Product Unit of Measure
/// </summary>
public partial class ProductUom
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Rounding Precision
    /// </summary>
    public decimal Rounding { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Ratio
    /// </summary>
    public decimal Factor { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string UomType { get; set; } = null!;

    /// <summary>
    /// Unit of Measure Category
    /// </summary>
    public int CategoryId { get; set; }

    public virtual ProductUomCateg Category { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MakeProcurement> MakeProcurements { get; set; } = new List<MakeProcurement>();

    public virtual ICollection<ProcurementOrder> ProcurementOrderProductUomNavigations { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementOrder> ProcurementOrderProductUosNavigations { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProductTemplate> ProductTemplateUomPos { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProductTemplateUoms { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProductTemplateUos { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockMove> StockMoveProductUomNavigations { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveProductUosNavigations { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMoveScrap> StockMoveScraps { get; set; } = new List<StockMoveScrap>();

    public virtual ICollection<StockPackOperation> StockPackOperations { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItems { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ResUser? WriteU { get; set; }
}
