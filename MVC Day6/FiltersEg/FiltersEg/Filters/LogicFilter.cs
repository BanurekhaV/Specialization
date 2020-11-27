using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersEg.Filters
{
    public class LogicFilter : ActionFilterAttribute , IExceptionFilter
    { 
        public void OnException(ExceptionContext filtercontext)
        {
            filtercontext.Controller.ViewBag.Message1 = "CustomException: Message from OnException";
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //base.OnActionExecuting(filterContext);
            filterContext.Controller.ViewBag.Message2 = "CustomException: Message from OnAction Executing Method";
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            filterContext.Controller.ViewBag.Message3 = "CustomException: Message from OnAction Executed Method";
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //base.OnResultExecuting(filterContext);
            filterContext.Controller.ViewBag.Message4 = "CustomException: Message from OnResult Executing Method";
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            filterContext.Controller.ViewBag.Message5 = "CustomException: Message from OnResult Executed Method";
        }
    }
    }
  

    