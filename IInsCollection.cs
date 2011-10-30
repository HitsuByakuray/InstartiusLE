using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Instartius_Language_Extender
{
    public interface IInsCollection <T>
    {
        bool IsEmpty();

        void Contains(ref object obj);

        int Size();

        void Clear();

        T[] ToArray();

        string ToString();
    }
}
