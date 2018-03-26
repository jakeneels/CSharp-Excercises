using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FormsWithHttpPost.Models;
using System.Data.SqlClient;

namespace FormsWithHttpPost.DAL
{
    public class ReviewSqlDAL : IReviewDAL
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Squirrels;Integrated Security=True";



        public List<Review> GetAllReviews()
        {
            List<Review> reviews = new List<Review>();

            const string GetAllReviewsSQL = @"select  * from reviews";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand(GetAllReviewsSQL, conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var review = new Review();
                        review.Username = reader["username"].ToString();
                        review.Rating = int.Parse(reader["rating"].ToString());
                        review.Title = reader["review_title"].ToString();
                        review.Message = reader["review_text"].ToString();

                        reviews.Add(review);

                    }
                }
                catch (SqlException)
                {
                    throw;
                }

            }
            return reviews;
        }



        public bool SaveReview(Review newReview)
        {
            bool success = false;

            const string InsertReviewSQL = @"INSERT INTO reviews VALUES(@username, @rating, @review_title, @review_text, @getdate())";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand(InsertReviewSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("@username", newReview.Username));
                    cmd.Parameters.Add(new SqlParameter("@rating", newReview.Rating));
                    cmd.Parameters.Add(new SqlParameter("@review_title", newReview.Title));
                    cmd.Parameters.Add(new SqlParameter("@review_text", newReview.Message));
                    cmd.Parameters.Add(new SqlParameter("@review_date", newReview.ReviewDate));
                    trans.Commit();

                    cmd.ExecuteNonQuery();

                    success = true;
                }
                catch (SqlException) { }
                { trans.Dispose(); }
                
            }
            return success;
        }
    }
}