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

    // CustomerDemographics
    public partial class CustomerDemographicConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CustomerDemographic>
    {
        public CustomerDemographicConfiguration()
            : this("dbo")
        {
        }
 
        public CustomerDemographicConfiguration(string schema)
        {
            ToTable(schema + ".CustomerDemographics");
            HasKey(x => x.CustomerTypeId);

            Property(x => x.CustomerTypeId).HasColumnName("CustomerTypeID").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CustomerDesc).HasColumnName("CustomerDesc").IsOptional().HasColumnType("ntext").IsMaxLength();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
