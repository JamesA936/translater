using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace translater
{
    class Program
    {
        static void Main(string[] args)
        {


            // Dim length As Integer = InputBox("Enter length of room")
            Console.WriteLine("Enter the length of the room? ");
            int length = Int32.Parse(Console.ReadLine());

            // Dim width As Integer = InputBox("Enter width of room")
            Console.WriteLine("Enter the width of the room? ");
            int width = Int32.Parse(Console.ReadLine());

            // Dim unusedSpaceLength As Integer = InputBox("Enter lenth of unused space")
            Console.WriteLine("Enter the length of unused space? ");
            int unusedength = Int32.Parse(Console.ReadLine());

            // Dim unusedSpaceWidth As Integer = InputBox("Enter width of unused space")
            Console.WriteLine("Enter the width of the room? ");
            int unusedwidth = Int32.Parse(Console.ReadLine());

            // Dim area As Integer = length * width
            int area = length * width;

            // Dim unsuedSpace As Integer = unusedSpaceLength * unusedSpaceWidth
            int unusedarea = unusedength * unusedwidth;

            // area = area - unsuedSpace
            area = area - unusedarea;

            // Dim litresNeeded = area / 11 'meters squared /Litre
            int leters;
            leters = area / 11;

            // MsgBox("Litres needed: " & litresNeeded)
            Console.WriteLine(leters + " leters of paint needed.");
            Console.ReadLine();


        }


        /*
        
        'W1 Q1 Paint Litres Needed
        'Declare variables as type integer and then assign the values returned from the input box

        Dim length As Integer = InputBox("Enter length of room")
        Dim width As Integer = InputBox("Enter width of room")
        Dim unusedSpaceLength As Integer = InputBox("Enter lenth of unused space")
        Dim unusedSpaceWidth As Integer = InputBox("Enter width of unused space")
        Dim area As Integer = length * width
        Dim unsuedSpace As Integer = unusedSpaceLength * unusedSpaceWidth
        area = area - unsuedSpace

        'declare the variable and assign the results of the calculation
        Dim litresNeeded = area / 11 'meters squared /Litre

        'Ouptut the string and append the value stored in the variable
        MsgBox("Litres needed: " & litresNeeded)

        
         */
    }


}
