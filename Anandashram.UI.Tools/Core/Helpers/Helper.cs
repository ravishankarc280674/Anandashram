namespace Anandashram.UI.Tools.Core.Helpers;
public class Helper
{
    public static string  GetTypeNames(string fullTypeName)
    {
        string retString = "";
        try
        {
            int lastIndex = fullTypeName.LastIndexOf('.') + 1;
            retString = fullTypeName.Substring(lastIndex, fullTypeName.Length - lastIndex);
        }
        catch
        {
            retString = fullTypeName;
        }
        
       return retString.Replace("]","");
    }
}
