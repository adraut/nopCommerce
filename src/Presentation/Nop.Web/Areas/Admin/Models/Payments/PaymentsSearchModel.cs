using Nop.Web.Framework.Models;

namespace Nop.Web.Areas.Admin.Models.Payments
{
    /// <summary>
    /// Represents a payments search model
    /// </summary>
    public partial class PaymentsSearchModel : BaseSearchModel
    {
        #region Ctor

        public PaymentsSearchModel()
        {
            PaymentsMethod = new PaymentMethodSearchModel();
            PaymentMethodRestriction = new PaymentMethodRestrictionModel();
        }

        #endregion

        #region Properties

        public PaymentMethodSearchModel PaymentsMethod { get; set; }

        public PaymentMethodRestrictionModel PaymentMethodRestriction { get; set; }

        #endregion
    }
}