using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_message AND ir_attachment
/// </summary>
public partial class MessageAttachmentRel
{
    public int MessageId { get; set; }

    public int AttachmentId { get; set; }

    public virtual IrAttachment Attachment { get; set; } = null!;

    public virtual MailMessage Message { get; set; } = null!;
}
