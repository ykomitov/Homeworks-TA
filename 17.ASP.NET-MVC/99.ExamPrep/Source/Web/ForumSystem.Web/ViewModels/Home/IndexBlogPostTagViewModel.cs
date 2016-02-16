﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForumSystem.Data.Models;
using ForumSystem.Web.Infrastructure.Mapping;

namespace ForumSystem.Web.ViewModels.Home
{
    public class IndexBlogPostTagViewModel :IMapFrom<Tag>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}