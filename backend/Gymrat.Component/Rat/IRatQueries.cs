using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gymrat.Component.Rat
{
   public interface IRatQueries
    {
        Task<IList<RatViewModel>> GetRats();
            
    }
}
