﻿using System;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;

namespace SvcFabricDinnerDemo.KitchenActor.Interfaces
{
    public class KitchenActorProxy
    {
        public static Uri ServiceUrl { get; } = new Uri("fabric:/SvcFabricDinnerDemo/KitchenActorService");


        public IKitchenActor CreateActor(Guid orderId)
        {
            var actorId = new ActorId(orderId);
            return ActorProxy.Create<IKitchenActor>(actorId, ServiceUrl);
        }
    }
}