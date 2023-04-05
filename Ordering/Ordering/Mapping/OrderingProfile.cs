using AutoMapper;
using EventBus.Messages.Events;
using Ordering.API.Features.Orders.Commands.CheckoutOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Mapping
{
    public class OrderingProfile : Profile
    {
        protected OrderingProfile()
        {
            CreateMap<CheckoutOrderCommand, CartCheckoutEvent>().ReverseMap();
        }
    }
}
