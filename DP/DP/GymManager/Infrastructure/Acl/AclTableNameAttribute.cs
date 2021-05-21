using System;

namespace GymManager.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AclTableNameAttribute : Attribute
    {
        public AclTableNameAttribute(string tableName)
        {
            TableName = tableName;
        }

        public string TableName { get; set; }
    }
}