using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            bool has3Zero =  nums.Where(n => n == 0).Count() >=3;
            List<List<int>> set = new List<List<int>>();
            Dictionary<int, List<int[]>> dic = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == 0 && nums[j] == 0 && !has3Zero)
                    {
                        continue;
                    }
                    if ((nums[i] < 0 && nums[j] < 0) || (nums[i] >= 0 && nums[j] >= 0))
                    {
                        if (!dic.ContainsKey(nums[i] + nums[j]))
                        {
                            List<int[]> tmp = new List<int[]>() { new int[] { nums[i], nums[j] } };
                            dic.Add(nums[i] + nums[j], tmp);
                        }
                        else
                        {
                            int[] tmp = new int[] { nums[i], nums[j] };
                            dic[nums[i] + nums[j]].Add(tmp);
                        }
                    }
                }
            }
            ////////above ok/////////
            Dictionary<string, string> alreadyShow = new Dictionary<string, string>();
            foreach (var n in nums)
            {
                if (dic.ContainsKey(-n))
                {
                    foreach (var s in dic[-n])
                    {
                        List<int> seq = new List<int>();
                        seq.Add(n);
                        seq.Add(s[0]);
                        seq.Add(s[1]);
                        seq = seq.OrderBy(a => a).ToList();
                        var seqStr = seq[0] + "," + seq[1] + "," + seq[2];
                        if (!alreadyShow.ContainsKey(seqStr))
                        {
                            set.Add(seq);
                            alreadyShow.Add(seqStr, seqStr);
                        }
                    }

                }
            }
            return set.ToList<IList<int>>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
