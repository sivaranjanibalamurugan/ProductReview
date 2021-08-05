using System;

namespace ProductReviewManagement
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            ReviewManager review = new ReviewManager();
            review.AddReviews();
           // review.Top3RatedProduct();
           // review.IterateMethod(review.RetrivalRecordRatingGreaterThan3());
            //review.RetriveOnlyProductId();
            review.SkipTop5Record();
              review.CountOfUser();
        }
    }
}
