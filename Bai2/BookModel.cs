using System;

namespace BookManagementSystem.Models
{
    public class BookModel
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }

        // Tính tổng giá trị tiền sách trong kho của đầu sách này
        public decimal TotalValue => Price * Quantity;
    }
}