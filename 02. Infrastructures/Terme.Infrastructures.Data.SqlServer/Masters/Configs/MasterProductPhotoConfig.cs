﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Terme.Core.Domain.Masters.Entities;

namespace Terme.Infrastructures.Data.SqlServer.Masters.Configs
{
    public class MasterProductPhotoConfig : IEntityTypeConfiguration<MasterProductPhoto>
    {
        public void Configure(EntityTypeBuilder<MasterProductPhoto> builder)
        {
            builder.HasOne(c => c.Photo).WithMany().HasForeignKey(c => c.PhotoId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
