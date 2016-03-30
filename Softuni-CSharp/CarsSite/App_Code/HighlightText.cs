﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Wraps matched strings in HTML span elements styled with a background-color
/// </summary>
/// <param name="text"></param>
/// <param name="keywords">Comma-separated list of strings to be highlighted</param>
/// <param name="cssClass">The Css color to apply</param>
/// <param name="fullMatch">false for returning all matches, true for whole word matches only</param>
/// <returns>string</returns>
/// Posted by: Mikesdotnetting

public static class HighlightText
{
    public static string HighlightKeyWords(this string text, string keywords, string cssClass, bool fullMatch)
    {
        if (text == String.Empty || keywords == String.Empty || cssClass == String.Empty)
            return text;
        var words = keywords.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        if (!fullMatch)
            return words.Select(word => word.Trim()).Aggregate(text,
                         (current, pattern) =>
                         Regex.Replace(current,
                                         pattern,
                                           string.Format("<span style=\"background-color:{0}\">{1}</span>",
                                           cssClass,
                                           "$0"),
                                           RegexOptions.IgnoreCase));
        return words.Select(word => "\\b" + word.Trim() + "\\b")
                    .Aggregate(text, (current, pattern) =>
                              Regex.Replace(current,
                              pattern,
                                string.Format("<span style=\"background-color:{0}\">{1}</span>",
                                cssClass,
                                "$0"),
                                RegexOptions.IgnoreCase));

    }
}