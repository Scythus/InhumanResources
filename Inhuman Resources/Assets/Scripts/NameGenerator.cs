using System.Collections.Generic;
using UnityEngine;

internal class NameGenerator
{
    internal static string generateName(string gender)
    {
        return generateFirstName(gender) + " " + generateLastName();
    }

    internal static string generateFirstName(string gender)
    {
        List<string> names;
        if (gender == "Male")
        {
            names = new List<string> {
                "Charlie",
                "Andy",
                "Clayton",
                "James",
                "Buster",
                "Myron",
                "Turner",
                "Byron",
                "Fletcher",
                "Bertrand",
                "Erwin",
                "Mike",
                "Raleigh",
                "Napoleon",
                "Elton",
                "Rowland",
                "Cyril",
                "Douglas",
                "Arnold"
            };
        } else {
            names = new List<string> {
                "Lauretta",
                "Winnifred",
                "Sophronia",
                "Sofia",
                "Greta",
                "Leora",
                "Alfreda",
                "Corene",
                "Mercedes",
                "Margie",
                "Adelaide",
                "Zenobia",
                "Charlotte",
                "Hessie",
                "Rosalia",
                "Emeline",
                "Flossie"
            };
        }
        return names[Random.Range(0, names.Count)];
    }

    internal static string generateLastName()
    {
        List<string> names = new List<string> {
            "Hargood",
            "Day",
            "Carson",
            "Harrison",
            "Rutter",
            "Coghill",
            "Small",
            "Donaldson",
            "Robinson",
            "McDonald",
            "White",
            "Lamb",
            "Duffey",
            "Finnerty",
            "Barnett",
            "Stafford",
            "Woolahan",
            "Howlett",
            "Gray",
            "Manning",
            "Kirkham",
            "Burns",
            "Suthmeer",
            "Cook",
            "Pabst"
        };
        return names[Random.Range(0, names.Count)];
    }
}