namespace WinFormsApp1.Model
{
    public class Post
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string Title { get; set; } = string.Empty;

        /// <inheritdoc/>
        public string Body { get; set; } = string.Empty;
    }
}