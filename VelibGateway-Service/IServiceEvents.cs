using System.ServiceModel;

namespace VelibGateway_Service
{
  public interface IServiceEvents
  {
    [OperationContract(IsOneWay = true)]
    void Requested(string statioName, int result);

    [OperationContract(IsOneWay = true)]
    void RequestFinished();
  }
}
