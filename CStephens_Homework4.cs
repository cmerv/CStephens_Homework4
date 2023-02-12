namespace CStephens_Homework4;
class Homework4
{
    static void Main(string[] args)
    {
        start:
        Console.WriteLine("Select your Method");
        Console.WriteLine("GreaterThan");
        Console.WriteLine("Triangle");
        string? selection = Console.ReadLine();
        //
        switch (selection?.ToLower()){

        default:
        Console.WriteLine("Wrong method name entered. Restarting program.");
        goto start;
        
        case "greaterthan":
        Console.WriteLine("2 Number Greater Than Program...");
        Console.WriteLine("Type an integer for integer A:");
        int intA = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Type an integer or integer B:");
        int intB = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"A = {intA}, B = {intB}");
        GreaterThan(intA, intB);       
        break;

        case "triangle":
        TriangleLeftRight();
        break;
        }
        
    }
    static void GreaterThan(int gtIntA, int gtIntB){
        bool gtResult = gtIntA>gtIntB;
        switch (gtResult){
            case true:
            Console.WriteLine($"The greater number is {gtIntA}");
            break;

            case false:
            Console.Write($"The greater number is {gtIntB}");
            break;
        }
    }
    static void TriangleLeftRight(){
        Console.WriteLine("Triangle Program...");
		Console.WriteLine ("Assign an integer value to N:");
		int _numInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Left or right?");
        string? _sideSelect = Console.ReadLine();
        int _height;
        int  _length;
        Console.WriteLine($"N is {_numInput}, Side is {_sideSelect}");
        switch (_sideSelect?.ToLower()){
        case "left":
        for (_height=0;_height<_numInput;_height++){
            // controls the height of the display
			for ( _length=0;_length<=_height;_length++){
            // controls width. relate length to height to change output depending on which row we are on
			Console.Write("#");
			}
		Console.WriteLine("");
        }
        break;        

        case "right":
            int _blank;
		for (_height=0;_height<=_numInput;_height++){
			for (_blank=1;_blank<=_numInput-_height;_blank++){
                // defines how we calculate the blank space that fills in where no number exists yet
			Console.Write(" ");
			}
			for (_length=1;_blank+_length<=_numInput+1;_length++){ 
                //as we are pushing our numbers all the way to the right, we need to keep track of the left-bound blank space which decreases as we count up
			Console.Write("*");
			}
		Console.WriteLine("");
		}
        break;
        }
		

        
    }
}