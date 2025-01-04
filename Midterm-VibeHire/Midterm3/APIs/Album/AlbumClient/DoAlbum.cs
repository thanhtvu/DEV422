using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Grpc.Net.Client;
using System.Collections.Concurrent;

namespace AlbumClient
{
    public class DoAlbum
    {
        public static GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7202");
        public static Album.AlbumClient client = new Album.AlbumClient(channel);
        public static List<AlbumResponse> Albums = new List<AlbumResponse>();
        public async Task<AddAlbumResponse> AddAlbum(string title, string artist, string genre, int year)
        {
            var createResponse = await client.AddAlbumAsync(new AddAlbumRequest { Title = title, Artist = artist, Genre = genre, Year = year, Available = true });
            var album = new AlbumResponse
            {
                AlbumId = createResponse.AlbumId,
                Title = title,
                Artist = artist,
                Genre = genre,
                Year = year
            };
            Albums.Add(album);
            return createResponse;
        }

        public AlbumResponse GetAlbum(string albumId)
        {
            foreach (var album in Albums) 
            {
                if(album.AlbumId == albumId)
                {
                    return album;
                }
            }
            throw new Exception("Could not find album");
        }
        public void UpdateAlbum(string albumId, string title, string artist, string genre, int year, bool available)
        {
            //var createResponse = await client.UpdateAlbumAsync(new UpdateAlbumRequest { AlbumId = albumId, Title = title, Artist = artist, Genre = genre, Year = year, Available = available});
            var album = new AlbumResponse
            {
                AlbumId = albumId,
                Title = title,
                Artist = artist,
                Genre = genre,
                Year = year
            };
            AlbumResponse toRemove = GetAlbum(albumId);
            int index = Albums.IndexOf(toRemove);
            Albums.Remove(toRemove);
            Albums.Insert(index, album);
        }
        public async void DeleteAlbum(string albumId) 
        {
            var createResponse = await client.DeleteAlbumAsync(new DeleteAlbumRequest { AlbumId = albumId });
            AlbumResponse toRemove = GetAlbum(albumId);
            Albums.Remove(toRemove);
        }
        public List<AlbumResponse> ListAlbums()
        {
            List<AlbumResponse> result = new List<AlbumResponse>();
            foreach (var album in Albums)
            {
                 result.Add(album);
            }
            return result;
        }
    }
}
