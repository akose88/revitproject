using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;

namespace RevitAddin7.TransactionManager
{
    public class TransactionManager : ITransactionManager
    {
        private Document Document { get; }
        private TransactionGroup TransactionGroup { get; }
        private List<Transaction> Transactions { get; }
        private Transaction Transaction => Transactions[TransactionIndex];
        private int TransactionIndex { get; set; } = 0;

        private string TransactionName => Guid.NewGuid().ToString();

        public TransactionManager(Document document)
        {
            Document = document;

            TransactionGroup = new TransactionGroup(Document);
            TransactionGroup.Start();

            Transactions = new List<Transaction> { new Transaction(Document, TransactionName) };
            Transaction.Start();
        }

        public void NewTranaction()
        {
            Transactions.Add(new Transaction(Document, TransactionName));
            TransactionIndex++;
            Transaction.Start();
        }
        public void Dispose()
        {
            for (; TransactionIndex >= 0; TransactionIndex--)
            {
                Transaction.Commit();
                Transaction.Dispose();
            }

            TransactionGroup.Assimilate();
            TransactionGroup.Dispose();
        }
    }
}
