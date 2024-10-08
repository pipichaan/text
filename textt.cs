class Program
{
    static void Main(string[] args)
    {
        string nachalo = "C:\\Users\\alina\\OneDrive\\Рабочий стол\\2 курс\\системка\\text.txt"; 
        string resultat = "C:\\Users\\alina\\OneDrive\\Рабочий стол\\2 курс\\системка\\ololo.txt"; 

        try
        {
            // Чтение содержимого файла
            string text = File.ReadAllText(nachalo);

            // Подсчет символов
            int sim = text.Length;

            // Подсчет символов без пробелов
            int prob = text.Count(c => !char.IsWhiteSpace(c));

            // Подсчет слов
            int slova = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Формирование результатов
            string results = $"Количество символов: {sim}\n" + $"Количество символов без пробелов: {prob}\n" + $"Количество слов: {slova}";

            // Вывод результатов в консоль
            Console.WriteLine(results);

            // Запись результатов в файл
            File.WriteAllText(resultat, results);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Ошибка: файл не найден.");
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("Ошибка при чтении файла.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка.");
            Console.WriteLine(ex.Message);
        }
    }
}