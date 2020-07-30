using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    Regex specialCharsReg = new Regex(@"[a-z A-Z\+\-\\\r\n\/\:\!\%\&\-\;\¾\<\>\`\@\#\{\}\(\)\^\*\[\]\|\?\'\'\""\,\$\~\.]");

    if(specialCharsReg.IsMatch(pin))
        return(false);
    else if(pin.Length == 4 || pin.Length == 6)
        return(true);
    else return false;
  }
}