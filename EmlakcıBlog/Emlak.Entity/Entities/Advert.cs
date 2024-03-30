using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Entity.Entities
{
	public class Advert
	{
		[Key]
        public int AdvertId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Room { get; set; }
        public int Price { get; set; }
        
    


    }
}
