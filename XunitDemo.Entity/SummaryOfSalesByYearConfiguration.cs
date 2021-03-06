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

    // Summary of Sales by Year
    public partial class SummaryOfSalesByYearConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SummaryOfSalesByYear>
    {
        public SummaryOfSalesByYearConfiguration()
            : this("dbo")
        {
        }
 
        public SummaryOfSalesByYearConfiguration(string schema)
        {
            ToTable(schema + ".Summary of Sales by Year");
            HasKey(x => x.OrderId);

            Property(x => x.ShippedDate).HasColumnName("ShippedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("int");
            Property(x => x.Subtotal).HasColumnName("Subtotal").IsOptional().HasColumnType("money").HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
