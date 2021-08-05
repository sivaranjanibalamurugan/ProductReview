using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewTest
{
    [TestClass]
    public class UnitTest1
    {
        ReviewManager review;
        [TestInitialize]
        public void TestSetUp()
        {
            review = new ReviewManager();
            List<ProductReview> list = review.AddReviews();
        }
        [TestMethod]
        //UC2-Retrive top3  rated product from the list
        public void Top3BYRatingTest()
        {
            List<ProductReview> expected = new List<ProductReview> { new ProductReview() { ProductId = 8, userId = 67, rating = 20, review = "good", isLike = true }, new ProductReview() { ProductId = 7, userId = 6, rating = 19, review = "good", isLike = true }, new ProductReview() { ProductId = 8, userId = 9, rating = 18, review = "good", isLike = true } };
            List<ProductReview> actual = review.Top3RatedProduct();
            expected.Equals(actual);
        }
        [TestMethod]
        //UC3-Retrive all products data where the rating greater than 3 and product id 1,4 or 9
        public void AllRecordRetrivalTest()
        {
            List<ProductReview> expected = new List<ProductReview> { new ProductReview() { ProductId = 1, userId = 3, rating = 10, review = "Average", isLike = true },new ProductReview() { ProductId = 4, userId = 11, rating = 6, review = "bad", isLike = false }, new ProductReview() { ProductId = 9, userId = 8, rating = 8, review = "Average", isLike = true }, new ProductReview() { ProductId = 1, userId = 9, rating = 13, review = "good", isLike = true }, new ProductReview() { ProductId = 9, userId = 2, rating = 5, review = "bad", isLike = false }, new ProductReview() { ProductId = 9, userId = 10, rating = 5, review = "bad", isLike = false } };
            List<ProductReview> actual = review.RetrivalRecordRatingGreaterThan3();
            expected.Equals(actual);
        }
       
    }
}
