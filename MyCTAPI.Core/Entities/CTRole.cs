using Microsoft.AspNetCore.Identity;
using MyCTAPI.Core.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCTAPI.Core.Entities
{
    public class CTRole : IdentityRole<int>, IEntity
    {

    }
}
