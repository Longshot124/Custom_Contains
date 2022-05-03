using System;
using System.Collections.Generic;
using System.Text;

namespace Contains_method_by_me
{
   public static class Extensions
    {

        public static bool CustomContains(this string word,string part)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==part[0])
                {

                    for (int j = 0; j < part.Length; j++)
                    {
                        if (part[j] !=word[i+j])
                        {
                            break;
                        }
                        if (j==part.Length-1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
      
    }
}
