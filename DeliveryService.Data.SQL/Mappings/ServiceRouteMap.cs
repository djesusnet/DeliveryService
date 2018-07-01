using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryService.Data.SQL.Mappings
{
	public class ServiceRouteMap : IEntityTypeConfiguration<Application.Domain.Models.ServiceRoute>
    {
		void IEntityTypeConfiguration<Application.Domain.Models.ServiceRoute>.Configure(EntityTypeBuilder<Application.Domain.Models.ServiceRoute> builder)
        {
            builder.ToTable("Service");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
			builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
			builder.Property(x => x.Time).HasColumnName("Time").IsRequired();
			builder.Property(x => x.Cost).HasColumnName("Cost").IsRequired();

        }

    }
}
