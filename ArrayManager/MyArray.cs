namespace ArrayManager1
{
    public class MyArray
    {
        /*1.	Получить массив из файла. Убрать все 0е элементы. 
         * Вычеркнуть каждую N-ю строку. Отсортировать строки по количеству четных чисел. 
          Вывести на экран итог.*/

        public int[][] array;

        public MyArray(string path)
        {
            string[] rows = File.ReadAllLines(path);
            array = new int[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] numbers = rows[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                array[i] = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    array[i][j] = int.Parse(numbers[j]);
                    Console.Write("{0} ", array[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Исходный");
        }
        public MyArray(int[][] arr)
        {
            this.array = arr;
        }

        public MyArray ChangeElemArr(int num)
        {
            var newArr = new int[array.Length][];

            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                newArr[j] = array[i].Where(x => x != num).ToArray();
            }
            return new MyArray(newArr);
        }

        public MyArray ChangeRowArr(int num)
        {
            var newArr = array.Where((x, index) => index % num != 0).ToArray();
            return new MyArray(newArr);
        }

        public MyArray SortByRow(Func<int[], int> f)
        {
            var newArr = array.OrderBy(f).ToArray();
            return new MyArray(newArr);
        }

        public MyArray Print()
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