using System;

namespace Virtual_Ass_Teach
{
    internal class DLLImportAttribute : Attribute
    {
        private string v;

        public DLLImportAttribute(string v, string EntryPoint)
        {
            this.v = v;
            this.EntryPoint = EntryPoint;
        }

        public string EntryPoint { get; set; }
    }
}