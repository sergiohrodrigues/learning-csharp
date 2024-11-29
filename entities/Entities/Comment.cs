namespace entities.Entities
{
    internal class Comment
    {
        public String Text { get; set; }

        public Comment()
        {

        }

        public Comment(String text)
        {
            Text = text; 
        }
    }
}
