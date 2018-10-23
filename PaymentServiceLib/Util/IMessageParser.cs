using PaymentServiceLib.Model.Request;
using PaymentServiceLib.Model.Response;

namespace PaymentServiceLib.Util
{
    public interface IMessageParser
    {
        TerminalBaseResponse StringToEFTResponse(string msg);
        TerminalBaseResponse XMLStringToEFTResponse(string msg);
        string EFTRequestToString(TerminalBaseRequest eftRequest);
        string EFTRequestToXMLString(TerminalBaseRequest eftRequest);
    }
}
