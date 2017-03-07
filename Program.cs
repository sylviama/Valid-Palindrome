using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str1="A man, a plan, a canal: Panama";
            string str2="race a car";
            string str3="2";
            
            Solution solu=new Solution();
            var result=solu.IsPalindrome(str2);
            
            
            Console.WriteLine(result);
        }
    }
    
    public class Solution {
        public bool IsPalindrome(string s) {
            char[] charArray=s.ToLower().ToCharArray();
            List<char> charList=new List<char>();
            
            for(var i=0;i<charArray.Length;i++)
            {
                if((charArray[i]<='z' && charArray[i]>='a') || (charArray[i]<='Z' && charArray[i]>='A') || (charArray[i]<='9' && charArray[i]>='0'))
                {
                    charList.Add(charArray[i]);
                }
            }

            if(charList.Count==0)
            {
                return true;
            }else
            {
                for(var i=0;i<charList.Count/2+1;i++)
                {
                    if(charList[i]!=charList[charList.Count-i-1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
