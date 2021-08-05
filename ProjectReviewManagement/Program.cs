using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            ReviewManager review = new ReviewManager();
            List<ProductReview> list = review.AddReviews();
            review.CreateDataTable(list);

        }
    }
}
