﻿using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tourism_Project.CustomTagHelper
{
    [HtmlTargetElement("td", Attributes = "user-roles")]
    public class UserRoleName : TagHelper
    {
        public UserManager<AppUser> UserManager { get; set; }

        public UserRoleName(UserManager<AppUser> userManager)
        {
            this.UserManager = userManager;
        }

        [HtmlAttributeName("user-roles")]
        public string UserId { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            AppUser user = await UserManager.FindByIdAsync(UserId);

            IList<string> roles = await UserManager.GetRolesAsync(user);

            string html = string.Empty;

            roles.ToList().ForEach(x =>
            {
                html += $"<span/>  {x}  </span>";
                //html += $"<span class='btn btn-primary'>  {x}  </span>";
            });

            output.Content.SetHtmlContent(html);
        }
    }
}
