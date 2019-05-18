using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace deneme
{
    [Table("people")]
    public class People
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Unique]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

