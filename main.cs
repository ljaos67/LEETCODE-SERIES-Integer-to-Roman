public class Solution {
    public string IntToRoman(int num) 
    {
        string s = "";
        while(num > 0)
        {
            if(num >= 1000)
            {
                s += "M";
                num -= 1000;
            }
            else if(num >= 500)
            {
                if(num >= 900 && num <= 999)
                {
                    s += "CM";
                    num -= 900;                    
                }
                else
                {
                    s += "D";
                    num -= 500;
                }

            }
            else if(num >= 100)
            {
                if(num >= 400 && num <= 499)
                {
                    s += "CD";
                    num -= 400;                    
                }
                else
                {
                    s += "C";
                    num -= 100;
                }
            }
            else if(num >= 50)
            {
                if(num >= 90 && num <= 99)
                {
                    s += "XC";
                    num -= 90;                    
                }
                else
                {
                    s += "L";
                    num -= 50;
                }

            }
            else if(num >= 10)
            {
                if(num >= 40 && num <= 49)
                {
                    s += "XL";
                    num -= 40;                    
                }
                else
                {
                    s += "X";
                    num -= 10;
                }
            }
            else if(num >= 5)
            {
                if(num == 9)
                {
                    s += "IX";
                    num -= 9;                    
                }
                else
                {
                    s += "V";
                    num -= 5;
                }
            }
            else
            {
                if(num == 4)
                {
                    s += "IV";
                    num -= 4;                    
                }
                else
                {
                    s += "I";
                    num -= 1;
                }
            }
        }
        return s;
    }
}
