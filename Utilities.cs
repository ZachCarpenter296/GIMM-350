using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static string ProcessText(string textIn)
    {
            try
            {
                float test = float.Parse(textIn);
                textIn = "Float";

            }
            catch
            {
                textIn = "String";
            }
        return textIn;
    }
}


//return the word "string" if the user enters a string
//return the word "number" if the user enters a number (including 1.2 decimal)

