using Gymrat.Data.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymrat.Component.Rat
{
    public class RatQueries : IRatQueries
    {
        private readonly IUnitOfWork _unitOfWork;
        public RatQueries(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<RatViewModel>> GetRats()
        {
            var result = await _unitOfWork.Rats.Get(i => !i.IsDeleted);
            var lst = new List<RatViewModel>() { new RatViewModel() { Id = "1223", FirstName = "Majed" }, new RatViewModel() { Id = "456", FirstName = "Arifa" } };         
            return lst;
        }
    }
}
