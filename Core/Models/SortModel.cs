using Anandashram.Core.Enums;

namespace Anandashram.Core.Models
{
    public class SortModel
    {

        private string UpIcon = "fa fa-arrow-up";
        private string DownIcon = "fa fa-arrow-down";
        public string SortedProperty { get; set; }
        public SortOrder SortedOrder{ get; set; }
        public List<SortableColumn> sortableColumns = new List<SortableColumn>();

        public void AddColumn(string column,bool IsDefaultColumn =false)
        {
            SortableColumn tmp = this.sortableColumns.Where(c=> c.ColumnName.ToLower()== column.ToLower()).SingleOrDefault();
            if (tmp == null)
                sortableColumns.Add(new SortableColumn() { ColumnName = column });
            if(IsDefaultColumn || sortableColumns.Count ==1)
            {
                SortedProperty = column;
                SortedOrder = SortOrder.Ascending;
            }
        }
        public SortableColumn GetColumn(string columnName)
        {
            SortableColumn tmp = this.sortableColumns.Where(c => c.ColumnName.ToLower() == columnName.ToLower()).SingleOrDefault();
            if (tmp == null)
                sortableColumns.Add(new SortableColumn() { ColumnName = columnName});
            return tmp;
        }

        public void ApplySort(string sortExpression)
        {
            if (sortExpression == "")
                sortExpression = this.SortedProperty;
            sortExpression = sortExpression.ToLower();

            foreach (SortableColumn sortableColumn in this.sortableColumns)
            {
                sortableColumn.SortIcon = "";
                sortableColumn.SortExpression = sortableColumn.ColumnName;
                if(sortExpression == sortableColumn.ColumnName.ToLower())
                {
                    this.SortedProperty = sortableColumn.ColumnName;
                    this.SortedOrder = SortOrder.Ascending;
                    sortableColumn.SortIcon = DownIcon;
                    sortableColumn.SortExpression = sortableColumn.ColumnName + "_desc";
                }
                if (sortExpression == sortableColumn.ColumnName.ToLower() + "_desc")
                {
                    this.SortedProperty = sortableColumn.ColumnName;
                    this.SortedOrder = SortOrder.Descending;
                    sortableColumn.SortIcon = DownIcon;
                    sortableColumn.SortExpression = sortableColumn.ColumnName;
                }
            }
            //switch (sortExpression.ToLower())
            //{
            //    case "name_desc":
            //        this.SortedProperty = "name";
            //        this.SortedOrder = SortOrder.Descending;
            //        this.GetColumn("name").SortIcon = UpIcon;
            //        this.GetColumn("name").SortExpression = "name";
            //        break;
            //    default:
            //        this.SortedProperty = "name";
            //        this.SortedOrder = SortOrder.Ascending;
            //        this.GetColumn("name").SortIcon = DownIcon;
            //        this.GetColumn("name").SortExpression = "name_desc";
            //        break;
            //}
        }
    }

    public class SortableColumn
    {
        public string ColumnName { get; set; }
        public string SortExpression { get; set; }
        public string SortIcon { get; set; }
    }
}
