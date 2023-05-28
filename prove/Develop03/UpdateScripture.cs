using System.Text.RegularExpressions;

class Update
{
    private static List<string> _result = new List<string>();
    public string UpdateScripture(string rawScript)
    {
        string reference = rawScript.Split(".")[0].Trim();
        string scriptText = rawScript.Split(".")[1].Trim();

        //MODIFY SCRIPTTEXT TO REMOVE RANDOM WORDS AND CONTINUE
        //Convert script text to list separated by commas
        _result = scriptText.Split(" ").ToList();
        int isEmpty = Regex.Matches(scriptText,@"[a-zA-Z]").Count;
        int i = -1;
        
        if (isEmpty >= 1)
        {
            //For every word in the list of text
            foreach (string word in _result.ToList())
            {
                i += 1;
                //Generate a random number 1-5
                Random rand = new Random();
                int rndnum = rand.Next(0,5);

                if (rndnum == 1 || rndnum == 3)
                {
                    var res=new Regex("\\S").Replace(word,"_");
                    _result[i] = res;
                }
            }
        }
        else if (isEmpty == 0)
        {
            return "COMPLETED";
        }
        string resultString = string.Join(" ",_result);

                
        string updatedScripture = $"{reference}. {resultString}";

        return updatedScripture; 
    }
}