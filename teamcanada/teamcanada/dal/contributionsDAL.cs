using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using teamcanada.Models;
using teamcanada.Models.ui;

namespace teamcanada.dal
{
    public class contributionsDAL
    {
        protected torontoDB db = new torontoDB();

        // Version 1

        /*
        public contributionsDAL GetAmount()
        {
            // code to get amount from database goes here

            //List<Contributions> = null;

            var amounts = from t in db.ElectionContributions
                      where t.Amount > 500
                      select t;
            
            return amounts;
        }
        */

        // Version 2

        public contributionsDAL GetAmounts()
        {
            List<Contributions> contributions = null;

            contributions = from t in db.ElectionContributions
                            select t.Amount;
            return contributions;
        }

        // Version 3 - This would involve adding a stub to the model. Do we want to do it this...?

        public contributionsDAL GetAmounts()
        {
            selectAmounts = db.ElectionContributions.retrieveAmounts();

            foreach (Contributions selectAmount in selectAmounts)
            {
                selectAmount.Amount();

            }

            return selectAmounts;

        }

    }
}