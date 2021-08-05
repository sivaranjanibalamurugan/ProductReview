using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductReviewManagement
{
    class ReviewManager
    {
        List<ProductReview> Product;

        public ReviewManager()
        {
            Product = new List<ProductReview>();
        }
        //UC1 adding 25 rows
        public void AddReviews()
        {
            Product.Add(new ProductReview() { ProductId = 8, userId = 3, rating = 10, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 3, userId = 6, rating = 3, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 1, userId = 11, rating = 5, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 3, userId = 67, rating = 20, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 5, userId = 3, rating = 14, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 6, userId = 5, rating = 7, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 8, userId = 9, rating = 2, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 9, userId = 2, rating = 0, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 10, userId = 6, rating = 7, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 5, userId = 11, rating = 6, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 10, userId = 78, rating = 4, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 4, userId = 23, rating = 9, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 7, userId = 8, rating = 8, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 9, userId = 1, rating = 17, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 2, userId = 6, rating = 19, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 1, userId = 9, rating = 13, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 9, userId = 2, rating = 5, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 4, userId = 5, rating = 3, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 6, userId = 1, rating = 9, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 2, userId = 5, rating = 1, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 8, userId = 9, rating = 18, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 3, userId = 9, rating = 13, review = "good", isLike = true });
            Product.Add(new ProductReview() { ProductId = 5, userId = 1, rating = 4, review = "bad", isLike = false });
            Product.Add(new ProductReview() { ProductId = 6, userId = 5, rating = 9, review = "Average", isLike = true });
            Product.Add(new ProductReview() { ProductId = 9, userId = 10, rating = 5, review = "bad", isLike = false });
            IterateMethod(Product);
        }
        public void IterateMethod(List<ProductReview> products)
        {
            foreach (ProductReview p in products)
            {
                Console.WriteLine("Product Id:{0}\tUser Id:{1}\tRating:{2}\tReview:{3}\tIsLike:{4}", p.ProductId, p.userId, p.rating, p.review, p.isLike);
            }
        }
        //UC2-Retrive top3  rated product from the list
        public void Top3RatedProduct()
        {
            var res = (from product in Product orderby product.rating descending select product).Take(3).ToList();
            Console.WriteLine("Top 3 products");
            IterateMethod(res);
        }
    }
}
