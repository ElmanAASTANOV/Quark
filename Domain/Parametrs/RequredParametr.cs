//Created By Elman Astanov
//22 avgust  2018 13:00:00


namespace Quark.Domain.Parametrs
{
    class RequredParametr : BaseParametr
    {
       //Constructors 
        public RequredParametr(string Name, string Type) : base(Name, Type)
        {
        }
       //Methods 
        public override string GetFullName()
        {
            return "${this.type} {this.name}";
        }
    }
}