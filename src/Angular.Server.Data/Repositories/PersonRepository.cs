﻿using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class PersonRepository : AuditableEntityRepository<Person>, IPersonRepository
    {
        public PersonRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
