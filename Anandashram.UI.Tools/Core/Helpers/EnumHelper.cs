using Anandashram.UI.Tools.Core.Models;

namespace Anandashram.UI.Tools.Core.Helpers;
    public static class EnumHelper
    {
        public static List<SelectItem> GetEnumList<T>()
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => new SelectItem
                {
                    Text = e.ToString(),
                    Value = Convert.ToInt32(e).ToString()
                }).ToList();
        }
    }
