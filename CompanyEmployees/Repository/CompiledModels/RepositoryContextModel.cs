﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository;

#pragma warning disable 219, 612, 618
#nullable enable

namespace CompanyEmployees.Repository.CompiledModels
{
    [DbContext(typeof(RepositoryContext))]
    public partial class RepositoryContextModel : RuntimeModel
    {
        static RepositoryContextModel()
        {
            var model = new RepositoryContextModel();
            model.Initialize();
            model.Customize();
            _instance = model;
        }

        private static RepositoryContextModel _instance;
        public static IModel Instance => _instance;

        partial void Initialize();

        partial void Customize();
    }
}
