using System;

namespace calculator;

class Program
{
    static void Main(string[] args){
        int inFirst,
            inSecond;
        Console.WriteLine("Welcome to my program!");

        Console.Write("First number: ");
        inFirst = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        inSecond = Convert.ToInt32(Console.ReadLine());
        var firstBinary = MyConvert.FromDecimalToAppendCode(7, inFirst);
        var secondBinary = MyConvert.FromDecimalToAppendCode(7, inSecond);

        Console.Write("First number(binary): ");
        Interpritator.interpritateBinary(firstBinary);
        Console.Write("Second number(binary): ");
        Interpritator.interpritateBinary(secondBinary);

        var resultBinary = Calculator.subtractAppendCode(firstBinary, secondBinary);
        Console.Write("Result binary(append code): ");
        Interpritator.interpritateBinary(resultBinary);
        resultBinary = MyConvert.flipIfNegative(resultBinary);
        Console.Write("Result binary(after invers if negative): ");
        Interpritator.interpritateBinary(resultBinary);

        var resultDecimal = MyConvert.FromAppendCodeToDecimal(7, resultBinary); 
        Console.WriteLine($"Ans: {resultDecimal}"); 
    }
}

static class Calculator{
    public static bool[] subtractAppendCode(bool[] from, bool[] sub){
       
        for(int i = 0; i < 7; i++ ){
            if(sub[i] == false){
                sub[i] = true;
                continue;
            }
            if(sub[i] == true){
                sub[i] = false;
                continue;
            }
        }
        bool[] one = {false, false, false, false, false, false, true};
        var result = new bool[7];
        var offset = false;
        
        for(int i = 6; i >= 0; i--){
            result[i] = binarySummator(from[i], sub[i], out offset, offset);
            if(i == 0 && offset == true){
                
                for(int j = 6; j >= 0; j--){
                    offset = false;
                    result[i] = binarySummator(from[i], one[i], out offset, offset);
                }
            }
        } 
        
        return result;
        
    }

    public static bool binarySummator(bool first, bool second, out bool outOffset, bool offset){
        if(first == true && second == true){
            if(offset == true){
                outOffset = true;
                return true;
            }
            outOffset = true;
            return false;
        }
        if((first == true && second == false) || (first == false && second == true)){
            if(offset == true){
                outOffset = true;
                return false;
            }
            outOffset = false;
            return true;
        }
        if(offset == true){
            outOffset = false;
            return true;
        }
        outOffset = false;
        return false;
    }

}

static class Interpritator{
    public static void interpritateBinary(bool[] print){
        foreach(var el in print){
            if(el == false){
                Console.Write(0);
                continue;
            }
            Console.Write(1);
        }
        Console.WriteLine();
    }  
}

static class MyConvert{
    
    public static int FromAppendCodeToDecimal(int size, bool[] number){
        int sign = 1;
        if(number[0] == true){
            sign = -1;
        }
        int pointer = 1;
        int result = 0;
        while(pointer < size){
            if(number[pointer] == true){
                result = result + ((int)Math.Pow(2, size - 1 - pointer));
            }
            pointer++;
        }        


        return result * sign;
    } 

    public static bool[] FromDecimalToAppendCode(int gridSize, int number){
        /*summary
        return boolean array that interpritate as 0 and 1 sequence 
        method will throw error if take numner value more than |2^gridSize|
        */
        if(number > Math.Pow(2, gridSize - 1)|| number < -1 * Math.Pow(2, gridSize - 1)){
            throw new ArgumentException("Bad argument exception , numbers shoule be in [-64, 64] gap");
        }
        var arrayToReturn = new bool[gridSize];
        if(number < 0){
            arrayToReturn[0] = true;
            number = number * -1;
        }
        if(number >= 0){
            arrayToReturn[0] = false; 
        }

        int pointer = 6;
        while(pointer > 0){
            if(number % 2 == 1){
                arrayToReturn[pointer] = true;
                number = number - 1;
                number = number / 2;
                pointer--;
                continue;
            }
            arrayToReturn[pointer] = false;
            number = number /2;
            pointer--;
            continue;
        }

        return arrayToReturn;
    }   

    public static bool[] flipIfNegative(bool[] number){
        if(number[0] == false){
            return number;
        }
        for(int i = 1; i < 7; i++){
            if(number[i] == true){
                number[i] = false;
                continue;
            }
            number[i] = true;
        }
        return number;
    }
}
