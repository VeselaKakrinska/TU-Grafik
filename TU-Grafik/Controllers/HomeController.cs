using System.Web.Mvc;

namespace TU_Grafik.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /*
        public ActionResult ViewAllHalls()
        {
            List <Bonus> list = new TU_Grafik.DAL.GetAllBonussess();
            List<BonusViewModel> viewModel = new <BonusViewModel>();
            foreach (Bonus bonus in list)
            {
                viewModel.Add(new BonusViewModel);
            }
            return View(viewModel); } */
        
    }
}