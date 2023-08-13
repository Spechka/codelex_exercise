using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private List<double> _ratings;

        public Video(string title)
        {
            Title = title;
            IsAvailable = true;
            _ratings = new List<double>();
        }

        public string Title { get; set; }

        public bool IsAvailable { get; set; }

        public double AvarageRating => _ratings.Any() ? _ratings.Average() : 0;

        public void BeingCheckedOut () 
        {
            IsAvailable = false;
        }

        public void BeingReturned ()
        {
            IsAvailable = true;
        }

        public void RecieveRating (double rating)
        {
            _ratings.Add (rating);
        }

        public override string ToString()
        {
            return $"{Title}, rating: {AvarageRating}, Is avalable: {IsAvailable}";
        }
    }
}
