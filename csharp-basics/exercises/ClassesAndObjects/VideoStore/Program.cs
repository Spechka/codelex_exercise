using System;

namespace VideoStore
{

    class Program
    {
        private static VideoStore _store;

        public static void Main(string[] args)
        {
            _store = new VideoStore();

            while (true)
            {
                Console.WriteLine("\nChoose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("Choose 5 to get rating");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    case 5:
                        RecieveRating();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            _store.ListVideos();
        }

        private static void FillVideoStore()
        {
            _store.AddVideo("Metal Gear");
            _store.AddVideo("Solid 2");
            _store.AddVideo("Sons Of Liberty");
        }

        private static void RentVideo()
        {
            var title = Console.ReadLine();
            _store.CheckOut(title);

        }

        private static void ReturnVideo()
        {
            var title = Console.ReadLine();
            _store.ReturnVideo(title);
        }

        private static void RecieveRating()
        {
            var title = Console.ReadLine();
            _store.RecieveRating(title, double.Parse(Console.ReadLine()));
        }
    }
}
