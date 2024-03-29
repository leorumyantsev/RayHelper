﻿using System;

namespace RayHelper.Models.Entities
{
    public class Hospice : EntityBase, IComparable
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Metro { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string EMail { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string ImageSource { get; set; }
        public string Details { get; set; }

        public string Address
        {
            get
            {
                var address = $"{City}, {Street}";
                if (!string.IsNullOrWhiteSpace(HouseNumber))
                {
                    address += $", {HouseNumber}";
                }
                if (!string.IsNullOrWhiteSpace(Metro))
                {
                    address += $", м. {Metro}";
                }
                return address;
            }
        }

        public int CompareTo(object obj)
        {
            var hospice = (Hospice) obj;
            if (String.CompareOrdinal(this.City,hospice.City) == 0)
            {
                if (String.CompareOrdinal(this.Street,hospice.Street) == 0)
                {
                    return String.CompareOrdinal(this.HouseNumber,hospice.HouseNumber);
                }
                else
                {
                    return String.CompareOrdinal(this.Street,hospice.Street);
                }
            }
            else
            {
                return String.CompareOrdinal(this.City, hospice.City);
            }
        }
    }
}