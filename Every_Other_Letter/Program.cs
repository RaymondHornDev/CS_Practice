using System;

class Program{
    static void Main(string[] args) {
        string nString = "hello";
        Console.WriteLine(CapEOL(nString, 1));
    }

    static string CapEOL(string _string, int val){
        string ret_string = "";
        if(val - 1 < _string.Length){
            if(val % 2 == 0){
                return ret_string += _string.Substring(val - 1, 1).ToUpper() + CapEOL(_string, val + 1);
            }
            else{
                return ret_string += _string.Substring(val - 1, 1).ToLower() + CapEOL(_string, val + 1);
            }
        }
        return ret_string;
    }
}