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

    // Region
    public partial class RegionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
            : this("dbo")
        {
        }
 
        public RegionConfiguration(string schema)
        {
            ToTable(schema + ".Region");
            HasKey(x => x.RegionId);

            Property(x => x.RegionId).HasColumnName("RegionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RegionDescription).HasColumnName("RegionDescription").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
