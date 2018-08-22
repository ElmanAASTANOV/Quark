//Created By Elman Astanov
//22 avgust  2018 12:44:00

using Quark.Domain.Abstractions;

namespace Quark.Domain.Enums
{
    abstract class BaseEnum : ICreate ,IGetName
    {
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
