//Created By Elman Astanov
//22 avgust  2018 12:48:00

using System.Collections.Generic;

using Quark.Domain.Abstractions;
using Quark.Domain.Parametrs;

namespace Quark.Domain.Methods
{
    abstract class BaseMethod : IGetName
    {
       //Constructors
         public BaseMethod(string Name,string Type,List<BaseParametr> Parametrs)
         {
            this.name = Name;
            this.type = Type;
            this.parametrs = Parametrs;
         }

       //Fields
        protected string type;
        protected string name;
        protected List<BaseParametr> parametrs;
       //Methods 
        abstract public string GetFullName();       

    }
}