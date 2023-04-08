using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        //The Id the EF would treat it as primary key or else you can add [Key] above it 
        //If you other name like "TheId"
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}