Console.Clear();
Console.Write("Введите номер задачи(1-3):");
int nom = Convert.ToInt32(Console.ReadLine());
switch (nom)
{
    case 1:
        Console.WriteLine("Алгоритм считаетсколько чисел больше 0 ввёл пользователь.");
        int count = 0;
        Console.Write("Введите размер массива:");
        int size = Convert.ToInt32(Console.ReadLine());    // пользователь задает размер массива
        int[] arrayP = new int[size];                      // алгоритм его создает
        for (int i = 0; i < arrayP.Length; i++)            //цикл наполнения массива 
        {
            Console.Write($"Введите {i + 1} число массива:");
            arrayP[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("[ " + string.Join(", ", arrayP) + " ]");
        for (int i = 0; i < arrayP.Length; i++)
        {
            if (arrayP[i] > 0) count += 1;
        }
        Console.WriteLine($"в данном масиве {count} элемента(ов) больше нуля !");
        break;

    case 2:
        Console.WriteLine("Алгоритм нахождения точки пересечния прямых.");
        Console.Write($"Введите b1 первую координату:");
        double b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите k1 вторую координату:");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите b2 третью координату:");
        double b2 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите k2 четвертую координату:");
        double k2 = Convert.ToInt32(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);

        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

        Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x}, {y})");
        break;
    case 3:
        Console.WriteLine("Алгоритм который сдвигает массив.");
        Console.Write("Введите размер массива:");
        int size3 = Convert.ToInt32(Console.ReadLine());
        int[] arrayI = new int[size3];
        for (int i = 0; i < arrayI.Length; i++)
        {
            Console.Write($"Введите {i + 1} число массива:");
            arrayI[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("[ " + string.Join(", ", arrayI) + " ]");

        if (arrayI.Length > 1)
        {
            int tmp = arrayI[arrayI.Length - 1];

            for (int i = arrayI.Length - 1; i != 0; --i) { arrayI[i] = arrayI[i - 1]; }

            arrayI[0] = tmp;
        }
        Console.WriteLine("Сдвиг вправо [ " + string.Join(", ", arrayI) + " ]");
        break;
}

/* 
 */

/* 
 */






/* */

