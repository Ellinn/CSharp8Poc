using System;
namespace Infrastructure
{
    public class Result<T, E>
    {
        public bool IsOk { get; }
        public bool IsError { get; }
        public T ResultValue { get; }
        public E ErrorValue { get; }

        public Result(T data)
        {
            IsOk = true;
            IsError = false;
            ResultValue = data;
        }
        public Result(E data)
        {
            IsOk = false;
            IsError = true;
            ErrorValue = data;
        }
    }
}
