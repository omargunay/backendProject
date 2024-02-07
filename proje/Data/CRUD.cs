using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proje.Data

{
	public class CRUD
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { set; get; }

        public required string LastName { set; get; }

        public required string FirstName { set; get; }
        
        public required string Address { set; get; }
        
        public required string Designation { set; get; }
        
        public required string StaffNo { set; get; }
    }
}

