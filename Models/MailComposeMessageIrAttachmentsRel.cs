using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_compose_message AND ir_attachment
/// </summary>
public partial class MailComposeMessageIrAttachmentsRel
{
    public int WizardId { get; set; }

    public int AttachmentId { get; set; }

    public virtual IrAttachment Attachment { get; set; } = null!;

    public virtual MailComposeMessage Wizard { get; set; } = null!;
}
