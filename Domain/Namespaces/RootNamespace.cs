//Created By Elman Astanov
//22 avgust  2018 11:58:00

using Quark.Domain.Abstractions;

namespace Quark.Domain.Namespaces
{
    class RootNamespace : BaseNamespace
    {
       //Constructors 
        public RootNamespace(string Name, string RootNameSpace) : base(Name, RootNameSpace)
        {
        }

       //Methods 
        public override void Create()
        {
            throw new System.NotImplementedException();
        }
    }
}