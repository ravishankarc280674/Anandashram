// copilot
namespace Anandashram.UI.Tools.Core.Models;
public class ApiResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }

    public static ApiResponse Ok(string message = "")
    {
        return new ApiResponse { Success = true, Message = message };
    }

    public static ApiResponse Fail(string message)
    {
        return new ApiResponse { Success = false, Message = message };
    }
}
