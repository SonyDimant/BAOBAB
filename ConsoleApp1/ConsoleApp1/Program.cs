﻿using System;
using System.Linq;
class HelloWorld
{
    static void Main()
    {
        Massive_1 mas1 = new Massive_1(5);
        mas1.ShowArray();
        mas1.AverageValue();
        mas1.Morethan100();
        mas1.ArrayWithoutRepeat();
        
        Massive_2 mas2 = new Massive_2(4,3);
        mas2.AverageValue();
        mas2.ShowMatrix();
        mas2.ReverseNatrix();
        mas2.Determined();
        
        Massive_3 mas3 = new Massive_3(3);
        mas3.ShowArray();
        mas3.AverageValue();
        mas3.AverageEveryValue();
        mas3.ChangeItem();
        
    }
}
internal class Massive_1
{
    private int[] _array;
    public Massive_1(int size, bool t = false)
    {
        _array = new int[size];


        if (!t)
        {
            _array = RandomValues(size);
        }
        else
        {
            _array = IntValues(size);
        }
    }


    public static int[] RandomValues(int size)
    {
        int[] array = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(0, 255);
        }
        return array;
    }


    public static int[] IntValues(int size)
    {
        Console.WriteLine("Введите элементы: ");
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }


    public void ShowArray()
    {
        foreach (int i in _array)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    public double AverageValue()
    {
        int count_ = _array.Length;
        double summa = 0;
        for (int i = 0; count_ > i; i++)
        {
            summa += _array[i];
        }
        return summa / count_;
    }

    public void Morethan100()
    {
        int[] arr = new int[_array.Length];
        for (int i = 0; i < _array.Length; i++)
        {
            int d = _array[i];
            if (Math.Abs(d) >= 100)
            {
                arr[i] = _array[i];
            }
        }
        _array = arr;


    }
    public void ArrayWithoutRepeat()
    {
        int[] temp = new int[_array.Length];
        int p = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            if (!InArray(temp, _array[i]))
            {
                temp[p] = _array[i];
                p++;
            }
        }
        _array = temp;
    }
    static bool InArray(int[] a, int l)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == l)
            {
                return true;
            }
        }
        return false;

    }
}

class Massive_2
{
    private int[,] _array;
    private int _row;
    private int _coll;
    public Massive_2(int row, int collumn, bool t = false)
    {
        _array = new int[row, collumn];
        _row = row;
        _coll = collumn;

        if (!t)
        {
            _array = RandomValues(row, collumn);
        }
        else
        {
            _array = IntValues(row, collumn);
        }
    }


    public int[,] RandomValues(int row, int collumn)
    {
        int[,] array = new int[row, collumn];
        Random rnd = new Random();
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < collumn; j++)
            {
                array[i, j] = rnd.Next(0, 255);
            }
        }
        return array;
    }


    public int[,] IntValues(int row, int collumn)
    {
        Console.WriteLine("Введите элементы: ");
        int[,] array = new int[row, collumn];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < collumn; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }

        }
        return array;
    }

    public double AverageValue()
    {
        int count_ = 0;
        double summa = 0;
        for (int i = 0; i < _row; i++)
        {
            for (int j = 0; j < _coll; j++)
            {
                summa += _array[i, j];
            }
        }
        return summa / count_;
    }

    public void ShowMatrix()
    {
        for (int i = 0; i < _array.GetLength(0) + 1; i++)
        {
            for (int j = 0; j < _array.Length / (_array.GetUpperBound(0) + 1); j++)
            {
                Console.Write(_array[i, j] + '\t');
            }
            Console.WriteLine();
        }
    }

    public void ReverseNatrix()
    {
        for (int i = 0; i < _array.GetLength(0) + 1; i++)
        {
            for (int j = 0; j < _array.Length / (_array.GetLength(0) + 1); j++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(_array[i, _coll - j - 1] + '\t');
                }
                else
                {
                    Console.Write(_array[i, j] + '\t');
                }
                Console.WriteLine();
            }
        }
    }

    public int Determined()
    {
        return _array[0, 0] * (_array[1, 1] * _array[2, 2] + _array[2, 1] * _array[1, 2]) + _array[0, 1] * (_array[1, 0] * _array[2, 2] + _array[2, 0] * _array[1, 2]) + _array[0, 2] * (_array[1, 0] * _array[2, 1] + _array[2, 0] * _array[1, 1]);
    }
}
internal class Massive_3
{
    private int[][] _array;
    private int _size;

    public Massive_3(int size, bool t = false)
    {
        _size = size;
        _array = new int[size][];

        if (!t)
        {
            _array = RandomValues(size);
        }
        else
        {
            _array = IntValues(size);
        }
    }

    public int[][] RandomValues(int size)
    {
        int[][] array = new int[size][];
        Random rnd = new Random();

        for (int i = 0; i < size; i++)
        {
            int col = rnd.Next(3, 10);
            array[i] = new int[col];
            for (int j = 0; j < col; j++)
            {
                array[i][j] = rnd.Next(0, 10);
            }
        }
        return array;
    }

    public int[][] IntValues(int size)
    {
        int[][] array = new int[size][];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Введите элементы: ");
            int collumn = int.Parse(Console.ReadLine());
            array[i] = new int[collumn];

            for (int j = 0; j < collumn; j++)
            {
                Console.WriteLine("Введите элементы: ");
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }


        return array;
    }

    public void ShowArray()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                Console.Write(_array[i][j] + "");
            }
            Console.WriteLine();
        }
    }

    public double AverageValue()
    {
        int count_ = 0;
        double summa = 0;

        foreach (int[] item in _array)
        {
            summa += item.Sum();
            count_ += item.Length;
        }

        return summa / count_;
    }

    public double[] AverageEveryValue()
    {
        double[] AverageArray = new double[_array.Length];
        double sum = 0;
        double count = 0;
        int j = 0;
        foreach (int[] item in _array)
        {
            sum = item.Sum();
            count = item.Length;
            AverageArray[j++] = sum / count;
        }
        return AverageArray;
    }

    public void ChangeItem()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                if (_array[i][j] % 2 == 0)
                {
                    _array[i][j] = i * j;
                }
            }
        }
    }
}

