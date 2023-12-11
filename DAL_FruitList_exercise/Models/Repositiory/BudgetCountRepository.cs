using DAL_FruitList_exercise.Entity.Tables;
using DAL_FruitList_exercise.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_FruitList_exercise.Models.Repositiory
{
    public class BudgetCountRepository : IBudgetCount
    {
        public readonly DbClass context;
        public BudgetCountRepository(DbClass repoContext) 
        {
            context = repoContext;
            
        }
        public List<BudgetCount> budgetAndFruitCount()
        {
            List<BudgetCount> data = context.BudgetCount.ToList();
            if(data != null)
            {
                return data;
            }
            else
            {
                throw new Exception("Budget And FruitCount");
            }
        }
    }
}
