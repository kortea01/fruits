using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _20240203_Fruit_KorteA
{
    internal class Fruit
    {
        ulong id;
        string name;
        int amount;

        public ulong Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public Fruit(ulong id, string name, int amount)
        {
            Id = id;
            Name = name;
            Amount = amount;

        }
        public override string ToString()
        {
            return $"{this.name} {this.amount}";
        }

        internal string toTxt()
        {
            return $"{id};{this.name};{this.amount}";
        }
    }
}
