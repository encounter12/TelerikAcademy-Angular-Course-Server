﻿namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class ElectricalDeviceConsumptionHistoryRepository : 
        GenericRepository<ElectricalDevicesConsumptionHistory>,
        IElectricalDeviceConsumptionHistoryRepository
    {
        public ElectricalDeviceConsumptionHistoryRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}