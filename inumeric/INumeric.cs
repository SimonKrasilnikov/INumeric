using System;

namespace inumeric
{
    public interface INumeric<T> where T: INumeric<T>
    {
        T Add(T a);
    }


}