using System.Collections.Generic;
using UnityEngine;

internal class NameGenerator
{
    internal static string generateName()
    {
        return generateFirstName() + " " + generateLastName();
    }

    internal static string generateFirstName()
    {
        List<string> names = new List<string> {
            "Charlie",//m
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
            "Arnold",
            "Lauretta",//f
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
            "Flossie"};
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