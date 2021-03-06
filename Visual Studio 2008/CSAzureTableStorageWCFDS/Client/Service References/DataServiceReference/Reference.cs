//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 04/12/2011 17:16:36
namespace Client.DataServiceReference
{
    
    /// <summary>
    /// There are no comments for PersonDataServiceContext in the schema.
    /// </summary>
    public partial class PersonDataServiceContext : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new PersonDataServiceContext object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public PersonDataServiceContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Microsoft.WindowsAzure.StorageClient", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Client.DataServiceReference.Microsoft.WindowsAzure.StorageClient", typeName.Substring(36)), false);
            }
            if (typeName.StartsWith("WebRole.Entities", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Client.DataServiceReference", typeName.Substring(16)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Client.DataServiceReference.Microsoft.WindowsAzure.StorageClient", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Microsoft.WindowsAzure.StorageClient.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Client.DataServiceReference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("WebRole.Entities.", clientType.Name);
            }
            return clientType.FullName;
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Person> Person
        {
            get
            {
                if ((this._Person == null))
                {
                    this._Person = base.CreateQuery<Person>("Person");
                }
                return this._Person;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Person> _Person;
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToPerson(Person person)
        {
            base.AddObject("Person", person);
        }
    }
    /// <summary>
    /// There are no comments for WebRole.Entities.Person in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartitionKey
    /// RowKey
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("PartitionKey", "RowKey")]
    public partial class Person : Client.DataServiceReference.Microsoft.WindowsAzure.StorageClient.TableServiceEntity
    {
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="timestamp">Initial value of Timestamp.</param>
        /// <param name="partitionKey">Initial value of PartitionKey.</param>
        /// <param name="rowKey">Initial value of RowKey.</param>
        /// <param name="age">Initial value of Age.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Person CreatePerson(global::System.DateTime timestamp, string partitionKey, string rowKey, int age)
        {
            Person person = new Person();
            person.Timestamp = timestamp;
            person.PartitionKey = partitionKey;
            person.RowKey = rowKey;
            person.Age = age;
            return person;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Age in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                this.OnAgeChanging(value);
                this._Age = value;
                this.OnAgeChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Age;
        partial void OnAgeChanging(int value);
        partial void OnAgeChanged();
    }
}
// Original file name:
// Generation date: 04/12/2011 17:16:36
namespace Client.DataServiceReference.Microsoft.WindowsAzure.StorageClient
{
    
    /// <summary>
    /// There are no comments for Microsoft.WindowsAzure.StorageClient.TableServiceEntity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartitionKey
    /// RowKey
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("PartitionKey", "RowKey")]
    public abstract partial class TableServiceEntity
    {
        /// <summary>
        /// There are no comments for Property Timestamp in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Timestamp
        {
            get
            {
                return this._Timestamp;
            }
            set
            {
                this.OnTimestampChanging(value);
                this._Timestamp = value;
                this.OnTimestampChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Timestamp;
        partial void OnTimestampChanging(global::System.DateTime value);
        partial void OnTimestampChanged();
        /// <summary>
        /// There are no comments for Property PartitionKey in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string PartitionKey
        {
            get
            {
                return this._PartitionKey;
            }
            set
            {
                this.OnPartitionKeyChanging(value);
                this._PartitionKey = value;
                this.OnPartitionKeyChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _PartitionKey;
        partial void OnPartitionKeyChanging(string value);
        partial void OnPartitionKeyChanged();
        /// <summary>
        /// There are no comments for Property RowKey in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string RowKey
        {
            get
            {
                return this._RowKey;
            }
            set
            {
                this.OnRowKeyChanging(value);
                this._RowKey = value;
                this.OnRowKeyChanged();
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _RowKey;
        partial void OnRowKeyChanging(string value);
        partial void OnRowKeyChanged();
    }
}
