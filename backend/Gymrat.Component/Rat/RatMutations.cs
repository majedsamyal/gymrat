﻿using Gymrat.Data.Repository.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gymrat.Component.Rat
{
    public class RatMutations : IRatMutations
    {
        private readonly IUnitOfWork _unitOfWork;
        public RatMutations(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<RatViewModel> SaveRat(RatViewModel ratViewModel)
        {
            var entity = new Data.Entity.Rat()
            {
                Id = Guid.NewGuid().ToString(),
                EmailId = ratViewModel.EmailId,
                FirstName = ratViewModel.FirstName,
                LastName = ratViewModel.LastName,
                IsActive = true,
                IsDeleted = false,
                CreatedDateTime = DateTime.UtcNow,
                UpdateDateTime = DateTime.UtcNow
            };

            await _unitOfWork.Rats.Insert(entity);
            ratViewModel.Id = entity.Id;
            return ratViewModel;
        }
    }
}
