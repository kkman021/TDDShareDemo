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

    // Category Sales for 1997
    public partial class CategorySalesFor1997Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CategorySalesFor1997>
    {
        public CategorySalesFor1997Configuration()
            : this("dbo")
        {
        }
 
        public CategorySalesFor1997Configuration(string schema)
        {
            ToTable(schema + ".Category Sales for 1997");
            HasKey(x => x.CategoryName);

            Property(x => x.CategoryName).HasColumnName("CategoryName").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.CategorySales).HasColumnName("CategorySales").IsOptional().HasColumnType("money").HasPrecision(19,4);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
