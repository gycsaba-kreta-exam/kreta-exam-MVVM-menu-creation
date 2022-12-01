﻿using KretaCommandLine.Model.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaCommandLine.Model.Base
{
    public abstract class Person : IId, IPerson, IEquatable<Person>, IComparable
    {
        public long Id { get; set;}
        public string FirstName { get; set ;}
        public string LastName { get; set; }
        public bool Wooman { get; set; }
        public DateTime DataOfBirth { get; set; }

        private IAddress address;
        private IAccount account;

        protected Person(long id, string firstName, string lastName, bool wooman, DateTime dataOfBirth, IAddress address, IAccount account)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Wooman = wooman;
            DataOfBirth = dataOfBirth;
            this.address = address;
            this.account = account;
        }

        protected Person()
        {
            Id = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Wooman = false;
            DataOfBirth = DateTime.MinValue;
            this.address = new Address();
            this.account = new Account();
        }

        public bool Equals(Person other)
        {
            return false;
        }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
