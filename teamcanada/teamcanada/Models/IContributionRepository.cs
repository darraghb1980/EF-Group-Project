using System;
using System.Collections.Generic;

namespace teamcanada.Models
{
    public interface IContributionRepository
    {
        void CreateNewContribution(Contributions ContributionToCreate);
        void DeleteContribution(int id);
        Contributions GetContributionByID(int id);
        IEnumerable<Contributions> GetAllContributions();
        int SaveChanges();


       // object GetAllContributions();
    }
}
