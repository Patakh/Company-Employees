﻿using Repository.Repositories;

namespace Repository;
public interface IRepositoryManager
{
    ICompanyRepository Company { get; }
    IEmployeeRepository Employee { get; }
    Task SaveAsync();
}