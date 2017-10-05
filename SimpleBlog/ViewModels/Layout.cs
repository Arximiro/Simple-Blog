using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModels
{
    public class SidebarTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int PostCount { get; set; }

        public SidebarTag(int id, string name, string slug, int postCount)
        {
            Id = id;
            Name = name;
            Slug = slug;
            PostCount = postCount;
        }
    }

    public class LayoutSidebar
    {
        public bool IsLoggedIn { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; }
        public IEnumerable<SidebarTag> Tags { get; set; }
    }
}