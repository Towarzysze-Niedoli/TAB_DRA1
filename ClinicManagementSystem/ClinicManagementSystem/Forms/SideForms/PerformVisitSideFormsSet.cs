using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem.Forms.SideForms
{
    public class PerformVisitSideFormsSet
    {
        public VisitTextsForm VisitTextsForm { get; set; }
        public PhysicalForm PhysicalForm { get; set; }
        public OrderLabForm OrderLabForm { get; set; }

        public PerformVisitSideFormsSet(VisitTextsForm visitTextsForm, PhysicalForm physicalForm, OrderLabForm orderLabListForm)
        {
            VisitTextsForm = visitTextsForm;
            PhysicalForm = physicalForm;
            OrderLabForm = orderLabListForm;
        }

        public void SetDisabled()
        {
            VisitTextsForm.SetDisabled();
            PhysicalForm.SetDisabled();
            OrderLabForm.SetDisabled();
        }
    }
}
