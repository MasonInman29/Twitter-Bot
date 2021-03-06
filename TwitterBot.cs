using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterBotForm
{
    public partial class TwitterBot : Form
    {
        //keys have been changed since posting for security purposes
        string APIKey = "PUTAPIKEYHERE";
        string APISecret = "PUTAPISECRETTOKENHERE";
        string AccessToken = "PUTACCESSTOKENHERE";
        string AccessSecret = "PUTACCESSSECRETTOKENHERE";

        Bot bot = new Bot(APIKey, APISecret, AccessToken, AccessSecret);
        string[] quotes = {
                            "Love For All, Hatred For None. – Khalifatul Masih III",
                            "Change the world by being yourself. – Amy Poehler",
                            "Every moment is a fresh beginning. – T.S Eliot",
                            "Never regret anything that made you smile. – Mark Twain",
                            "Die with memories, not dreams. – Unknown",
                            "Aspire to inspire before we expire. – Unknown",
                            "Everything you can imagine is real. – Pablo Picasso",
                            "Simplicity is the ultimate sophistication. – Leonardo da Vinci",
                            "Whatever you do, do it well. – Walt Disney",
                            "What we think, we become. – Buddha",
                            "All limitations are self-imposed. – Oliver Wendell Holmes",
                            "Tough times never last but tough people do. – Robert H. Schiuller",
                            "Problems are not stop signs, they are guidelines. – Robert H. Schiuller",
                            "One day the people that don’t even believe in you will tell everyone how they met you. – Johnny Depp",
                            "If I’m gonna tell a real story, I’m gonna start with my name. – Kendrick Lamar",
                            "If you tell the truth you don’t have to remember anything. – Mark Twain",
                            "Have enough courage to start and enough heart to finish. – Jessica N. S.Yourko",
                            "Hate comes from intimidation, love comes from appreciation. – Tyga",
                            "I could agree with you but then we’d both be wrong. – Harvey Specter",
                            "Oh, the things you can find, if you don’t stay behind. – Dr.Seuss",
                            "Determine your priorities and focus on them. – Eileen McDargh",
                            "Be so good they can’t ignore you. – Steve Martin",
                            "Dream as if you’ll live forever, live as if you’ll die today. – James Dean",
                            "Yesterday you said tomorrow. Just do it. – Nike",
                            "I don’t need it to be easy, I need it to be worth it. – Lil Wayne",
                            "Short Quote Doubt - Updated",
                            "Never let your emotions overpower your intelligence. – Drake",
                            "Nothing lasts forever but at least we got these memories. – J.Cole",
                            "Don’t you know your imperfections is a blessing? – Kendrick Lamar",
                            "Reality is wrong, dreams are for real. – Tupac",
                            "To live will be an awfully big adventure. – Peter Pan",
                            "Try to be a rainbow in someone’s cloud. – Maya Angelou",
                            "There is no substitute for hard work. – Thomas Edison",
                            "What consumes your mind controls your life- Unknown",
                            "Strive for greatness. – Lebron James",
                            "Wanting to be someone else is a waste of who you are. – Kurt Cobain",
                            "And still, I rise. – Maya Angelou",
                            "The time is always right to do what is right. – Martin Luther King Jr.",
                            "Let the beauty of what you love be what you do. – Rumi",
                            "May your choices reflect your hopes, not your fears. – Nelson Mandela",
                            "A happy soul is the best shield for a cruel world. – Atticus",
                            "White is not always light and black is not always dark. – Habeeb Akande",
                            "Life becomes easier when you learn to accept the apology you never got. – R.Brault",
                            "Happiness depends upon ourselves. – Aristotle",
                            "Turn your wounds into wisdom. – Oprah Winfrey",
                            "Change the game, don’t let the game change you. – Macklemore",
                            "It hurt because it mattered. – John Green",
                            "If the world was blind how many people would you impress? – Boonaa Mohammed",
                            "I will remember and recover, not forgive and forget. – Unknown",
                            "The meaning of life is to give life meaning. – Ken Hudgins",
                            "The true meaning of life is to plant trees, under whose shade you do not expect to sit. – Nelson Henderson",
                            "When words fail, music speaks. – Shakespeare",
                            "Embrace the glorious mess that you are. – Elizabeth Gilbert",
                            "Normality is a paved road: it’s comfortable to walk but no flowers grow. – Vincent van Gogh",
                            "I have nothing to lose but something to gain. – Eminem "};
        public TwitterBot()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void TweetTB_TextChanged(object sender, EventArgs e)
        {

        }
        
        private async void SendTweetBTN_Click(object sender, EventArgs e)
        {
            try //try catch statement is here along with the the if statement to provide more precise error messages
            {
                if (!TweetTB.Text.Equals(""))
                {
                    await bot.SendTweet(TweetTB.Text);
                    Console.WriteLine("Words by Bots Tweeted:\n" + TweetTB.Text);
                    MessageBox.Show("Tweet Successfully Sent!");
                }
                else
                {
                    
                    MessageBox.Show("Error\n\nPlease input a phrase to tweet", "No Input Error");
                }
            }
            catch
            {
                MessageBox.Show("Error\n\nPlease input a phrase that contains letters", "Not Proper Input Error");
            }
        }

        private void RandomQuoteBTN_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomQuote = rand.Next(quotes.Length - 1);
            string randTweet = quotes[randomQuote];
            TweetTB.Text = randTweet;
        }

        private void SelectQuoteBTN_Click(object sender, EventArgs e)
        {
            QuoteSelectorForm QSF = new QuoteSelectorForm();
            QSF.ShowDialog();
            QSF.Close();
            //Console.WriteLine(QSF.SelectedQuote);
            TweetTB.Text = QSF.SelectedQuote;
        }

        private void WBBTwitterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/WordsByBots");
                WBBTwitterLink.LinkVisited = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }
    }
}
