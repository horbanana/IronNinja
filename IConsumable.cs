using System;

namespace IronNinja
{
    public interface IConsumable
    {
        string name {get;set;}
        int calories {get;set;}
        bool isSpicy {get;set;}
        bool isSweet {get;set;}
    }   
}