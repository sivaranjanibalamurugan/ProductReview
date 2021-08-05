using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductReviewManagement
{
    public class ReviewManager
    {
        List<ProductReview> Product;

        public ReviewManager()
        {
            Product = new List<ProductReview>();
        }
        //UC1 adding 25 rows
        public List<ProductReview> AddReviews()
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
            return Product;
        }
        public void IterateMethod(List<ProductReview> products)
        {
            foreach (ProductReview p in products)
            {
                Console.WriteLine("Product Id:{0}\tUser Id:{1}\tRating:{2}\tReview:{3}\tIsLike:{4}", p.ProductId, p.userId, p.rating, p.review, p.isLike);
            }
        }
        //UC2-Retrive top3  rated product from the list
        public List<ProductReview> Top3RatedProduct()
        {
            var res = (from product in Product orderby product.rating descending select product).Take(3).ToList();
            Console.WriteLine("Top 3 products");
            return res;
        }
        //UC3-Retrive All record or product rating greater than 3 and product id is 1 or 4 or 9
        public List<ProductReview> RetrivalRecordRatingGreaterThan3()
        {
            List<ProductReview> res = null;
            res = (from product in Product where (product.rating > 3) && (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) select product).ToList();
            return res;
        }
        //UC4-Count of person gave review
        public string CountOfUser()
        {

            string result = "";
            var res = Product.GroupBy(p => p.ProductId).Select(x => new { productId = x.Key, count = x.Count() });
            foreach (var r in res)
            {
                Console.WriteLine("Product Id:{0}\tCount:{1}", r.productId, r.count);
                result += "" + r.productId + " " + r.count + " ";
            }
            return result;
        }
        //UC5-Retrive product Id from list
        public int[] RetriveOnlyProductId()
        {
            int[] res = (from product in Product select product.ProductId).ToArray();
            return res;
        }
        //UC6-skip top5  rated product from the list
        public List<ProductReview> SkipTop5Record()
        {
            var res = (from product in Product orderby product.rating descending select product).Skip(5).ToList();
            Console.WriteLine("Top 5 products");
            return res;
        }
        //UC7-Retrive product Id from list
        public int[] RetriveOnlyProductIdMethod()
        {
            int[] res = Product.Select(x => x.ProductId).ToArray();
            return res;
        }
    }
}
