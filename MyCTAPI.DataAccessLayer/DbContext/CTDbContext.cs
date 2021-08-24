using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCTAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbContext
{
    public class CTDbContext : IdentityDbContext<CTUser, CTRole, int, CTUserClaim, CTUserRole, CTUserLogin, CTRoleClaim, CTUserToken>
    {
        public CTDbContext() : base()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CTUser>().ToTable("users");
            builder.Entity<CTUserClaim>().ToTable("user_claims");
            builder.Entity<CTUserLogin>().ToTable("user_logins");
            builder.Entity<CTUserToken>().ToTable("user_tokens");
            builder.Entity<CTUserRole>().ToTable("user_roles");
            builder.Entity<CTRole>().ToTable("roles");
            builder.Entity<CTRoleClaim>().ToTable("role_claims");
        }
    }
}
