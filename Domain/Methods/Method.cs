//Created By Elman Astanov
//22 avgust  2018 12:48:00

using System.Collections.Generic;

using Quark.Domain.Abstractions;
using Quark.Domain.Parametrs;

namespace Quark.Domain.Methods
{
    class Method : BaseMethod
    {
       //Constructors 
        public Method(string Name, string Type, List<BaseParametr> Parametrs) : base(Name, Type, Parametrs)
        {
        }
       //Methods 
        public override string GetFullName()
        {
            string fullName = $"{this.type} {this.name}(";
            foreach(IGetName name in this.parametrs)
            {
                fullName+=name.GetFullName()+",";
            }
            fullName = fullName.TrimEnd(',') +")";

            return fullName;
        }
    }
}