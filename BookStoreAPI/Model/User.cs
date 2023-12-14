namespace BookStorageAPI.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Book> BorrowedBooks { get; set; }

        public User()
        {
            BorrowedBooks = new HashSet<Book>();
        }
    }
}
