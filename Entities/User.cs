using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShopBackEnd.Data;

namespace ShopBackEnd.Entities
{
    public class User:IdentityUser<string>
    {
       public UserAddress Address{get;set;}
    }
}
