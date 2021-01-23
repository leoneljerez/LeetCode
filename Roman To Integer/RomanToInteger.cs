public class Solution {
    
    //Dictionary that has all possible solutions
    Dictionary<string, int> romanNums = new Dictionary<string, int>()
    {
        {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50},
        {"C", 100}, {"D", 500}, {"M", 1000}, {"IV", 4},
        {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400},
        {"CM", 900}
    };
    
    public int RomanToInt(string s) {
        
        char[] values = s.ToCharArray();
        int total = 0;
        
        for (int i = 0; i < values.Length; i++)
        {                                      
            if ( (i < values.Length-1) && (romanNums.ContainsKey(Char.ToString(values[i]) + Char.ToString(values[i+1])) ) ) 
            {                  
                int numData = romanNums[Char.ToString(values[i]) + Char.ToString(values[i+1])];
                total += numData; 
                i++;                
            }             
            else
                total += romanNums[Char.ToString(values[i])];                
        }
        
        return total;
    }
}