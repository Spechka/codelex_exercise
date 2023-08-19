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
            _isAvailable = true;
            _ratings = new List<double>();
        }

        public string Title { get; set; }

        private bool _isAvailable;

        public double AvarageRating => _ratings.Any() ? _ratings.Average() : 0;

        public void BeingCheckedOut () 
        {
            _isAvailable = false;
        }

        public void BeingReturned ()
        {
            _isAvailable = true;
        }

        public void RecieveRating (double rating)
        {
            _ratings.Add (rating);
        }

        public override string ToString()
        {
            return $"{Title}, rating: {AvarageRating}, Is avalable: {_isAvailable}";
        }
    }
}
