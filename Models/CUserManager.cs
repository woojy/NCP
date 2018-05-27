﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace metoo.Models
{
    public class CUserManager
    {
        MetooDataContext theUserContext;


        public CUserManager()
        {
            theUserContext = new MetooDataContext();
        }
        public List<CUser> GetUsers()
        {
            IQueryable<registration> tmpR
                = theUserContext.registration.OrderByDescending(x => x.id);

            List<registration> tmpL = tmpR.ToList<registration>();
            List<CUser> resUsers = new List<CUser>();
            foreach (registration iter in tmpL)
            {
                CUser tmpUser = new CUser();
                tmpUser.name = iter.name;
                tmpUser.major = iter.major;
                tmpUser.promise = iter.promise;
                resUsers.Add(tmpUser);
            }
            return resUsers;
        }
        public int AddUser(ref CUser aUser)
        {
            registration tmpUser = new registration();
            tmpUser.name = aUser.name;
            tmpUser.major = aUser.major;
            tmpUser.promise = aUser.promise;

            theUserContext.registration.InsertOnSubmit(tmpUser);
            theUserContext.SubmitChanges();

            return 1;
        }
        public int CheckUser(string aID, string aPW)
        {
            //foreach(CUser iter in theUsers)
            //{
            //    if(iter.theID == aID && iter.thePW == aPW)
            //    {
            //        return 1;
            //    }
            //}
            return 0;
        }
    }
}