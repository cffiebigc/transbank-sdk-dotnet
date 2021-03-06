﻿using System;


namespace Transbank.Onepay.Exceptions
{
    public class TransactionCreateException : TransbankException
    {
        public TransactionCreateException() : base()
        {
        }

        public TransactionCreateException(int code, string message) 
            : base(code, message)
        {
        }

        public TransactionCreateException(int code, string message, 
            Exception innerException) : base(code, message, innerException)
        {
        }
    }
}
