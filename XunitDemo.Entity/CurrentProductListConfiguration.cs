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

    // Current Product List
    public partial class CurrentProductListConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CurrentProductList>
    {
        public CurrentProductListConfiguration()
            : this("dbo")
        {
        }
 
        public CurrentProductListConfiguration(string schema)
        {
            ToTable(schema + ".Current Product List");
            HasKey(x => new { x.ProductId, x.ProductName });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProductName).HasColumnName("ProductName").IsRequired().HasColumnType("nvarchar").HasMaxLength(40);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
