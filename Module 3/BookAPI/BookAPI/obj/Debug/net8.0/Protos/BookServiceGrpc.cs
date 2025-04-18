// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/book_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace BookApi {
  /// <summary>
  /// BookService with required methods
  /// </summary>
  public static partial class BookService
  {
    static readonly string __ServiceName = "book.BookService";

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
    static readonly grpc::Marshaller<global::BookApi.AddBookRequest> __Marshaller_book_AddBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.AddBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookApi.AddBookResponse> __Marshaller_book_AddBookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.AddBookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookApi.BookRequest> __Marshaller_book_BookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.BookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookApi.BookResponse> __Marshaller_book_BookResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.BookResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookApi.UpdateBookRequest> __Marshaller_book_UpdateBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.UpdateBookRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookApi.Empty> __Marshaller_book_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::BookApi.DeleteBookRequest> __Marshaller_book_DeleteBookRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::BookApi.DeleteBookRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookApi.AddBookRequest, global::BookApi.AddBookResponse> __Method_AddBook = new grpc::Method<global::BookApi.AddBookRequest, global::BookApi.AddBookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddBook",
        __Marshaller_book_AddBookRequest,
        __Marshaller_book_AddBookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookApi.BookRequest, global::BookApi.BookResponse> __Method_GetBook = new grpc::Method<global::BookApi.BookRequest, global::BookApi.BookResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBook",
        __Marshaller_book_BookRequest,
        __Marshaller_book_BookResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookApi.UpdateBookRequest, global::BookApi.Empty> __Method_UpdateBook = new grpc::Method<global::BookApi.UpdateBookRequest, global::BookApi.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBook",
        __Marshaller_book_UpdateBookRequest,
        __Marshaller_book_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookApi.DeleteBookRequest, global::BookApi.Empty> __Method_DeleteBook = new grpc::Method<global::BookApi.DeleteBookRequest, global::BookApi.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBook",
        __Marshaller_book_DeleteBookRequest,
        __Marshaller_book_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::BookApi.Empty, global::BookApi.BookResponse> __Method_ListBooks = new grpc::Method<global::BookApi.Empty, global::BookApi.BookResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListBooks",
        __Marshaller_book_Empty,
        __Marshaller_book_BookResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::BookApi.BookServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BookService</summary>
    [grpc::BindServiceMethod(typeof(BookService), "BindService")]
    public abstract partial class BookServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookApi.AddBookResponse> AddBook(global::BookApi.AddBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookApi.BookResponse> GetBook(global::BookApi.BookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ERmpty?
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookApi.Empty> UpdateBook(global::BookApi.UpdateBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Empty?
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::BookApi.Empty> DeleteBook(global::BookApi.DeleteBookRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ListBooks(global::BookApi.Empty request, grpc::IServerStreamWriter<global::BookApi.BookResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BookServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddBook, serviceImpl.AddBook)
          .AddMethod(__Method_GetBook, serviceImpl.GetBook)
          .AddMethod(__Method_UpdateBook, serviceImpl.UpdateBook)
          .AddMethod(__Method_DeleteBook, serviceImpl.DeleteBook)
          .AddMethod(__Method_ListBooks, serviceImpl.ListBooks).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BookServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookApi.AddBookRequest, global::BookApi.AddBookResponse>(serviceImpl.AddBook));
      serviceBinder.AddMethod(__Method_GetBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookApi.BookRequest, global::BookApi.BookResponse>(serviceImpl.GetBook));
      serviceBinder.AddMethod(__Method_UpdateBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookApi.UpdateBookRequest, global::BookApi.Empty>(serviceImpl.UpdateBook));
      serviceBinder.AddMethod(__Method_DeleteBook, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::BookApi.DeleteBookRequest, global::BookApi.Empty>(serviceImpl.DeleteBook));
      serviceBinder.AddMethod(__Method_ListBooks, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::BookApi.Empty, global::BookApi.BookResponse>(serviceImpl.ListBooks));
    }

  }
}
#endregion
