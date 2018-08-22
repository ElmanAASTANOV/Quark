//Created By Elman Astanov
//22 avgust  2018 12:52:00

using Quark.Domain.Abstractions;

namespace Quark.Domain.Parametrs
{
    abstract class BaseParametr : IGetName
    {
       //Fields 
        protected string name;
        protected string type;

       //Constructors 
        public BaseParametr(string Name,string Type)
        {
            this.name = Name;
            this.type = Type;
        }

       //Methods 
        public abstract string GetFullName();
    }
}