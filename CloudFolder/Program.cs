using CloudFolder.Data;
using CloudFolder.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Создать консольную программу, которая работает, как Облачное хранилище.
            // TODO Пользователь может создавать виртуальную структуру папок и 
            // TODO сохранять в этой виртуальной структуре файлы.
            List<Folder> folders;
            List<File> files;
            using (var context = new CloudContext())
            {
                folders = context.Folders.ToList();
                files = context.Files.ToList();
                Console.WriteLine(folders);
                Console.WriteLine(files);
            }

            Console.WriteLine("Создать Папку - 1");
            Console.WriteLine("Создать Файл - 2");
            Console.WriteLine("Выход - 0");
            string stringChoise = Console.ReadLine();
            int choise;
            int.TryParse(stringChoise, out choise);
            Folder folder = null;
            File file = null;
            if(choise == 1)
            {
                Console.WriteLine("Введите название папки");
                string nameOfFolder = Console.ReadLine();
                folder = new Folder { Name = nameOfFolder};
            }
            else if (choise == 2)
            {
                Console.WriteLine("Введите название файла");
                string nameOfFile = Console.ReadLine();
                file = new File { Name = nameOfFile };
            }
            else
            {

            }


            using (var context = new CloudContext())
            {
                if (choise == 1)
                {
                    context.Add(folder);
                }
                else if (choise == 2)
                {
                    context.Add(file);
                }
                context.SaveChanges();
            }


            // TODO Вся виртуальная структура храниться в БД. 
            // TODO Все файлы являются зеркалом настоящих файлов операционной системы.
        }
    }
}
