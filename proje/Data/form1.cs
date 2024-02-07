using System;
using Microsoft.EntityFrameworkCore;

namespace proje.Data



{
    [Keyless]
    public class Form1
	{
		public required string Ad { get; set; }
        public required string Soyad { get; set; }
		public int Yas { get; set; }

    }
}

