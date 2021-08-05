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
        //UC4-Count of person gave review
        public void CountOfUserReviewAProduct()
        {
            string expected = "8 3 1 5 6 9 10 4 7 2";
            string actual = review.CountOfUser();
            Assert.AreEqual(expected, actual);
        }
        //UC5- Retrive product id
        public void RetriveProductId()
        {
            string expected = "1 7 3 8 2 6 1 8 5 4 10 3 9 2 7 1 9 4 6 2 8 3 5 6 9 ";
            int[] list = review.RetriveOnlyProductId();
            string actual = "";
            foreach (var l in list)
            {
                actual += "" + l + " ";
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //Uc6-Skiping top5 records
        public void SkipTop5Record()
        {
            //Assign
            List<ProductReview> Product = new List<ProductReview>();
            Product.Add(new ProductReview() { ProductId = 1, userId = 3, rating = 10, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 7, userId = 6, rating = 3, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 3, userId = 11, rating = 5, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 6, userId = 5, rating = 7, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 1, userId = 9, rating = 2, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 8, userId = 2, rating = 0, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 5, userId = 6, rating = 7, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 4, userId = 11, rating = 6, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 10, userId = 78, rating = 4, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 3, userId = 23, rating = 9, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 9, userId = 8, rating = 8, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 1, userId = 9, rating = 13, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 9, userId = 2, rating = 5, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 4, userId = 5, rating = 3, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 6, userId = 1, rating = 9, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 2, userId = 5, rating = 1, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 3, userId = 9, rating = 13, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 5, userId = 1, rating = 4, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 6, userId = 5, rating = 9, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 9, userId = 10, rating = 5, review = "bad", isLike = false });
            //Act
            List<ProductReview> actual = review.RetrivalRecordRatingGreaterThan3();
            Product.Equals(actual);

        }

    }
}
