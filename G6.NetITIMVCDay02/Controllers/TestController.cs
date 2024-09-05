using Microsoft.AspNetCore.Mvc;

namespace G6.NetITIMVCDay02.Controllers
{
    public class TestController : Controller
    {
        // Action
        // => Can't be private
        // => Can't be static
        // => Can't be overload 

        // Action
        // Controller/Action
        // Test/ShowHello
        public string ShowHello1()
        {
            return "Hello from Test Controller Show Hello 1";
        }

        // No Overload XXXX
        //public string ShowHello(int x)
        //{
        //    return "Hello from Test Controller";
        //}

        public ContentResult ShowHello2()
        {
            // Declare Obj
            ContentResult result = new ContentResult();
            // Set Return
            result.Content = "Hello from Test Controller Show Hello 2";
            // return
            return result;
        }

        public ViewResult ShowHello3()
        {
            // Declare Obj
            ViewResult result = new ViewResult();
            // Set Reutrn
            result.ViewName = "Show";
            // return
            return result;
        }

        public ViewResult ShowHello4()
        {
            return View(); // return view with the same name with Action
        }

        public IActionResult ShowHello5()
        {
            return View(); // return view with the same name with Action
        }

        // Types of Return of Action
        // 1- Content "String"   => ContentResult
        // 2- View "HTML"        => ViewResult
        // 3- JavaScript         => JavaScriptResult
        // 4- Json               => JsonResult
        // 5- NotFound           => NotFoundResult
        // 6- File               => FileResult
    }
}
