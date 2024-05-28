using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessorDemo
{
    public interface ICommand
    {
        void Execute();
        bool IsCompensabe { get; }
        void Compensate();
    }

    public interface ICommand<T>: ICommand
    {
        T? Reciever { get; set; }
    }

}
