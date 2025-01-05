﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable enable

namespace CompanyEmployees.Repository.CompiledModels
{
    public partial class RepositoryContextModel
    {
        partial void Initialize()
        {
            var company = CompanyEntityType.Create(this);
            var employee = EmployeeEntityType.Create(this);

            EmployeeEntityType.CreateForeignKey1(employee, company);

            CompanyEntityType.CreateAnnotations(company);
            EmployeeEntityType.CreateAnnotations(employee);

            AddAnnotation("ProductVersion", "6.0.0");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
