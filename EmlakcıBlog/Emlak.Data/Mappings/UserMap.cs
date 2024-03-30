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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
              UserId = 1,
              UserName = "mert",
              Email = "mert@gmail.com",
              Password = 1111,
              PhoneNumber = 123456
            },
            new User
            {
				UserId = 2,
				UserName = "arda",
				Email = "arda@gmail.com",
				Password = 2222,
				PhoneNumber = 123456
			}
           );
        }
    }
}
