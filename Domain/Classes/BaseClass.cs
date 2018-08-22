//Created By Elman Astanov
//22 avgust  2018 13:21:00

using System.Collections.Generic;

using Quark.Domain.Abstractions;
using Quark.Domain.Methods;
using Quark.Domain.Fields;

namespace Quark.Domain.Classes
{
    abstract class BaseClass : ICreate, IGetName
    {
       //Fields
        protected string name;
        protected string rootName;
        public List<BaseField> fields = new List<BaseField>();
        public List<BaseMethod> methods = new List<BaseMethod>();

       //Constructors 
        public BaseClass(string Name,string RootName)
        {

        }
       //Methods 
        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public string GetFullName()
        {
            throw new System.NotImplementedException();
        }
    }
}