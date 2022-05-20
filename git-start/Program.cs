using System;

namespace git_start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today 20.05.22 and studying the Git system");
            Console.WriteLine("I found out about:");
            Console.WriteLine("git log, git show, git restore, git diff, git mv, git rm.");
            Console.WriteLine("git log - показывает историю коммитов и их хэш");
            Console.WriteLine("git show + hash - показывает подробности коммита");
            Console.WriteLine("git restore + имя файла - откатывает состояние файла к последнему коммиту");
            Console.WriteLine("git diff - показывает изменения в файлах вне индекса, а если добавить --staged внутри");
            Console.WriteLine("git mv имя файла + *новое имя* - переименовывает имя файла, также если добавить вместо нового имени путь, то измениться путь");
            Console.WriteLine("git rm имя файла - удалит файл везде, а сели добавть --cashed, то просто удалится из коммита, но останется в коллеции");
        }
    }
}
