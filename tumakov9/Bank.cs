﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov9
{
    internal class Bank
    {
        public int[] number;
        public double balance;
        public Type type;
        public Queue<BankTransaction> transactions {  get; set; }
        public Bank()
        {
            GenerateBankNumber(number);
            transactions = new Queue<BankTransaction>();
        }
        public Bank(double Balance)
        {
            number = GenerateBankNumber(number);
            balance = Balance;
            transactions = new Queue<BankTransaction>();
        }
        public Bank(Type typee)
        {
            number = GenerateBankNumber(number);
            type = typee;
            transactions = new Queue<BankTransaction>();
        }
        public Bank(double Balance, Type typee)
        {
            number = GenerateBankNumber(number);
            balance = Balance;
            type = typee;
            transactions = new Queue<BankTransaction>();
        }
        public int[] GenerateBankNumber(int[] number)
        {
            number = new int[16];
            Random random = new Random();
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(0, 10);
            }
            return number;
        }
        public void AddSum(double sum)
        {
            if (sum >= 0)
            {
                balance += sum;
            }
            var transaction = new BankTransaction(sum);
            transactions.Enqueue(transaction);
        }
        public void WithdrawSum(double sum) 
        {
            if (sum >= 0 && sum < balance)
            {
                balance -= sum;
            }
            var transaction = new BankTransaction(-sum);
            transactions.Enqueue(transaction);
        }
        public void TransferMoney(Bank fromAccount, Bank account2, double amount)
        {
            if (amount <= fromAccount.balance)
            {
                fromAccount.balance -= amount;
                balance += amount;
                Console.WriteLine($"перевод в размере {amount} успешно выполнен");
            }
            else
            {
                Console.WriteLine("недостаточно средств на счете");
            }
            var transaction = new BankTransaction(amount);
            transactions.Enqueue(transaction);
        }
    }
}
