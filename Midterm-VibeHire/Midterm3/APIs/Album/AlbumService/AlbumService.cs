using System.Collections.Concurrent;
using Grpc.Core;
using static System.Reflection.Metadata.BlobBuilder;

namespace AlbumService
{
    public class AlbumService : Album.AlbumBase
    {
        public static readonly ConcurrentDictionary<string, AlbumResponse> _albums = new();

        public override Task<AddAlbumResponse> AddAlbum(AddAlbumRequest response, ServerCallContext context)
        {
            System.Diagnostics.Debug.WriteLine("ADDALBUM");
            var albumID = Guid.NewGuid().ToString();

            var album = new AlbumResponse
            {
                AlbumId = albumID,
                Title = response.Title,
                Artist = response.Artist,
                Genre = response.Genre,
                Year = response.Year,
                Available = response.Available
            };

            if (_albums.TryAdd(albumID, album))
            {
                return Task.FromResult(new AddAlbumResponse { AlbumId = albumID });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to create a new album."));
            }
        }
        public override Task<AlbumResponse> GetAlbum(AlbumRequest request, ServerCallContext context)
        {
            if (_albums.TryGetValue(request.AlbumId, out var album))
            {
                return Task.FromResult(album);
            }
            else
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Album not found for the ID that was provided: {request.AlbumId}"));
            }
        }
        public override Task<UpdateAlbumResponse> UpdateAlbum(UpdateAlbumRequest request, ServerCallContext context)
        {
            var album = new AlbumResponse
            {
                AlbumId = request.AlbumId,
                Title = request.Title,
                Artist = request.Artist,
                Genre = request.Genre,
                Year = request.Year,
                Available = request.Available
            };
            if (_albums.TryUpdate(request.AlbumId, album, album))
            {
                return Task.FromResult(new UpdateAlbumResponse { AlbumId = request.AlbumId });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to update book"));
            }
        }
        public override Task<DeleteAlbumResponse> DeleteAlbum(DeleteAlbumRequest request, ServerCallContext context)
        {
            var album = new AlbumResponse();
            if (_albums.TryRemove(request.AlbumId, out album)) 
            {
                return Task.FromResult(new DeleteAlbumResponse { AlbumId = request.AlbumId });
            }
            else
            {
                throw new RpcException(new Status(StatusCode.Internal, "Failed to delete album."));
            }
        }
        public override Task<ListAlbumsResponse> ListAlbums(ListAlbumsRequest request, ServerCallContext context)
        {
            System.Diagnostics.Debug.WriteLine("LISTALBUMS");
            foreach (var album in _albums.Values)
            {
                Console.WriteLine(album.Title);
            }
            return Task.FromResult(new ListAlbumsResponse());
        }
    }
}
