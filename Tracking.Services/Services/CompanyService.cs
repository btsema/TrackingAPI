using System;
using System.Collections.Generic;
using System.Text;
using Tracking.Data.DataLayer;
using Tracking.Data.Models;

namespace Tracking.Services.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyDataProvider _company;
        public CompanyService(ICompanyDataProvider company)
        {
            _company = company;
        }

        /// <summary>
        /// Add new Company
        /// </summary>
        /// <param name="newCompany">Company object</param>
        /// <returns>Added company object</returns>
        public Company Add(Company newCompany)
        {
            return _company.Add(newCompany);
        }

        /// <summary>
        /// Get all companies ordere by company name
        /// </summary>
        /// <returns>List of companies</returns>
        public List<Company> GetAllCompanies()
        {
            return _company.GetAllCompanies();
        }
    }
}
