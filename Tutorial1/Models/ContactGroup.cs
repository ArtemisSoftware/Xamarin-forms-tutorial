using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial1.Models
{
    class ContactGroup : List<Contact>
    {

        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }

    }
}
