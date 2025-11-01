using System;
public class LeftRotationOfArray
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        Console.Write("Original Array :");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        //Object declaration of class to access LeftRotate method
        LeftRotationOfArray obj = new LeftRotationOfArray();

        Console.Write("Left Rotation of Array by 1: ");
        obj.LeftRotate(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.ReadKey();
    }

    void LeftRotate(int[] arr)
    {
        int x = arr[0];
        for (int i = 0; i < (arr.Length - 1); i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[(arr.Length - 1)] = x;
    }
}