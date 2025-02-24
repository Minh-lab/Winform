ex: str =  5*2+3
[string, int] map
* = 0
/ = 0
+ = 0
- = 0
for(int i = 0; i < str.length; i++){
    map[str[i]]++;
}
=> t = 2
for(int i = 0; i < t; i++){
    str.findIndex("*") -> check*
    if(check* != -1)
        str.replace(str[i-1] + str[i] + str[i+1], str[i-1] * str[i + 1])
    str.findIndex("+") -> check+
    if(check/ != -1)
        str.replace(str[i-1] + str[i] + str[i+1], str[i-1] / str[i + 1])
    str.findIndex("*") -> check*
    if(check+!= -1)
        str.replace(str[i-1] + str[i] + str[i+1], str[i-1] = str[i + 1])
    str.findIndex("*") -> check*
    if(check- != -1)
        str.replace(str[i-1] + str[i] + str[i+1], str[i-1] - str[i + 1])                    

}
return int.Parse(str);

1+1+1+1
0| 2 + 1 + 1
1| 3 + 1
2| 4
return 4

2*3 + 6/2
0|6 + 6/2
1|6 + 3
2|9







using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string str = "5*2+3";
            Dictionary<string,int> map = new Dictionary<string,int>();
            map.Add("*", 0);
            map.Add("/", 0);
            map.Add("+", 0);
            map.Add("-", 0);
            for(int i = 0; i < str.length; i++)
                map[str[i]]++;
		}
	}
}