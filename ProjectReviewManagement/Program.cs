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
            review.IterateMethod(review.Top3RatedProduct());
            review.IterateMethod(review.RetrivalRecordRatingGreaterThan3());
            review.IterateMethod(review.SkipTop5Record());
            review.RetrivingBasedOnReview("good");
            review.CountOfUser();

        }
    }
}
