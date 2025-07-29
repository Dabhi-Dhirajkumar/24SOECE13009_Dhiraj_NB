using System;

class jaggedarray
{
    static void Main()
    {
        int[][] jAry = new int[7][];
        jAry[0] = new int[4];
        jAry[1] = new int[3];
        jAry[2] = new int[2];
        jAry[1] = new int[1];
        Console.WriteLine("Enter Jagged Array element :");
        for (int i = 0; i < jAry.Length; i++)
        {
            for (int j = 0; j < jAry[i].Length; j++)
            {
                jAry[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Jagedded Array "); 
        for(int i = 0;i< jAry.Length;i++)
        {
            for(int j = 0;j< jAry.Length;j++)
            {
                Console.WriteLine(jAry[i][j]);
            }
            Console.WriteLine();
        }
    }
}
