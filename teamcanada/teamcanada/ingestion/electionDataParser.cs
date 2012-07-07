using System;
using System.Collections.Generic;
using System.IO;

namespace teamcanada.ingestion
{
    public interface electionDataParser
    {
        List<Election> parseElection();
        
        /*
         List<Candidate> parseCandidate();
        List<Contribution> parseContribution();
        List<Contributor> parseContributor();
        List<Ward> parseWard();

         */

        void setStreamSource(StreamReader reader); // streamreader will be defined in the business logic
        Boolean supportsType(String format);
    }
}
