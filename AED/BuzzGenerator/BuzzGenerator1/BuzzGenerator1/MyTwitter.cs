using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.Windows.Forms;

namespace BuzzGenerator1
{
    class MyTwitter
    {
        private int initialRetweets = 0;
        private int initialMentions = 0;
        private int initialFollowRequests = 0;

        public int Retweets = 0;
        public int Mentions = 0;
        public int FollowRequests = 0;

        private string consumerKey = "bWDpCLO2mIByqMYoaRh2Cg";
        private string consumerSecret = "X4veUKVWhB09wipWhVpaVhXvLDHqzIjnOLOGXxiY8Y";
        private string accessToken = "25963011-QuJkeaEcXqB92bhMxoIJHKBLFHP1rPZysu6K68IqZ";
        private string accessTokenSecret = "pY0TXRW8aIUSDfSUpJAzsQ2s2Oay2A0HBdiaK1Z8";

        public TwitterService service;
        
        
        public MyTwitter()
        {
            service = new TwitterService(consumerKey, consumerSecret);
            service.AuthenticateWith(accessToken, accessTokenSecret);
            
        }

        //service.AuthenticateWith(accessToken, accessTokenSecret);

        public void SetInitialCounters()
        {
            FollowRequests = 3;
            Mentions = 2;
            Retweets = 1;
        }

        public void SendTweet(String status)
        { 
        var tweetoptions = new SendTweetOptions();
        tweetoptions.Status = status;

        MessageBox.Show(status);

        service.SendTweet(tweetoptions);
        //service.SendTweet(tweetoptions);
        
        }

    }
}
