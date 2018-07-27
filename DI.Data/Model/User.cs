using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DI.Domain.Model;

namespace DI.Data.Model
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        
        public DI.Domain.Model.User ToDomainUser()
        {
            return new DI.Domain.Model.User
            {
                id = this.id,
                name = this.name
            };
        }
    }
}
