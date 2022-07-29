using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Allup.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(AppDbContext context,UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();

            User user = new User
            {
                Name = registerVM.Name,
                Surname = registerVM.Surname,
                Email = registerVM.Email,
                UserName = registerVM.Username,

            };

            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(user, Roles.Member.ToString());

            Basket basket = _context.Baskets
                .Include(b => b.BasketItems)
                .ThenInclude(b => b.Product)
                .ThenInclude(b => b.ProductImages)
                .FirstOrDefault(b => b.UserId == user.Id);

            if (basket == null)
            {
                basket = new Basket() { UserId = user.Id };
                _context.Add(basket);
                _context.SaveChanges();
            }


            
            return RedirectToAction("login");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM, string ReturnUrl)
        {

            User appUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Error occured");
                return View(loginVM);
            }



            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, true, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Error occured");
                return View(loginVM);
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Error occured");
                return View(loginVM);
            }

            var roles = await _userManager.GetRolesAsync(appUser);

            if (ReturnUrl != null)
            {
                foreach (var item in roles)
                {
                    if (item == "Admin")
                    {
                        return RedirectToAction("Index", "dashboard", new { area = "Admin" });
                    }
                    else
                    {
                        if (ReturnUrl == "register")
                        {
                            return RedirectToAction("index", "home");
                        }
                        return Redirect(ReturnUrl); ;
                    }
                }
            }


            return RedirectToAction("index", "home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }



        public async Task CreateRole()
        {
            foreach (var item in Enum.GetValues(typeof(Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(item.ToString()))
                {
                    await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
                }
            };
        }
    }
}
