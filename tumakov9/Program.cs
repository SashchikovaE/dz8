using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace tumakov9
{
    enum Type
    {
        Current,
        Savings
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("упражнение 9.1");
            Bank bank = new Bank(48489);
            Bank bank2 = new Bank(Type.Current);
            Bank bank3 = new Bank(78436, Type.Savings);

            Console.WriteLine("упражнение 9.2");
            BankTransaction bankTransaction = new BankTransaction(437.47);
            BankTransaction bankTransaction1 = new BankTransaction(434);
            bank.AddSum(4);
            bank.WithdrawSum(56.45);
            bank3.TransferMoney(bank3, bank, 89);
            foreach (var transaction in bank.transactions)
            {
                Console.WriteLine("дата: " + bankTransaction.date + ", сумма: " + bankTransaction.sum);
            }
            foreach (var transaction in bank3.transactions)
            {
                Console.WriteLine("дата: " + bankTransaction1.date + ", сумма: " + bankTransaction1.sum);
            }

            Console.WriteLine("дз 9.1");
            Song mySong = new Song();
            //нужно создать конструктор без параметров в классе Song
            List<Song> songs = new List<Song>();

            Song song1 = new Song("ya russki", "shaman");
            songs.Add(song1);

            Song song2 = new Song("kakaya autmn v lageryah", "butyrka", song1);
            songs.Add(song2);

            Song song3 = new Song("бездел", "олечка бузова", song2);
            songs.Add(song3);

            Song song4 = new Song("хаюхай", "eeoneguy", song3);
            songs.Add(song4);

            foreach (Song song in songs)
            {
                Song s = new Song();
                Console.WriteLine($"{s.Print()}");
            }
            if (song1.Equals(song2))
            {
                Console.WriteLine("первая песня совпадает со второй песней");
            }
            else
            {
                Console.WriteLine("первая песня не совпадает со второй песней");
            }
            Console.ReadKey();
        }
    }
}
