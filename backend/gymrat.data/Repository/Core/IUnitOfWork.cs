using Gymrat.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Data.Repository.Core
{
   public interface IUnitOfWork
    {
        IRepository<Rat> Rats { get; }
        void Commit();
    }
}
