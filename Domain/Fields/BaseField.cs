//Created By Elman Astanov
//22 avgust  2018 13:41:00

using Quark.Domain.Abstractions;

namespace Quark.Domain.Fields
{
    abstract class BaseField : IGetName
    {
       //Fields
        protected string name;
        protected string type;

       //Constructors
        public BaseField(string Type,string Name)
        {
            this.name = Name;
            this.type = Type;
        }

       //Methods 
        public abstract string GetFullName();        
    }
}