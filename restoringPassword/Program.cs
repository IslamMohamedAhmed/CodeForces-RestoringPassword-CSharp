using static System.Console;
using static System.Convert;
using static System.Math;


string mainStr, compStr,res="";
string[] str = new string[11];
int indicator = 0; 


mainStr = ReadLine();


for(int i = 0; i < 10; i++)
{
    str[i] = ReadLine();
}

for(int j = 0; j < 8; j++)
{

    compStr = mainStr.Substring(j * 10, 10);
    for (int k = 0; k < 10; k++)
    {
        if (str[k] == compStr)
        {
            res += k;
            break;
        }
    }
    indicator += 10;
}

WriteLine(res);