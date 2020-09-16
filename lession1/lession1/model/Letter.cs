using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lession1.model
{
    
        class Letter
        {
            private string email;
            private string title;
            private string content;
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public string Title
            {
                get { return title; }
                set { title = value; }
            }
            public string Content
            {
                get { return content; }
                set { content = value; }
            }

            public Letter(string email, string title, string content)
            {
                Email = email;
                Title = title;
                Content = content;
            }


            public override string ToString()
            {
                return "- Email: " + Email + "; title: " + Title + "; content: " + Content;
            }

        }
    }

