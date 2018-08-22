//Created By Elman Astanov
//22 avgust  2018 11:58:00

using System.Collections.Generic;

using Quark.Domain.Enums;
using Quark.Domain.Abstractions;

namespace Quark.Domain.Namespaces
{
    abstract class BaseNamespace : ICreate ,IGetName
    {

       //Fields
        protected string name;
        protected string rootNameSpace;
        public List<BaseEnum> Enums= new List<BaseEnum>();
        public List<BaseNamespace> Namespaces = new List<BaseNamespace>();
        
       //Constructors
        public BaseNamespace(string Name,string RootNameSpace) 
        {
            this.name = Name;
            this.rootNameSpace = RootNameSpace;
        }
        
       //Methods 
        public abstract void Create();

        public string GetFullName()
        {
            return $"{rootNameSpace}.{name}";
        }
      
    }
}