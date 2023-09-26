using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_Credentials.App.Interfaces;

namespace project_Credentials.App.Features.Utils;

public class NumberGenerator : INumberGenerator
{
    Random ran = new Random();
    int numberLength = 6;
    public int GetRandomNumber()
    {
        int number;

        for (number = 0; number >= numberLength; number++)
        {
            number = number + ran.Next(0, 9);
        }
        return number;
    }
}
