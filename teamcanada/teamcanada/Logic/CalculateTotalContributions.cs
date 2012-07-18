using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.dal;
using teamcanada.Models;
using teamcanada.Models.ui;

// business logic to calculate total contributions 

namespace teamcanada.Logic
{
    public class CalculateTotalContributions
    {
        Contributions totalContrib = new Contributions();               // New object of type Contributions
        viewDAL dbSelectRecords = new viewDAL();                               // New object of type viewDAL
        
        float totalAmount = 0;
        int rowCount = dbSelectRecords.findRecordById                   // Attempting to use findRecordById methods in business logic
      
        for (int i = 0; int <= rowCount; i++)                      // for loop
        {
            totalAmount = totalAmount + totalContrib.amount;
        }

        return totalAmount;
    }
}