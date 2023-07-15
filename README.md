1. Пользователю предлагается ввести массив строк через запятую.
2. Введенная строка разделяется на отдельные элементы массива с помощью метода `Split(',')`.
3. Создается переменная `count` и инициализируется значением 0. Она будет использоваться для подсчета количества строк, длина которых меньше или равна 3 символам.
4. Происходит итерация по каждому элементу массива:
   - Если длина текущей строки меньше или равна 3, увеличивается значение переменной `count` на 1.
5. Создается новый массив `resultArr` размером `count`.
6. Создается переменная `index` и инициализируется значением 0. Она будет использоваться для отслеживания индекса в массиве `resultArr`.
7. Происходит итерация по каждому элементу массива:
   - Если длина текущей строки меньше или равна 3, она добавляется в массив `resultArr` по индексу `index`, затем значение переменной `index` увеличивается на 1.
8. Выводится сообщение "Результат:".
9. С помощью метода `string.Join(", ", resultArr)` элементы массива `resultArr` объединяются в строку, разделяя их запятой и пробелом.
10. Выводится полученная строка, заключенная в квадратные скобки, с помощью `Console.WriteLine("[ " + joinedResult + " ]")`.

Таким образом, программа запрашивает у пользователя массив строк, фильтрует строки длиной меньше или равной 3 символам и выводит результат в квадратных скобках.
