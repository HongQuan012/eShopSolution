using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            //Tên bảng
            builder.ToTable("AppConfigs");
            //Có khóa chính
            builder.HasKey(x => x.Key);
            //bắt buộc phải nhập
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
