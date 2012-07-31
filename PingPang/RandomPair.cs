using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingPang
{
    /// <summary>
    /// 随机分组
    /// 列表
    /// 组数
    /// 
    /// </summary>
   public class RandomPair
    {
        public List<string> AList
        {
            get;
            set;
        }
       /// <summary>
       /// 每组人数
       /// </summary>
        private int groupMemberCount = 2;
      
        /// <summary>
        /// 每组的人数  当值为<=0时, groupcount才生效.
        /// </summary>
        public int GroupMemberCount { set { groupMemberCount = value; } }
        /// <summary>
        /// 总共的组数
        /// </summary>
       

        public RandomPair(List<string> list, int groupmembercount)
        {
            AList = list;
            this.groupMemberCount = groupmembercount;
        }
        public Dictionary<int, List<string>> DoPair()
        {
            try
            {
                AList.Sort(randomCompare);
            }


            catch { }
            int totalMembers=AList.Count;
            if(totalMembers%groupMemberCount!=0) throw new Exception("人数不能整除");
            int groupCount = totalMembers / groupMemberCount;
            

            Dictionary<int, List<string>> groups  = new Dictionary<int, List<string>>();
            for (int i = 0; i < totalMembers; i++)
            {
                var groupNo  = i % groupCount;
                if (!groups.ContainsKey(groupNo))
                {
                    List<string> groupMemers = new List<string>();
                    groups.Add(groupNo, groupMemers);
                }
                groups[groupNo].Add(AList[i]+"  ");
            }

            return groups ;
        }

        private int randomCompare(string s, string s2)
        {
            int code = Guid.NewGuid().GetHashCode();
            return code % 2 == 1 ? -1 : 1;
        }

    }
}