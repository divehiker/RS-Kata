using System.Web.Mvc;
using RS_Kata.DAL;

namespace RS_Kata.Controllers
{
    public class BaseController : Controller
    {
		protected Repository Db { get; set; }

		public BaseController()
		{
			Db = new Repository();
		}
	}
}
