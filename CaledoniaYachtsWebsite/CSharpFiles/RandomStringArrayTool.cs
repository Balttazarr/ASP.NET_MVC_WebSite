﻿using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Slow but reliable method for randomizing string array
/// </summary>
static class RandomStringArrayTool
{
    /// <summary>
    /// Stores the current random number
    /// </summary>
    static Random _random = new Random();

    /// <summary>
    /// Return randomized version of the string array
    /// </summary>
    public static string[] RandomizeStrings(string[] arr)
    {
        List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
        // Add all strings from array
        // Add new random int each time
        foreach (string s in arr)
        {
            list.Add(new KeyValuePair<int, string>(_random.Next(), s));
        }
        // Sort the list by the random number
        var sorted = from item in list
                     orderby item.Key
                     select item;
        // Allocate new string array
        string[] result = new string[arr.Length];
        // Copy values to array
        int index = 0;
        foreach (KeyValuePair<int, string> pair in sorted)
        {
            result[index] = pair.Value;
            index++;
        }
        // Return copied array
        return result;
    }
}