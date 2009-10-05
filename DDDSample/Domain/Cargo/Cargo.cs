﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDSample.Domain.Cargo
{
   /// <summary>
   /// Cargo.
   /// </summary>
   public class Cargo : IEntity<Cargo>
   {
      /// <summary>
      /// Gets the tracking id of this cargo.
      /// </summary>
      public virtual TrackingId TrackingId { get; protected set; }

      /// <summary>
      /// Gets the route specification of this cargo.
      /// </summary>
      public virtual RouteSpecification RouteSpecification { get; protected set; }

      /// <summary>
      /// Creates new <see cref="Cargo"/> object with provided tracking id and route specification.
      /// </summary>
      /// <param name="trackingId">Tracking id of this cargo.</param>
      /// <param name="routeSpecification">Route specification.</param>
      public Cargo(TrackingId trackingId, RouteSpecification routeSpecification)
      {
         TrackingId = trackingId;
         RouteSpecification = routeSpecification;
      }

      /// <summary>
      /// Specifies a new route for this cargo.
      /// </summary>
      /// <param name="routeSpecification">Route specification.</param>
      public virtual void SpecifyNewRoute(RouteSpecification routeSpecification)
      {
         RouteSpecification = routeSpecification;
      }

      public virtual bool HasSameIdentityAs(Cargo other)
      {
         throw new NotImplementedException();
      }

      /// <summary>
      /// For NHibernate.
      /// </summary>
      protected Cargo()
      {         
      }      
   }
}