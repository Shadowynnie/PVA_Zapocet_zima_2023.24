using Zapocet.Data;
using Zapocet.Models;

namespace Zapocet.Logic
{
    public class CreditLogic
    {
        private readonly AppDbContext _dbContext;

        public CreditLogic(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCredit(int value, bool success)
        {
            var credit = new Credit
            {
                Created = DateTime.Now,
                Value = value,
                Success = success
            };

            _dbContext.Credits.Add(credit);
            _dbContext.SaveChanges();
        }
    }

}
