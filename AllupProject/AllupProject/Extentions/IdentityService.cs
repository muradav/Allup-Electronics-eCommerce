using System;
using AllupProject.DAL;
using AllupProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AllupProject.Extentions
{
    public static class IdentityService
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        
        {
            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 8;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequireUppercase = true;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireDigit = true;

                opt.User.RequireUniqueEmail = true;
                opt.Lockout.MaxFailedAccessAttempts = 3;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opt.Lockout.AllowedForNewUsers = true;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


            return services;
        }
    }
}
