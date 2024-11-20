﻿using System;
using System.Collections.Generic;
namespace LibraryManagement
{
    public class Reader
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Reader(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
    public class ReaderManager

    {
        public List<Reader> Readers { get; private set; }

        public ReaderManager()
        {
            Readers = new List<Reader>();
        }
        public void AddReader(Reader reader)
        {
            Readers.Add(reader);
        }
        public void RemoveReader(string readerId)
        {
            Reader readerToRemove = Readers.Find(reader => reader.Id == readerId);
            if (readerToRemove != null)
            {
               Readers.Remove(readerToRemove);
            }
        }
        public Reader GetReader(string readerId)
        {
            return Readers.Find(reader => reader.Id == readerId);
        }
        public List<Reader> GetAllReaders()
        {
            return Readers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReaderManager readerManager = new ReaderManager();
            Reader reader1 = new Reader("1", "Sasha Smirnov", "smirnov@example.com");
            Reader reader2 = new Reader("2", "Polina Vovina", "polina@example.com");
            readerManager.AddReader(reader1);
            readerManager.AddReader(reader2);
            var allReaders = readerManager.GetAllReaders();
            foreach (var reader in allReaders)
            {
                Console.WriteLine($"Id: {reader.Id}, Name: {reader.Name}, Email: {reader.Email}");
            }
            readerManager.RemoveReader("1");

            Console.WriteLine("After removing reader with Id '1':");

            allReaders = readerManager.GetAllReaders();

            foreach (var reader in allReaders)
            {

                Console.WriteLine($"Id: {reader.Id}, Name: {reader.Name}, Email: {reader.Email}");
            }
        }
    }
}

