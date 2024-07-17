using System;

class Program{
    static void Main(string[] args) {
        string locHtml = "<Div new line DIV>";

        Console.WriteLine(AutoComplete(locHtml, 0));

    }

    static string AutoComplete(string html, int val){
        string retString = "";
        if(val < html.Length){
            if(html.Substring(val, 1) == "<" && html.Substring(val + 4, 1) != ">"){
                if(html.Substring(val + 1, 1).ToLower() == "d" && html.Substring(val + 3, 1).ToLower() == "v"){
                    retString += "<div> ";
                    val += 4;
                }
            }
            else if (html.Substring(val, 1) != "<" && html.Substring(val + 4, 1) == ">"){
                if (html.Substring(val + 1, 1).ToLower() == "d" && html.Substring(val + 3, 1).ToLower() == "v")
                {
                    retString += " <div>";
                    val += 4;
                }
            }
            else{
                retString += html.Substring(val, 1);
            }
            return retString + AutoComplete(html, val + 1);
        }
        return retString;
    }
}