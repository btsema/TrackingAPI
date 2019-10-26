using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tracking.Data.Database;
using Tracking.Data.Models;

namespace Tracking.Data.DataLayer
{
    public class CompanyDataProvider : ICompanyDataProvider
    {
        private readonly MainContext _context;

        public CompanyDataProvider(MainContext mainContext)
        {
            _context = mainContext;
        }

        public CompanyDataProvider()
        {
            DbContextOptions<MainContext> options = new DbContextOptions<MainContext>();
            _context = new MainContext(options);
        }

        /// <summary>
        /// Add new company
        /// </summary>
        /// <param name="company">Company object</param>
        /// returns added Company object
        public Company Add(Company company)
        {
            if (company == null) throw new ArgumentException("Missing input parameter " + nameof(company));

            company.CompanyId = Guid.NewGuid();

            _context.Company.Add(company);
            _context.SaveChanges();

            return company;
        }

        /// <summary>
        /// Get all companies ordere by company name
        /// </summary>
        /// <returns>List of companies</returns>
        public List<Company> GetAllCompanies()
        {
            return _context.Company.OrderBy(s => s.Name).ToList();
        }
    }
}