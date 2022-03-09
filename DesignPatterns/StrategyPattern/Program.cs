using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comm Strategy
            CommunicateViaPhone communicateViaPhone = new CommunicateViaPhone();
            CommunicateViaEmail communicateViaEmail = new CommunicateViaEmail();
            CommunicateViaVideo communicateViaVideo = new CommunicateViaVideo();

            CommunicationService communicationService = new CommunicationService();
            // via phone
            communicationService.SetCommunicationMeans(communicateViaPhone);
            communicationService.Communicate("1234567");
            // via email
            communicationService.SetCommunicationMeans(communicateViaEmail);
            communicationService.Communicate("hi@me.com");
            #endregion

            #region SortStrategy
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();
            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort(); 
            #endregion

            Console.ReadKey();
        }
    }
}
 
