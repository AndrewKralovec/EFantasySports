using System.IO;
using System;
using System.Text;
using System.Diagnostics;

class ContextManager {
    static void Test(string[] args) {
        if (args.Length == 0) {
        	    Usage(); 
        	    return ; 
    	}
    	try{
        	string s = StringJoin(args); 
            string[] options  = s.Split(' ');
            switch (options[0]){
        	    case "-c":
	                Process.Start("dotnet ef migrations add InitialCreate -c "+options[1]);
            		break;
        	    case "-u":
	                Process.Start("dotnet ef database update -c "+options[1]);
            		break;
            }
    	}catch {
            Usage(); 
    	}
    }
    static string StringJoin(string[] array) {
    	string result = string.Join(" ", array);
    	return result;
    }
    static void Usage(){
        Console.WriteLine("Usage: ContextManager.exe [-c|-u] <Context>"); 
    }
}
