﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceH
{
    internal struct AddressFormat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string district;

        public AddressFormat(byte houseNo, byte roadNo, ushort postalCode, string district)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.district = district;
        }

        public void PrintAddress()
        {
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
            Console.WriteLine("District: {0}", this.district);
        }
    }

    internal abstract class Person
    {
        private static int serialNo = 0;
        private protected string id;
        //private string name;
        //private string bloodGroup;
        private AddressFormat address;

        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "P-" + value; }
        }

        internal string Name { get; set; }

        internal string BloodGroup { get; private set; }

        //internal string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        //internal string BloodGroup
        //{
        //    get { return this.bloodGroup; }
        //    private set { this.bloodGroup = value; }
        //}

        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Person(string name, string bloodGroup, AddressFormat address)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.BloodGroup = bloodGroup;
            this.Address = address;
        }

        internal virtual void ShowPersonInfo()
        {
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine($"Blood Group: {this.BloodGroup}");
            Console.WriteLine("Address: ");
            this.Address.PrintAddress();
            //Console.WriteLine();
        }
    }
}
