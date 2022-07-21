namespace ArrayManager2
{
    public class MyArray2
    {

        int[][] array;
        public MyArray2()
        {
            array = new int[5][];
            array[0] = new int[5];
            array[1] = new int[5];
            array[2] = new int[5];
            array[3] = new int[5];
            array[4] = new int[5];

            var rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rnd.Next(0, 20);
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Иходный");
        }

        public MyArray2(int[][] arr)
        {
            array = arr;
        }
       // Вычесть от каждого элемента строки, самый маленький элемент строки.
        public MyArray2 ChangeElemArr(Func<int[], int[]> f)
        {
            int[][] newArr = array.Select(f).ToArray();
            return new MyArray2(newArr);
        }
       // Отсортировать строки по сумме остатков от деления на 3 .
        public MyArray2 SortByRow(Func<int[], double> f)
        {
            var newArr = array.OrderBy(f).ToArray();
            return new MyArray2(newArr);
        }
        
        //За каждым  m-м столбцом вставить его дубликат.
        public MyArray2 DuplicateElem(int num)
        {
            int[][] newArr = new int[array.Length][];
            int addNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = new int[array[i].Length + (array[i].Length / num)];
                for (int j = 0, k = 0; j < array[i].Length; j++, k++)
                {
                    if (j % num != 0 && j != 0)
                    {
                        addNum = array[i][j];
                        newArr[i][k] = addNum;
                        newArr[i][++k] = addNum;
                    }
                    newArr[i][k] = array[i][j];
                }
            }
            return new MyArray2(newArr);
        }

        public MyArray2 Print()
        {
            foreach (var arr in array)
            {
                foreach (var el in arr)
                {
                    Console.Write($"{el}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return this;
        }
    }
}