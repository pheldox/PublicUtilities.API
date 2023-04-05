using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery: IRequest<List<OrdersVm>>
    {

       public string UserName { get; set; }

        public GetOrdersListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
    
}
