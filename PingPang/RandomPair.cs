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
    class RandomPair
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
        private int groupcount = 0;
        /// <summary>
        /// 每组的人数  当值为<=0时, groupcount才生效.
        /// </summary>
        public int GroupMemberCount { get { return groupMemberCount; } set { groupMemberCount = value; } }
        /// <summary>
        /// 总共的组数
        /// </summary>
        private int GroupCount { get { return groupcount; } set { groupcount = value; } }

        public RandomPair(List<string> list, int groupmembercount, int groupcount)
        { 
        
        }
        public List<string> DoPair()
        {
            AList.Sort(randomCompare);


            if (groupcount <= 0)
            { }

            return null;
        }

        private int randomCompare(string s, string s2)
        {
            int code = Guid.NewGuid().GetHashCode();
            return code % 2 == 1 ? -1 : 1;
        }

    }
}
