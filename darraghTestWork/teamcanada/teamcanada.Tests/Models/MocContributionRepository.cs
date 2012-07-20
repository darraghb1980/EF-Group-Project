using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using teamcanada.Models;

namespace teamcanada.Tests.Models
{
    class InMemoryContributionRepository : teamcanada.Models.IContributionRepository
    {
        private List<Contributions> _db = new List<Contributions>();

        public Exception ExceptionToThrow { get; set; }
        //public List<Contribution> Items { get; set; }

        public void SaveChanges(Contributions ContributionToUpdate)
        {

            foreach (Contributions Contribution in _db)
            {
                if (Contribution.id == ContributionToUpdate.id)
                {
                    _db.Remove(Contribution);
                    _db.Add(ContributionToUpdate);
                    break;
                }
            }
        }

        public void Add(Contributions ContributionToAdd)
        {
            _db.Add(ContributionToAdd);
        }

        public Contributions GetContributionByID(int id)
        {
            return _db.FirstOrDefault(d => d.id == id);
        }

        public void CreateNewContribution(Contributions ContributionToCreate)
        {
            if (ExceptionToThrow != null)
                throw ExceptionToThrow;

            _db.Add(ContributionToCreate);
            // return ContributionToCreate;
        }

        public int SaveChanges()
        {
            return 1;
        }

        public IEnumerable<Contributions> GetAllContributions()
        {
            return _db.ToList();
        }


        public void DeleteContribution(int id)
        {
            _db.Remove(GetContributionByID(id));
        }

    }
}
