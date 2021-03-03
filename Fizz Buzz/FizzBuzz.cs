public class Solution {
    public IList<string> FizzBuzz(int n) {
        
        //IList needs a list to be returned
        List<string> listResults = new List<string>();
        
        //start from 1 and goes to N
        for (int i = 1; i <= n; i++)
        {
            if ( (i % 3 == 0) && (i % 5 == 0) ) //mod to find multiples of 3 and 5
                listResults.Add("FizzBuzz");
            else if ((i % 3) == 0)              //mod to find multiples of 3
                listResults.Add("Fizz");
            else if ((i % 5) == 0)              //mod to find multiples of 5
                listResults.Add("Buzz");
            else                                //else just give the normal number
                listResults.Add(i.ToString());
                
        }
        
        return listResults;
    }
}