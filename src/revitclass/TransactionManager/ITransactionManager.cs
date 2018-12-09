using System;

namespace RevitAddin7.TransactionManager
{
    public interface ITransactionManager : IDisposable
    {
        void NewTranaction();
    }
}
