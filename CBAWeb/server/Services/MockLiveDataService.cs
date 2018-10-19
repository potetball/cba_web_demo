using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;

namespace cbaweb
{
   public interface ILiveDataService
   {
   }

   public class Activity
   {
      public int Id { get; set; }
      public string PersonName { get; set; }
      public string Status { get; set; }
   }

   public class MockLiveDataService : ILiveDataService
   {
      private readonly Random _random = new Random();


      public MockLiveDataService(IEmployeeService employeeService)
      {

      }
      
      private EmployeeModel GetRandomEmployee(IEmployeeService employeeService) 
      {
         EmployeeModel record;
         while ((record = employeeService.GetById(_random.Next(1, 20))) == null );
         return record;
      }
   }
}
