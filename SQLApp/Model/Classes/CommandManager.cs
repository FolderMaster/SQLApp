using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLApp.Model.Classes
{
    public static class CommandManager
    {
        public static string SelectAll { get; } = "SELECT *";

        public static string From { get; } = "FROM";

        public static string Where { get; } = "WHERE";

        public static string OrderBy { get; } = "ORDER BY";

        public static string CreateTable { get; } = "CREATE TABLE";

        public static string NotNull { get; } = "NOT NULL";

        public static string PrimaryKey { get; } = "PRIMARY KEY";

        public static string Default { get; } = "DEFAULT";

        public static string AlterTable { get; } = "ALTER TABLE";

        public static string DropColumn { get; } = "DROP COLUMN";

        public static string Not { get; } = "NOT";

        public static string And { get; } = "AND";

        public static string Or { get; } = "OR";

        public static string Like { get; } = "LIKE";

        public static string Equal { get; } = "=";

        public static string NotEqual { get; } = "<>";

        public static string More { get; } = ">";

        public static string MoreOrEqual { get; } = ">=";

        public static string Less { get; } = "<";

        public static string LessOrEqual { get; } = "<=";

        public static string TableName { get; } = "TABLE_NAME";

        public static string IsNullable { get; } = "IS_NULLABLE";

        public static string ColumnDefault { get; } = "COLUMN_DEFAULT";

        public static string DataType { get; } = "DATA_TYPE";

        public static string ColumnName { get; } = "COLUMN_NAME";

        public static string Columns { get; } = "Columns";

        public static string Tables { get; } = "Tables";

        public static string No { get; } = "NO";
    }
}
