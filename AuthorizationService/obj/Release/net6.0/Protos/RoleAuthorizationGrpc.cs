// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/roleAuthorization.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AuthorizationManagement.AuthorizationService.Protos {
  public static partial class RoleAuthorization
  {
    static readonly string __ServiceName = "RoleAuthorization.RoleAuthorization";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesRequest> __Marshaller_RoleAuthorization_AuthorizeRolesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesResponse> __Marshaller_RoleAuthorization_AuthorizeRolesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesRequest, global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesResponse> __Method_AuthorizeRoles = new grpc::Method<global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesRequest, global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuthorizeRoles",
        __Marshaller_RoleAuthorization_AuthorizeRolesRequest,
        __Marshaller_RoleAuthorization_AuthorizeRolesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AuthorizationManagement.AuthorizationService.Protos.RoleAuthorizationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RoleAuthorization</summary>
    [grpc::BindServiceMethod(typeof(RoleAuthorization), "BindService")]
    public abstract partial class RoleAuthorizationBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesResponse> AuthorizeRoles(global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(RoleAuthorizationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AuthorizeRoles, serviceImpl.AuthorizeRoles).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RoleAuthorizationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AuthorizeRoles, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesRequest, global::AuthorizationManagement.AuthorizationService.Protos.AuthorizeRolesResponse>(serviceImpl.AuthorizeRoles));
    }

  }
}
#endregion
