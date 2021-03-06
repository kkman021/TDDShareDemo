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

    // Order Details Extended
    public partial class OrderDetailsExtended
    {
        public int OrderId { get; set; } // OrderID
        public int ProductId { get; set; } // ProductID
        public string ProductName { get; set; } // ProductName
        public decimal UnitPrice { get; set; } // UnitPrice
        public short Quantity { get; set; } // Quantity
        public float Discount { get; set; } // Discount
        public decimal? ExtendedPrice { get; set; } // ExtendedPrice
        
        public OrderDetailsExtended()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
