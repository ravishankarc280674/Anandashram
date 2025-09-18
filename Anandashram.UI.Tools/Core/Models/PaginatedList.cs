namespace Anandashram.UI.Tools.Core.Models
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalRecords { get; private set; }

            public PaginatedList(List<T> source, int pageIndex, int pageSize)
            {
                TotalRecords = source.Count;
                List<T> collection = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                AddRange(collection);
            }
        }
    }
