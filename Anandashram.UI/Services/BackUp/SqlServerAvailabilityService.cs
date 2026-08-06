using Anandashram.Interfaces.Services.Backup;
using Microsoft.Data.SqlClient;

namespace Anandashram.Services.Backup;

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
public class SqlServerAvailabilityService : IDatabaseAvailabilityService
{
    private const int MaxRetryCount = 10;

    private static readonly TimeSpan RetryDelay =
        TimeSpan.FromSeconds(30);

    private readonly IConfiguration _configuration;
    private readonly ILogger<SqlServerAvailabilityService> _logger;


    public SqlServerAvailabilityService(
        IConfiguration configuration,
        ILogger<SqlServerAvailabilityService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }


    #region << SQL Server >>

    /// <summary>
    /// Attempts to establish a connection with SQL Server.
    /// Retries until SQL Server becomes available or the retry
    /// limit is reached.
    /// </summary>
    public async Task<bool> EnsureSqlServerIsAvailableAsync(
        CancellationToken cancellationToken = default)
    {
        // Read the connection string once.
        // A missing connection string is a configuration error,
        // not a SQL Server availability issue.
        string connectionString =
            _configuration.GetConnectionString("AnandashramDBConnection")
            ?? throw new InvalidOperationException(
                "Connection string 'AnandashramDBConnection' was not found.");


        for (int attempt = 1; attempt <= MaxRetryCount; attempt++)
        {
            try
            {
                using SqlConnection connection = new(connectionString);

                await connection.OpenAsync(cancellationToken);

                _logger.LogInformation(
                    "Successfully connected to SQL Server.");

                return true;
            }
            catch (OperationCanceledException)
            {
                // Allow cancellation to propagate immediately.
                throw;
            }
            catch (SqlException ex)
            {
                _logger.LogWarning(
                    ex,
                    "SQL Server is unavailable. Attempt {Attempt} of {MaxRetryCount}.",
                    attempt,
                    MaxRetryCount);


                // No need to wait after the final attempt.
                if (attempt < MaxRetryCount)
                {
                    await Task.Delay(
                        RetryDelay,
                        cancellationToken);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    ex,
                    "An unexpected error occurred while checking SQL Server availability.");

                return false;
            }
        }


        _logger.LogError(
            "SQL Server could not be reached after {MaxRetryCount} attempts.",
            MaxRetryCount);

        return false;
    }

    #endregion
}