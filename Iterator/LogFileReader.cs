using System;
using System.Reflection;

public static class LogFileReader
{
    public static IEnumerable<string> GetLogEntries(string filePath)
    {
        using var file = new StreamReader(filePath);
        string line;
        while ((line = file.ReadLine()) != null)
        {
            yield return line;
        }
    }


    public static string SafeTrim(this string s) => (s ?? string.Empty).Trim();


    public static string GetStringBeforeTheNthSeparator(this string s, char separator, int n)
    {
        var trimString = s.SafeTrim();
        var arr = s.Split('-');

        if (n >= arr.Length)
        {
            return s;
        }

        var lastIndex = trimString.LastIndexOf(separator);

        if (n == arr.Length - 1)
        {
            lastIndex = trimString.LastIndexOf(separator);
            return lastIndex > 0 ? trimString[..lastIndex] : trimString;
        }

        return GetStringBeforeTheNthSeparator(trimString[..lastIndex], separator, n);
    }

    public static string GetStringBeforeTheNthSeparator1(this string s, char separator, int n)
    {
        var trimString = s.SafeTrim();
        var arr = s.Split('-');
        if (n >= arr.Length)
        {
            return s;
        }

        var lastIndex = trimString.LastIndexOf(separator);

        if (n == arr.Length - 1)
        {
            lastIndex = trimString.LastIndexOf(separator);
            return lastIndex > 0 ? trimString[..lastIndex] : trimString;
        }

        return GetStringBeforeTheNthSeparator(trimString[..lastIndex], separator, n);
    }

    public static string GetStringBeforeTheNthSeparator2(this string s, char separator, int n)
    {
        var trimString = s.SafeTrim();
        var arr = s.Split('-');

        var lastIndex = trimString.LastIndexOf(separator);

        while (n != arr.Length)
        {
            lastIndex = trimString.LastIndexOf(separator);
            var t = trimString[..lastIndex];
            trimString = t;
            arr = trimString[..lastIndex].Split('-');
        }

        return trimString[..lastIndex];
    }

    public static string GetStringBeforeTheNthSeparatorRecursive(this string s, char separator, int n)
    {
        return GetStringBeforeTheNthSeparatorRecursive(s, separator, n, 0, 0);
    }

    private static string GetStringBeforeTheNthSeparatorRecursive(string s, char separator, int n, int index, int count)
    {
        // Base case: if the current index reaches the end of the string or the desired count of separators is reached
        if (index >= s.Length || count == n)
        {
            // Return the substring from the start to the current index
            return s.Substring(0, index);
        }

        // If the current character is the separator, increment the count
        if (s[index] == separator)
        {
            count++;
        }

        // Continue recursively with the next character
        return GetStringBeforeTheNthSeparatorRecursive(s, separator, n, index + 1, count);
    }

}