// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/queryemployees.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ScholarPortal.Protos.Employees {
  public static partial class QueryEmployeesService
  {
    static readonly string __ServiceName = "QueryEmployees.QueryEmployeesService";

    static readonly grpc::Marshaller<global::ScholarPortal.Protos.Employees.EmployeeRequest> __Marshaller_QueryEmployees_EmployeeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ScholarPortal.Protos.Employees.EmployeeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ScholarPortal.Protos.Employees.EmployeeIdModel> __Marshaller_QueryEmployees_EmployeeIdModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ScholarPortal.Protos.Employees.EmployeeIdModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ScholarPortal.Protos.Employees.EmployeeModel> __Marshaller_QueryEmployees_EmployeeModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ScholarPortal.Protos.Employees.EmployeeModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ScholarPortal.Protos.Employees.EmployeesRequest> __Marshaller_QueryEmployees_EmployeesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ScholarPortal.Protos.Employees.EmployeesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ScholarPortal.Protos.Employees.EmployeeListModel> __Marshaller_QueryEmployees_EmployeeListModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ScholarPortal.Protos.Employees.EmployeeListModel.Parser.ParseFrom);

    static readonly grpc::Method<global::ScholarPortal.Protos.Employees.EmployeeRequest, global::ScholarPortal.Protos.Employees.EmployeeIdModel> __Method_IsValidEmployee = new grpc::Method<global::ScholarPortal.Protos.Employees.EmployeeRequest, global::ScholarPortal.Protos.Employees.EmployeeIdModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsValidEmployee",
        __Marshaller_QueryEmployees_EmployeeRequest,
        __Marshaller_QueryEmployees_EmployeeIdModel);

    static readonly grpc::Method<global::ScholarPortal.Protos.Employees.EmployeeRequest, global::ScholarPortal.Protos.Employees.EmployeeModel> __Method_GetEmployee = new grpc::Method<global::ScholarPortal.Protos.Employees.EmployeeRequest, global::ScholarPortal.Protos.Employees.EmployeeModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetEmployee",
        __Marshaller_QueryEmployees_EmployeeRequest,
        __Marshaller_QueryEmployees_EmployeeModel);

    static readonly grpc::Method<global::ScholarPortal.Protos.Employees.EmployeesRequest, global::ScholarPortal.Protos.Employees.EmployeeListModel> __Method_GetEmployees = new grpc::Method<global::ScholarPortal.Protos.Employees.EmployeesRequest, global::ScholarPortal.Protos.Employees.EmployeeListModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetEmployees",
        __Marshaller_QueryEmployees_EmployeesRequest,
        __Marshaller_QueryEmployees_EmployeeListModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ScholarPortal.Protos.Employees.QueryemployeesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of QueryEmployeesService</summary>
    [grpc::BindServiceMethod(typeof(QueryEmployeesService), "BindService")]
    public abstract partial class QueryEmployeesServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ScholarPortal.Protos.Employees.EmployeeIdModel> IsValidEmployee(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ScholarPortal.Protos.Employees.EmployeeModel> GetEmployee(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ScholarPortal.Protos.Employees.EmployeeListModel> GetEmployees(global::ScholarPortal.Protos.Employees.EmployeesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for QueryEmployeesService</summary>
    public partial class QueryEmployeesServiceClient : grpc::ClientBase<QueryEmployeesServiceClient>
    {
      /// <summary>Creates a new client for QueryEmployeesService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public QueryEmployeesServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for QueryEmployeesService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public QueryEmployeesServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected QueryEmployeesServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected QueryEmployeesServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ScholarPortal.Protos.Employees.EmployeeIdModel IsValidEmployee(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IsValidEmployee(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ScholarPortal.Protos.Employees.EmployeeIdModel IsValidEmployee(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_IsValidEmployee, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ScholarPortal.Protos.Employees.EmployeeIdModel> IsValidEmployeeAsync(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return IsValidEmployeeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ScholarPortal.Protos.Employees.EmployeeIdModel> IsValidEmployeeAsync(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_IsValidEmployee, null, options, request);
      }
      public virtual global::ScholarPortal.Protos.Employees.EmployeeModel GetEmployee(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmployee(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ScholarPortal.Protos.Employees.EmployeeModel GetEmployee(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetEmployee, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ScholarPortal.Protos.Employees.EmployeeModel> GetEmployeeAsync(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmployeeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ScholarPortal.Protos.Employees.EmployeeModel> GetEmployeeAsync(global::ScholarPortal.Protos.Employees.EmployeeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetEmployee, null, options, request);
      }
      public virtual global::ScholarPortal.Protos.Employees.EmployeeListModel GetEmployees(global::ScholarPortal.Protos.Employees.EmployeesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmployees(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ScholarPortal.Protos.Employees.EmployeeListModel GetEmployees(global::ScholarPortal.Protos.Employees.EmployeesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetEmployees, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ScholarPortal.Protos.Employees.EmployeeListModel> GetEmployeesAsync(global::ScholarPortal.Protos.Employees.EmployeesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetEmployeesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ScholarPortal.Protos.Employees.EmployeeListModel> GetEmployeesAsync(global::ScholarPortal.Protos.Employees.EmployeesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetEmployees, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override QueryEmployeesServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new QueryEmployeesServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(QueryEmployeesServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_IsValidEmployee, serviceImpl.IsValidEmployee)
          .AddMethod(__Method_GetEmployee, serviceImpl.GetEmployee)
          .AddMethod(__Method_GetEmployees, serviceImpl.GetEmployees).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, QueryEmployeesServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_IsValidEmployee, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ScholarPortal.Protos.Employees.EmployeeRequest, global::ScholarPortal.Protos.Employees.EmployeeIdModel>(serviceImpl.IsValidEmployee));
      serviceBinder.AddMethod(__Method_GetEmployee, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ScholarPortal.Protos.Employees.EmployeeRequest, global::ScholarPortal.Protos.Employees.EmployeeModel>(serviceImpl.GetEmployee));
      serviceBinder.AddMethod(__Method_GetEmployees, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ScholarPortal.Protos.Employees.EmployeesRequest, global::ScholarPortal.Protos.Employees.EmployeeListModel>(serviceImpl.GetEmployees));
    }

  }
}
#endregion
