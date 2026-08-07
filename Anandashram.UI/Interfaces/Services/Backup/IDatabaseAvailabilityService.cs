namespace Anandashram.Interfaces.Services.Backup;

/// <summary>
/// Ensures SQL Server is available before any database-related
/// backup operation is performed.
///
/// Responsibility:
///     Confirm that SQL Server can accept a connection.
///
/// Not Responsible:
///     - Performing database backups.
///     - Verifying backup files.
///     - Creating backup folders.
///     - Logging backup results.
/// </summary>
public interface IDatabaseAvailabilityService
{
    /// <summary>
    /// Attempts to establish a connection with SQL Server.
    /// Retries for a configured period before reporting failure.
    /// </summary>
    /// <param name="cancellationToken">
    /// Token used to cancel the operation.
    /// </param>
    /// <returns>
    /// True when SQL Server becomes available; otherwise, false.
    /// </returns>
    Task<bool> EnsureSqlServerIsAvailableAsync(
        CancellationToken cancellationToken = default);
}
