﻿using Explorer.BuildingBlocks.Core.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.Core.Domain.RepositoryInterfaces
{
    public interface ITourProgressRepository : ICrudRepository<TourProgress>
    {
        TourProgress GetActiveByUser(long userId);
        public TourProgress GetByUser(long userId);
    }
}
