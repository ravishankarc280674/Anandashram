using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// db.backup
/// </summary>
public partial class DbBackup
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Auto. Remove Backups
    /// </summary>
    public bool? Autoremove { get; set; }

    /// <summary>
    /// Remove SFTP after x days
    /// </summary>
    public int? Daystokeepsftp { get; set; }

    /// <summary>
    /// Database
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Path external server
    /// </summary>
    public string? Sftppath { get; set; }

    /// <summary>
    /// Password User SFTP Server
    /// </summary>
    public string? Sftppassword { get; set; }

    /// <summary>
    /// Port
    /// </summary>
    public string Port { get; set; } = null!;

    /// <summary>
    /// IP Address SFTP Server
    /// </summary>
    public string? Sftpip { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Backup Directory
    /// </summary>
    public string BkpDir { get; set; } = null!;

    /// <summary>
    /// Write to external server with sftp
    /// </summary>
    public bool? Sftpwrite { get; set; }

    /// <summary>
    /// Host
    /// </summary>
    public string Host { get; set; } = null!;

    /// <summary>
    /// Remove after x days
    /// </summary>
    public int Daystokeep { get; set; }

    /// <summary>
    /// E-mail to notify
    /// </summary>
    public string? Emailtonotify { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Auto. E-mail on backup fail
    /// </summary>
    public bool? Sendmailsftpfail { get; set; }

    /// <summary>
    /// Username SFTP Server
    /// </summary>
    public string? Sftpusername { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
