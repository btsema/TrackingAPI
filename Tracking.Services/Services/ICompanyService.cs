using System.Collections.Generic;
using Tracking.Data.Models;

namespace Tracking.Services.Services
{
    public interface ICompanyService
    {
        /// <summary>
        /// Add new Company
        /// </summary>
        /// <param name="newCompany">Company object</param>
        /// <returns>Added company object</returns>
        public Company Add(Company newCompany);

        /// <summary>
        /// Get all companies ordere by company name
        /// </summary>
        /// <returns>List of companies</returns>
        List<Company> GetAllCompanies();
    }
}