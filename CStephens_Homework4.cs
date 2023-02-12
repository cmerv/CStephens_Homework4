namespace CStephens_Homework4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select your Method");
        Console.WriteLine("GreaterThan");
        Console.WriteLine("TriangleLeft");
        Console.WriteLine("TriangleRight");
        string selection = Console.ReadLine().ToLower();
        //
        switch (selection){
        
        case "GreaterThan":
        GreaterThan();       
        break;

        case "TriangleLeft":
        TriangleLeft();
        break;

        case "TriangleRight":
        TriangleRight();
        break;

        }
        
    }
    static void GreaterThan(){
        Console.WriteLine("2 Number Greater Than Program...");
        Console.WriteLine("Type an integer for integer A:");
        int intA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type an integer or integer B:");
        int intB = Convert.ToInt32(Console.ReadLine());
        bool gtResult = intA>intB;
        Console.WriteLine($"A = {intA}, B = {intB}");
        switch (gtResult){
            case true:
            Console.WriteLine($"The greater number is {intA}");
            break;

            case false:
            Console.Write($"The greater number is {intB}");
            break;
        }
    }
    static void TriangleLeft(){
        Console.WriteLine("Triangle Left Program...");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInputL = Convert.ToInt32(Console.ReadLine());
		for (int _heightL=0;_heightL<_numInputL;_heightL++){
            // controls the height of the display
			for (int _lengthL=0;_lengthL<=_heightL;_lengthL++){
            // controls width. relate length to height to change output depending on which row we are on
			Console.Write("#");
			}
		Console.WriteLine("");
		}
    }

    static void TriangleRight(){
        Console.WriteLine("------Part 4 begin------");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInputR = Convert.ToInt32(Console.ReadLine());
        int _blank;
		for (int _heightR=0;_heightR<=_numInputR;_heightR++){
			for (_blank=1;_blank<=_numInputR-_heightR;_blank++){
                // defines how we calculate the blank space that fills in where no number exists yet
			Console.Write(" ");
			}
			for (int _lengthR=1;_blank+_lengthR<=_numInputR+1;_lengthR++){ 
                //as we are pushing our numbers all the way to the right, we need to keep track of the left-bound blank space which decreases as we count up
			Console.Write($"{_lengthR}");
			}
		Console.WriteLine("");
		}
    }
        //
    }