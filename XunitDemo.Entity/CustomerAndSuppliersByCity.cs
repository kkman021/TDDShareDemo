// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.52
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace XunitDemo.Entity
{
    using System;
    using System.Data.Entity;

    // Customer and Suppliers by City
    public partial class CustomerAndSuppliersByCity
    {
        public string City { get; set; } // City
        public string CompanyName { get; set; } // CompanyName
        public string ContactName { get; set; } // ContactName
        public string Relationship { get; set; } // Relationship
        
        public CustomerAndSuppliersByCity()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
