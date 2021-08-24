using Microsoft.AspNetCore.Identity;
using MyCTAPI.Core.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCTAPI.Core.Entities
{
    public class CTUserToken : IdentityUserToken<int>, IEntity
    {
        public int Id { get; set; }
    }
}
