using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class House
    {
        private string owner;
        private string ghost;
        private int roomCount;
        public House(){
            owner="Ronald";
            ghost="Casper";
            roomCount=1;
        }
        public House(string _owner, string _ghost, int _roomCount){

        }
        public override string ToString(){
            return $"Owner {owner} Ghost {ghost} Room Count {roomCount}";
        }

        //public string  MiceName { get{return owner;} set{owner=value;} }
        public string Owner { get{ return owner ;} set{ owner=value;} }
        
    }
}