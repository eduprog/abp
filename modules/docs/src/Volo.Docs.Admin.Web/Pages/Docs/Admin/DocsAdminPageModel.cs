﻿using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Volo.Docs.Admin.Pages.Docs.Admin
{
    public class DocsAdminPageModel : AbpPageModel
    {
        public DocsAdminPageModel()
        {
            ObjectMapperContext = typeof(DocsAdminWebModule);
        }
    }
}