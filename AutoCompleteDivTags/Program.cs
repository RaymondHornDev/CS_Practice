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
                UpdateValues(html, ref val, ref retString);
            }
            else if (html.Substring(val, 1) != "<" && html.Substring(val + 4, 1) == ">"){
                UpdateValues(html, ref val, ref retString);
            }
            else{
                retString += html.Substring(val, 1);
            }
            return retString + AutoComplete(html, val + 1);
        }
        return retString;
    }

    static void UpdateValues(string pHtml, ref int pVal, ref string pRetString){
        if (pHtml.Substring(pVal + 1, 1).ToLower() == "d" && pHtml.Substring(pVal + 3, 1).ToLower() == "v"){
            pRetString += " <div> ";
            pVal += 4;
        }
    }
}