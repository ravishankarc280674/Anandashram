using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN email_template AND ir_attachment
/// </summary>
public partial class EmailTemplateAttachmentRel
{
    public int EmailTemplateId { get; set; }

    public int AttachmentId { get; set; }

    public virtual IrAttachment Attachment { get; set; } = null!;

    public virtual EmailTemplate EmailTemplate { get; set; } = null!;
}
