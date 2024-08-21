public class Solution {
    public string IntToRoman(int num) {
        string roman = "";

        int r1 = 0;
        int r10 = 0;
        int r100 = 0;
        int r1000 = 0;

        r1 = num % 10;
        num /= 10;
        r10 = (num % 10);
        num /= 10;
        r100 = (num % 10);
        num /= 10;
        r1000 = (num % 10);

        if (r1000 != 0)
        {
            for (int i = 0; i < r1000; i++)
            {
                roman += "M";
            }
        }

        if (r100 != 0)
        {
            if (r100 == 5)
            {
                roman += "D";
            }
            else if (r100 < 5)
            {
                if (r100 == 4)
                {
                    roman += "CD";
                }
                else
                {
                    for (int i = 0; i < r100; i++)
                    {
                        roman += "C";
                    }
                }
            }
            else
            {
                if (r100 == 9)
                {
                    roman += "CM";
                }
                else
                {
                    r100 -= 5;
                    roman += "D";
                    for (int i = 0; i < r100; i++)
                    {
                        roman += "C";
                    }
                }
            }
        }
        if (r10 != 0)
        {
            if (r10 == 5)
            {
                roman += "L";
            }
            else if (r10 < 5)
            {
                if (r10 == 4)
                {
                    roman += "XL";
                }
                else
                {
                    for (int i = 0; i < r10; i++)
                    {
                        roman += "X";
                    }
                }
            }
            else
            {
                if (r10 == 9)
                {
                    roman += "XC";
                }
                else
                {
                    r10 -= 5;
                    roman += "L";
                    for (int i = 0; i < r10; i++)
                    {
                        roman += "X";
                    }
                }
            }
        }
        if (r1 != 0)
        {
            if (r1 == 5)
            {
                roman += "V";
            }
            else if (r1 < 5)
            {
                if (r1 == 4)
                {
                    roman += "IV";
                }
                else
                {
                    for (int i = 0; i < r1; i++)
                    {
                        roman += "I";
                    }
                }
            }
            else
            {
                if (r1 == 9)
                {
                    roman += "IX";
                }
                else 
                {
                    r1 -= 5;
                    roman += "V";
                    for (int i = 0; i < r1; i++)
                    {
                        roman += "I";
                    }
                }
            }
        }
        return roman;
    }
}