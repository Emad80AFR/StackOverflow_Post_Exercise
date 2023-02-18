namespace C_sharp.Exercises__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            post.Up_Vote();
            post.Up_Vote();
            post.Up_Vote();
            post.Up_Vote();
            post.Up_Vote();
            post.Up_Vote();

            post.Down_Vote();   
            post.Down_Vote();

            Console.WriteLine(post.CurrentVoteValue());

            Console.WriteLine(post);

            Console.ReadLine();
        }
    }
}