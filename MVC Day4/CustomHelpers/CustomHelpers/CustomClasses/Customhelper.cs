using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomHelpers.CustomClasses
{
    public class Customhelper
    {
        public static IHtmlString LabelWithMark(string content)
        {
            string htmlstr = String.Format("<label><b><i><mark>{0}</mark></i></b></label>", content);
            return new HtmlString(htmlstr);
        }
    }
}