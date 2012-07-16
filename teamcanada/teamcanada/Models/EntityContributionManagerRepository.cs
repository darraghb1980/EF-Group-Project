using System.Collections.Generic;
using System.Linq;

namespace teamcanada.Models
{
    public class EF_ContributionRepository : teamcanada.Models.IContributionRepository
    {

        private torontoDB db = new torontoDB();

        public Contributions GetContributionByID(int id)
        {
            return db.ElectionContributions.FirstOrDefault(d => d.id == id);
        }

        public IEnumerable<Contributions> GetAllContributions()
        {
            return db.ElectionContributions.ToList();
        }

        public void CreateNewContribution(Contributions ContributionsToCreate)
        {
            db.ElectionContributions.Add(ContributionsToCreate);
            db.SaveChanges();
            //   return ContributionToCreate;
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public void DeleteContribution(int id)
        {
            var conToDel = GetContributionByID(id);
            db.ElectionContributions.Remove(conToDel);
            db.SaveChanges();
        }

    }
}
