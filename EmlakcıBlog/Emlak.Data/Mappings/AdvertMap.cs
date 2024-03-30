using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgent.Data.Mappings
{
    public class AdvertMap : IEntityTypeConfiguration<Advert>
    {
        public void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.HasData(new Advert
            {
                AdvertId = 1,
                Title = "villa",
                Description = "3+2 sıfır villa",
                Room = 3,
                Price = 1300
               

            },
            new Advert
            {
				AdvertId = 2,
				Title = "ev",
				Description = "3+2 sıfır ev",
				Room = 4,
				Price = 1200
			}
            ) ;
        }
    }
}
