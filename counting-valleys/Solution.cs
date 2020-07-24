class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int level = 0, passed = 0;
        for ( int i = 0; i < s.Length ; i++ ){
            if( s[i] == 'D' ){
                if(level == 0)
                    passed++;
                level--;
            }
            else
                level++;    
        }
        return passed;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
