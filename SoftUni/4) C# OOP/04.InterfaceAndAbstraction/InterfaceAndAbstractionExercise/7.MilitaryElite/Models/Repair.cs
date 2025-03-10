﻿namespace _7.MilitaryElite.Models
{
    using Contracts;

    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked) 
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hourse worked: {this.HoursWorked}";
        }
    }
}