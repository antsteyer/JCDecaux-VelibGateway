using System.ServiceModel;

namespace VelibGateway_Service
{
  public interface IServiceEvents
  {
    [OperationContract(IsOneWay = true)]
    void Requested(string stationName, int result);

    [OperationContract(IsOneWay = true)]
    void RequestFinished();
  }
}
