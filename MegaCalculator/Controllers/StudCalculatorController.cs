using System.Threading.Tasks;
using MegaCalculator.App_Data.StudCalculator.Data;
using MegaCalculator.App_Data.StudCalculator.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaCalculator.Controllers
{
    public class StudCalculatorController : Controller
    {
        private readonly DbWorkGost33259 _dbWorkGost33259;
        private DbAllGosts _dbAllGosts;

        public StudCalculatorController(ApplicationContext db)
        {
            _dbAllGosts = new DbAllGosts(db);
            _dbWorkGost33259 = new DbWorkGost33259(db);
        }

        [Route("Калькулятор шпилек")]
        public async Task<IActionResult> StudCalculatorView()
        {
            ViewBag.GOST = new SelectList(await _dbAllGosts.AllGostFromBase());
            ViewBag.ExecutionType33259 = new SelectList(await _dbWorkGost33259.ExecutionType33259());
            ViewBag.ExecutionPn33259 = new SelectList(await _dbWorkGost33259.ExecutionPn33259());
            ViewBag.ExecGost33259 = new SelectList(await _dbWorkGost33259.ExecGost33259());
            ViewBag.ExecutionDn33259 = new SelectList(await _dbWorkGost33259.ExecutionDn33259());
            return View("StudCalculatorView");
        }
    }
}
