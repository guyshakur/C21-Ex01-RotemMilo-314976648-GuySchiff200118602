using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    [Serializable]
    public sealed class DatingFeature
    {
        private static  DatingFeature s_DatingFeature = new DatingFeature();
        public static  Dictionary<User, FacebookObjectCollection<User>> s_UserMatches;
        private static readonly string r_FileName =  "Dating_Matches.txt";
        private static readonly object sr_CreationalLockContext = new object();

        private DatingFeature()
        {
        }
        public static string FileName
         {
            get
            {
                return r_FileName;
            }
         }

        public static List<User> FindMatches(User i_UserFindDate)
        {
            List<User> matchList = new List<User>();

            try
            {
                s_DatingFeature = FileUtils.LoadFile(r_FileName, s_DatingFeature) as DatingFeature;
                    if (!s_UserMatches.ContainsKey(i_UserFindDate))
                    {
                        s_UserMatches.Add(i_UserFindDate, new FacebookObjectCollection<User>());
                        FileUtils.SaveToFile(r_FileName, s_DatingFeature);
                    }
                    else
                    {
                        FacebookObjectCollection<User> listChoiceToDate = s_UserMatches[i_UserFindDate];
                        foreach (User friendOfUserFindDate in listChoiceToDate)
                        {
                            foreach (User friend in s_UserMatches[friendOfUserFindDate])
                            {
                                if (friend.Equals(i_UserFindDate))
                                {
                                    matchList.Add(friendOfUserFindDate);
                                }
                            }
                        }
                    }
                return matchList;
            }

            catch (Exception)
            {
                s_UserMatches = new Dictionary<User, FacebookObjectCollection<User>>();
                FileUtils.SaveToFile(r_FileName, s_DatingFeature);
                return matchList;
            }
        }

        public static void Match(User i_UserFindDate, User i_UserToDate)
        {
            lock (sr_CreationalLockContext)
            {
                if (s_UserMatches == null)
                {
                    s_UserMatches = new Dictionary<User, FacebookObjectCollection<User>>();
                }
                else
                {
                    s_DatingFeature = FileUtils.LoadFile(r_FileName, s_DatingFeature) as DatingFeature;
                }
                if (!s_UserMatches.ContainsKey(i_UserFindDate))
                {
                    s_UserMatches.Add(i_UserFindDate, new FacebookObjectCollection<User>());
                }
                if(s_UserMatches[i_UserFindDate].Contains(i_UserToDate)==false)
                {
                    s_UserMatches[i_UserFindDate].Add(i_UserToDate);
                }
                FileUtils.SaveToFile(r_FileName, s_DatingFeature);
            }
        }
    }
}
