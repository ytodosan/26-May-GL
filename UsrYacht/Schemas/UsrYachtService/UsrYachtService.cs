namespace Terrasoft.Configuration
{
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceModel.Activation;
    using Terrasoft.Core.DB;
    using Terrasoft.Web.Common;
    using System;
    using System.Web.SessionState;
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class YachtService : BaseService, IReadOnlySessionState
    {
        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]

        public decimal GetMaxPriceByDriveTypeId(string driveTypeId)
        {
            if (string.IsNullOrEmpty(driveTypeId))
            {
                return -1;
            }
            Select select = new Select(UserConnection)
                .Column(Func.Max("UsrPrice"))
                .From("UsrYachts")
                .Where("UsrDriveTypeId").IsEqual(Column.Parameter(new Guid(driveTypeId)))
                .And("UsrStatusId").IsEqual(Column.Parameter(new Guid("deb6883b-8530-467a-844c-f043ef6716f9"))) // 1. Operational
                as Select;
            decimal result = select.ExecuteScalar<decimal>();
            return result;
        }
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public string GetExample()
        {
            return "OK!";
        }

    }
}