using System;
using System.Collections.Generic;
using System.Text;

namespace 虚幻帐号新2
{
    class persone
    {
        public string name { get; set }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
