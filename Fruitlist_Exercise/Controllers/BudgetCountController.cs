using DAL_FruitList_exercise;
using DAL_FruitList_exercise.Entity.Tables;
using DAL_FruitList_exercise.Models.Interface;
using DAL_FruitList_exercise.Models.Repositiory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fruitlist_Exercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetCountController : ControllerBase
    {
        protected readonly DbClass context;
        IBudgetCount budgetCount;
        public BudgetCountController(DbClass repoContect)
        {
            context = repoContect;
            budgetCount = new BudgetCountRepository(context);
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<BudgetCount> data = budgetCount.budgetAndFruitCount();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
