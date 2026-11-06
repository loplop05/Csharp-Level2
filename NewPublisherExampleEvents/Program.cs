using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPublisherExampleEvents
{

    public class NewsArticle
    {
        public string Title { get;  }
        public string Content { get;  }

        public NewsArticle(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }

    }


    public class NewsPublisher
    {
        public event EventHandler<NewsArticle> NewNewsPublished;

        public void PublishNews(string Title, string Content)
        {
            var Article = new NewsArticle(Title, Content);

            OnNewNewsPublished(Article);
        }

        protected virtual void OnNewNewsPublished(NewsArticle article)
        {
            NewNewsPublished?.Invoke(this, article);
        }






    }

    public class NewsSubsucriber
    {

        public string Name { get; }

        public NewsSubsucriber(string name)
        {
            this.Name = name;
        }

        public void Subscribe(NewsPublisher publisher)
        {
            publisher.NewNewsPublished += HandleNewNews;
        }
        public void UnSubscribe(NewsPublisher publisher)
        {
            publisher.NewNewsPublished -= HandleNewNews;
        }

        public void HandleNewNews(object sender , NewsArticle Article)
        {
            Console.WriteLine($"{Name} received a new news article:");
            Console.WriteLine($"Title: {Article.Title}");
            Console.WriteLine($"Content: {Article.Content}");
            Console.WriteLine();
        }
    }






    public class Program
    {
        static void Main(string[] args)
        {

            NewsPublisher publisher = new NewsPublisher();
            NewsSubsucriber subsucriber1 = new NewsSubsucriber("Subscriber 1");

            subsucriber1.Subscribe(publisher);


        
            NewsSubsucriber subsucriber2 = new NewsSubsucriber("Subscriber 2");

            subsucriber2.Subscribe(publisher);

            publisher.PublishNews("Breaking News", "There is A Tragedy happened");


            subsucriber2.UnSubscribe(publisher);


            publisher.PublishNews("Urgent News", "There is A Fish in the sea");







        }
    }
}
