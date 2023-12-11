using DAL_FruitList_exercise.Entity.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_FruitList_exercise.Models.Interface
{
    public interface IBudgetCount
    {
        public List<BudgetCount> budgetAndFruitCount();
    }
}
