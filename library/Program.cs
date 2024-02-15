//Written by Software Engineer @Devflovv
using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace PhotoAlbumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                
                Console.Write("\nEnter the album ID or type 'quit' to exit: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break; 
                }

                int albumId;
                if (!int.TryParse(input, out albumId) || albumId <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive integer for the album ID.");
                    continue; 
                }

                // URL for fetching photos within the specified album
                string fetch_photos = $"https://jsonplaceholder.typicode.com/photos?albumId={albumId}";

                
                using (var client = new HttpClient())
                {
                    //Async Request
                    HttpResponseMessage res = client.GetAsync(fetch_photos).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        string json = res.Content.ReadAsStringAsync().Result;
                    
                        var photos = JsonConvert.DeserializeObject<Photo[]>(json);

                        if (photos.Length == 0)
                        {
                            Console.WriteLine($"No photos found in album ID {albumId}.");
                        }
                        else
                        {
                            
                            Console.WriteLine($"Photo-Album {albumId}:");
                            foreach (var photo in photos)
                            {
                                Console.WriteLine($"[{photo.Id}] {photo.Title}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Failed to fetch photos. Status code: {res.StatusCode}");
                    }
                }
            }
        }
    }

 
    public class Photo
    {
        public int AlbumId { get; }
        public int Id { get; }
        public string Title { get; }
        public string Url { get; }
        public string ThumbnailUrl { get; }
        public Photo(int albumId, int id, string title, string url, string thumbnailUrl)
        {
            AlbumId = albumId;
            Id = id;
            Title = title;
            Url = url;
            ThumbnailUrl = thumbnailUrl;
        }
    }
}
