using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using DotNetify;
using DotNetify.Routing;
using DotNetify.Security;

namespace cbaweb
{
   [Authorize]
   public class Dashboard : BaseVM, IRoutable
   {
      private IDisposable _subscription;

      public class Activity
      {
         public string PersonName { get; set; }
         public Route Route { get; set; }
         public string Status { get; set; }
      }

      public RoutingState RoutingState { get; set; }


      public Dashboard(ILookupService liveDataService)
      {

         // Regulate data update interval to no less than every 200 msecs.
         _subscription = Observable
            .Interval(TimeSpan.FromMilliseconds(200))
            .StartWith(0)
            .Subscribe(_ => PushUpdates());
      }

      public override void Dispose()
      {
         _subscription?.Dispose();
         base.Dispose();
      }
   }
}
