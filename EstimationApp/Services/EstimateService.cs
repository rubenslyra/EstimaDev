using System;
using System.Collections.Generic;
using System.Linq;
using EstimationApp.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EstimationApp.Services
{
    public class EstimateService
    {
        private readonly AppDbContext _context;

        public EstimateService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Estimate> GetAllEstimates()
        {
            return _context.Estimates.ToList();
        }

        public Estimate GetEstimateById(int id)
        {
            return _context.Estimates.FirstOrDefault(e => e.Id == id);
        }

        public void CreateEstimate(Estimate estimate)
        {
            _context.Estimates.Add(estimate);
            _context.SaveChanges();
        }

        public void UpdateEstimate(Estimate estimate)
        {
            _context.Entry(estimate).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteEstimate(int id)
        {
            var estimate = _context.Estimates.FirstOrDefault(e => e.Id == id);
            if (estimate != null)
            {
                _context.Estimates.Remove(estimate);
                _context.SaveChanges();
            }
        }

        public double CalculateThreePointsEstimate(int estimateId)
        {
            var estimate = GetEstimateById(estimateId);
            if (estimate == null)
            {
                throw new ArgumentException("Estimate not found.");
            }

            double bestCase = estimate.BestCase;
            double mostLikelyCase = estimate.MostLikelyCase;
            double worstCase = estimate.WorstCase;

            double finalEstimate = (bestCase + 4 * mostLikelyCase + worstCase) / 6.0;

            return finalEstimate;
        }
    }
}
