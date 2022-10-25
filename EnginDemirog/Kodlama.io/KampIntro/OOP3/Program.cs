using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager esnafCreditManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { smsLoggerService, fileLoggerService };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(esnafCreditManager,
                new List<ILoggerService> { databaseLoggerService, smsLoggerService });
            applicationManager.Apply(esnafCreditManager, loggers);

            List<ICreditManager> credits = new List<ICreditManager>()
                { personalFinanceCreditManager, transportCreditManager };

            //applicationManager.CreditInformation(credits);
        }
    }
}