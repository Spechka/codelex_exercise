using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videos;

        public VideoStore()
        {
            _videos = new List<Video>();
        }

        public void AddVideo(string title)
        {
            _videos.Add(new Video(title));
        }

        public void CheckOut (string title)
        {
            var video = GetVideoByTitle(title);
            if (video != null)
            {
                video.BeingCheckedOut();
            }
        }

        public void ReturnVideo (string title)
        {
            var video = GetVideoByTitle(title);

            if (video != null)
            {
                video.BeingReturned();
            }
        }

        public void RecieveRating (string title, double rating)
        {
            var video = GetVideoByTitle(title);
            if (video != null)
            {
                video.RecieveRating(rating);
            }
        }

        public void ListVideos ()
        {
            for (int i = 0; i < _videos.Count; i++)
            {
                var video = _videos[i];
                Console.WriteLine(video);
            }
        }

        public Video GetVideoByTitle (string title)
        {

            for (int i = 0; i < _videos.Count; i++)
            {
                if (_videos[i].Title == title)
                {
                    return _videos[i];
                }
            }
            return null;
        }
    }
}
