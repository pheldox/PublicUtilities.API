using AutoMapper;
using EventBus.Messages.Events;
using PublicUtitilities.DomainClasses.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PublicUtitilities.DomainClasses.Mapper
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<CartCheckout, CartCheckoutEvent>().ReverseMap();
        }
    }
}
