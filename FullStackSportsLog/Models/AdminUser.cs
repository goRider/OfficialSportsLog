using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackSportsLog.Models
{
    public class AdminUser
    {
        [Key]
        [Column(name: "user_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Column(name: "first_name", TypeName = "varchar(70)")]
        public string FirstName { get; set; }
        [Column(name: "middle_name", TypeName = "varchar(70)")]
        public string MiddleName { get; set; }
        [Column(name: "last_name", TypeName = "varchar(70)")]
        public string LastName { get; set; }
        [Column("created_at", TypeName = "datetime2")]
        public DateTime? CreatedAt { get; set; }
        [Column(name: "is_active")]
        public bool IsActive { get; set; }
        [Column(name: "username", TypeName = "varchar(50)")]
        public string Username { get; set; }
        [Column(name: "user_password", TypeName = "varchar(60)")]
        public string UserPassword { get; set; }
        [Column(name: "user_email", TypeName = "varchar(100)")]
        public string UserEmail { get; set; }
        [Column("login_time", TypeName = "datetime2")]
        public DateTime? LoginTime { get; set; }
        [Column("logout_time", TypeName = "datetime2")]
        public DateTime? LogoutTime { get; set; }
    }
}
