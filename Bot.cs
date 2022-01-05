using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //this allows for the Task Type and async/await
using Tweetinvi; //this is what does the heavy lifting
namespace TwitterBotForm
{
    class Bot
    {
        private string _APIKey;
        private string _APISecret;
        private string _AccessToken;
        private string _AccessSecret;
        private TwitterClient _client;

        public Bot(string APIKey, string APISecret, string AccessToken, string AccessSecret)
        {
            this.APIKey = APIKey;
            this.APISecret = APISecret;
            this.AccessToken = AccessToken;
            this.AccessSecret = AccessSecret;
            _client = new TwitterClient(APIKey, APISecret, AccessToken, AccessSecret);
        }
        //properties --normally one would want to keep these keys very secure--
        public string APIKey
        {
            get { return _APIKey; }
            set { _APIKey = value; }
        }
        public string APISecret
        {
            get { return _APISecret; }
            set { _APISecret = value; }
        }
        public string AccessToken
        {
            get { return _AccessToken; }
            set { _AccessToken = value; }
        }
        public string AccessSecret
        {
            get { return _AccessSecret; }
            set { _AccessSecret = value; }
        }
        public TwitterClient Client
        {
            get { return _client; }
        }
        //helper methods
        //The library (TweetInvi) I'm using does most of the work
        //these methods are to mainly show I can write a class
        //and to make it more readable for my brain

        //connects bot through twitter API to gain access to certain endpoints
        public static async Task AuthenticateClient(TwitterClient userClient)
        {
            await userClient.Users.GetAuthenticatedUserAsync();
        }
        public async Task SendTweet(string str)
        {
            await AuthenticateClient(this._client);
            await _client.Tweets.PublishTweetAsync(str);
        }
    }
}
