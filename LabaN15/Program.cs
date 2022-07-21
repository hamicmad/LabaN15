using ArrayManager1;
using ArrayManager2;

/*1.	Получить массив из файла. Убрать все 0е элементы. 
Вычеркнуть каждую N-ю строку. 
Отсортировать строки по количеству четных чисел. Вывести на экран итог.*/
  
var myArray = new MyArray("input1.txt");
myArray.ChangeElemArr(0).ChangeElemArr(1).ChangeRowArr(2).Print();


/*Получить массив при помощи рандома. Вычесть от каждого элемента строки, самый маленький элемент строки. 
Отсортировать строки по сумме остатков от деления на 3 .
За каждым  m-м столбцом вставить его дубликат. Итог сохранить в файл*/


var myArray2 = new MyArray2();
myArray2.ChangeElemArr(r => r.Select(e => e - r.Min()).ToArray())
                                                      .SortByRow(r => (double)r.Sum(e => e % 3))
                                                      .DuplicateElem(2)
                                                      .Print();



