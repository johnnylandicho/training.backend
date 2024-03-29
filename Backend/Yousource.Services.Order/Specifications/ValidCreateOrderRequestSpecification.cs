﻿// <auto-generated />

namespace Yousource.Services.Order.Specifications
{
    using System.Collections.Generic;
    using Yousource.Infrastructure.Messages.Orders.Requests;
    using Yousource.Infrastructure.Specifications;

    public class ValidCreateOrderRequestSpecification : Specification<CreateOrderRequest>
    {
        public override bool IsSatisfiedBy(CreateOrderRequest entity, ref ICollection<string> errors)
        {
            bool error = true;

            if (entity.CustomerName  == null)
            {
                errors.Add("Customer name field cannot be empty");
                error = false;
            }

            if (entity.CustomerEmail == null)
            {
                errors.Add("Customer email field cannot be empty");
                error = false;
            }

            if (entity.RecipientName == null)
            {
                errors.Add("Recipient name cannot be empty");
                error = false;
            }

            if (entity.RecipientEmail == null)
            {
                errors.Add("Recipient email cannot be empty");
                error = false;
            }

            if (entity.StoreName == null)
            {
                errors.Add("Store name cannot be empty");
                error = false;
            }

            if (entity.VoucherPrice.ToString() == null)
            {
                errors.Add("Price cannot be empty");
                error = false;
            }

            else
            {
                error = true;
            }
            return error;
        }
    }
}
