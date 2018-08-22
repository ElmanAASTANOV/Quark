//Created By Elman Astanov
//22 avgust  2018 13:50:00

using Quark.Domain.Abstractions;

namespace Quark.Domain.Fields
{
    class Field : BaseField
    {
       //Constructors 
        public Field(string Type, string Name) : base(Type, Name)
        {
        }
       //Methods 
        public override string GetFullName()
        {
            return $"public {this.type} {this.name}";
        }
    }
}