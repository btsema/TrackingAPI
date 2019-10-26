using System.Collections.Generic;
using Tracking.Data.Models;

namespace Tracking.Data.DataLayer
{
    public interface ICompanyDataProvider
    {
        /// <summary>
        /// Add new company
        /// </summary>
        /// <param name="company">Company object</param>
        /// returns added Company object
        Company Add(Company company);

        /// <summary>
        /// Get all companies ordere by company name
        /// </summary>
        /// <returns>List of companies</returns>
        List<Company> GetAllCompanies();
    }
}