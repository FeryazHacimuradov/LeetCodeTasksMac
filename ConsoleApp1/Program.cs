using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static public string LongestCommonPrefix(string[] strs)
    {
        string result = "";

        if (strs == null || strs.Length == 0)
            return "";

        string pref = strs[0];

        for (int i = 0; i < pref.Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || pref[i] != strs[j][i])
                {
                    return result;
                }
            }
            result += pref[i];
        }
        return result;
    }

    static public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) {
                    return false; 
                }
                
                char top = stack.Pop();
                if ((c == ')' && top != '(') || 
                    (c == '}' && top != '{') || 
                    (c == ']' && top != '[')) {
                    return false; 
                }
            }
        }
        
        return stack.Count == 0; 
    }
    
    static public int SearchInsert(int[] nums, int target)
    {
        int output = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                output = i;
                break;
            }
            if (nums[i] < target)
            {
                output = i + 1;
            }
        }

        return output;
    }
        
    static void Main(string[] args)
    {
        Console.WriteLine(SearchInsert([1,3,5,6], 5));
        // string[] strs = { "flower", "flow", "flight" };
        // string[] strs1 = { "dog","racecar","car" };

        // Console.WriteLine(LongestCommonPrefix(strs1));
        
        // Console.WriteLine(IsValid("()"));
        // Console.WriteLine(IsValid("()[]{}"));
        // Console.WriteLine(IsValid("(]"));
    } 
}