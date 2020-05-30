using Gymrat.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gymrat.Data.Repository.Core
{
    public class UnitOfWork: IUnitOfWork
    {
        private GymEntityContext _dbContext;
        private BaseRepository<Rat> _rats;

        public UnitOfWork(GymEntityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Rat> Rats
        {
            get
            {
                return _rats ??
                    (_rats = new BaseRepository<Rat>(_dbContext));
            }
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
