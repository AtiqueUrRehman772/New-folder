﻿using System;
using System.Collections.Generic;

namespace Inspire.Erp.Domain.Entities
{
    public partial class CostCenterMaster
    {
        public int? CostCenterMasterCostCenterId { get; set; }
        public string CostCenterMasterCostCenterName { get; set; }
        public bool? CostCenterMasterCostCenterStatus { get; set; }
        public bool? CostCenterMasterCostCenterIsSystem { get; set; }
        public int? CostCenterMasterCostCenterSortOrder { get; set; }
        public bool? CostCenterMasterCostCenterDelStatus { get; set; }
    }
}
