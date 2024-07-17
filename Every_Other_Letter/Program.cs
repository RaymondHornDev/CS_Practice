using System;

class Program{
    static void Main(string[] args) {
        string nString = "hello";
        Console.WriteLine(CapEOL(nString, 0));
    }

    static string CapEOL(string _string, int val){
        string ret_string = "";
        if(val < _string.Length){
            if((val + 1) % 2 == 0){
                ret_string += _string.Substring(val, 1).ToUpper();
            }
            else{
                ret_string += _string.Substring(val, 1).ToLower();
            }
            return ret_string += CapEOL(_string, val + 1);
        }
        return ret_string;
    }
}