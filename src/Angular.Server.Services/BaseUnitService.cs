﻿using System;
using System.Linq;

using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;

namespace Angular.Server.Services
{
    public class BaseUnitService : IBaseUnitService
    {
        private readonly IBaseUnitRepository baseUnitRepository;

        public BaseUnitService(IBaseUnitRepository baseUnitRepository)
        {
            this.baseUnitRepository = baseUnitRepository;
        }

        public IQueryable<BaseUnit> All()
        {
            return this.baseUnitRepository.All();
        }

        public BaseUnit GetById(int id)
        {
            return this.baseUnitRepository.GetById(id);
        }

        public void Add(BaseUnit baseUnit)
        {
            this.baseUnitRepository.Add(baseUnit);
            this.baseUnitRepository.SaveChanges();
        }

        public void Update(BaseUnit baseUnit)
        {
            this.baseUnitRepository.Update(baseUnit);
            this.baseUnitRepository.SaveChanges();
        }

        public void Delete(BaseUnit baseUnit)
        {
            this.baseUnitRepository.Delete(baseUnit);
            this.baseUnitRepository.SaveChanges();
        }

        public void HardDelete(BaseUnit baseUnit)
        {
            this.baseUnitRepository.HardDelete(baseUnit);
            this.baseUnitRepository.SaveChanges();
        }
    }
}
