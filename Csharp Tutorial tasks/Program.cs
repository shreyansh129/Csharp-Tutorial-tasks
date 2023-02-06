class Tutorial{
   static void Main(){
        /*Area of Circle*/
        double PI = 3.14159;
        int radius = 2;
        System.Console.WriteLine("Area of Circle = " + PI * radius * radius);

        /*height (in feet and inches) to centimeters.*/

        int feet = 5;
        double inches = 7 * 2.54;    
        double resultfeet = 12 * 2.54 * feet;
        double height = (resultfeet + inches);
        string value = ("Height in feet and inches to centimeters: "+height+"cm");
        System.Console.WriteLine(value);

        /*Write a C# program to get nearest thousand of given integer number. Here, let name the input value as "number".*/
        /*If the number's last three digits are greater than or equal to 500; it should "round up" the number.

        If the number's last three digits are less than 500; it should "round down" the number.

        If the number is less than 500; it should round up to 1000.*/


    }
}