﻿using DPLRef.eCommerce.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPLRef.eCommerce.Accessors.Sales
{
    class TaxRateAccessor : AccessorBase, ITaxRateAccessor
    {
        public decimal Rate(Address address)
        {
            USATaxer.USATaxerLib taxer = new USATaxer.USATaxerLib();
            taxer.Init();
            return taxer.Rate(address.Postal);
        }
    }
}
