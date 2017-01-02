﻿namespace Angular.Server.Data.Repositories.Abstractions
{
    using Angular.Server.Models.DomainModels;

    public interface IPersonRepository : IAuditableEntityRepository<Person>
    {
    }
}
