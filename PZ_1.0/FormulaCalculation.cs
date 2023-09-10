namespace PZ_1
{
    internal class FormulaCalculation
    {
        static void Main(string[] args)
        {
            bool trySnova = true; //задаю значение true, чтобы while начал выполняться 
            while (trySnova) //создацию цикл, чтобы, когда  catch поймал ошибку, можно было вернуться вначало не перезапуская код.
            {
                try //ловятся ошибки
                {
                    Console.ResetColor(); //консоль возвращается к изначальному цвету.
                    Console.WriteLine("Введите число a");
                    double a = double.Parse(Console.ReadLine().Replace('.', ','));//число задается под double + замена точек на запятые, чтобы можно было вводить точку. 
                    if (a <= 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red; //фон строки принимает красный цвет, говоря об ошибке.
                        Console.ForegroundColor = ConsoleColor.Black; //текст строки принимает черный цвет, говоря об ошибке
                        Console.WriteLine("Введенное число не может принимать значения 0 и < 0 и 1");
                        continue;
                    }

                    Console.WriteLine("Введите число b");
                    double b = double.Parse(Console.ReadLine().Replace('.', ','));

                    if (b <= 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red; //фон строки принимает красный цвет, говоря об ошибке.
                        Console.ForegroundColor = ConsoleColor.Black; //текст строки принимает черный цвет, говоря об ошибке.
                        Console.WriteLine("Введенное число не может принимать зачение 0 ");
                        continue;
                    }
                    Console.WriteLine("Введите число c");
                    double c = double.Parse(Console.ReadLine().Replace('.', ','));
                    Console.WriteLine("Введите точность результата"); //задаёт точность округления по правилам, цифра до которой производится округление
                    int roundv = Convert.ToInt32(Console.ReadLine());
                    if (roundv < 0)
                    {
                        roundv = 0;
                        Console.WriteLine("Вы ввели значение точности < 0, исправлено на 0");
                    }

                    double FirstAction = (3 * Math.Log(8, a)) / (Math.Round(Math.Sin(b / (3 * a)), 2)); //выводится при значении 3.14 правильное решение
                    double SecondAction = Math.Pow((5 * a * a) + 7, 1 / 3.0); //написал нолик, указав то, что это число с точкой, ибо 1 / 3 - это целочисленное деление.
                    double ThirdAction = (4 * Math.Abs(c - 2 * a + 1)) / Math.Sqrt(8 * a);
                    double ChetireNd = FirstAction - SecondAction + ThirdAction; //окончательные действия 
                    Console.WriteLine("Полученный результат" + "=" + Math.Round(ChetireNd, roundv));
                    trySnova = false; //задаю значение false, чтобы цикл завершился после успешного выполнения.

                }

                catch (System.FormatException) //поймал ошибку
                {
                    Console.BackgroundColor = ConsoleColor.Red; //фон строки принимает красный цвет, говоря об ошибке.
                    Console.ForegroundColor = ConsoleColor.Black; //текст строки принимает черный цвет, говоря об ошибке.
                    Console.WriteLine("Вы ввели символ (не число) или ваше значение = NULL (пустая строка)");
                }

            }

        }
    }
}