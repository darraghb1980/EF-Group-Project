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

        public contributionsDAL GetAmount(float amounts)
        {
            // code to get amount from database goes here

            // attempted code
            var amounts = db.ElectionContributions.ToList(Amount);
            return amounts;
        }


    }
}