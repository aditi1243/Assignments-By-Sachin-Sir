using System;
using System.Collections.Generic;
namespace DictionaryPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            foreach (KeyValuePair<string, string> i in cities)
            {
                Console.WriteLine(i.Key + ":" + i.Value + "\n");

            }
        }
    }
}
