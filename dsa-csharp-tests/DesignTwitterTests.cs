public class DesignTwitterTests
{
    [Fact]
    public void Example1()
    {
        var twitter = new DesignTwitter();
        twitter.PostTweet(1, 5);
        Assert.Equal(new[] { 5 }, twitter.GetNewsFeed(1));
        twitter.Follow(1, 2);
        twitter.PostTweet(2, 6);
        Assert.Equal(new[] { 6, 5 }, twitter.GetNewsFeed(1));
        twitter.Unfollow(1, 2);
        Assert.Equal(new[] { 5 }, twitter.GetNewsFeed(1));
    }

    [Fact]
    public void EmptyFeed()
    {
        var twitter = new DesignTwitter();
        Assert.Empty(twitter.GetNewsFeed(1));
    }

    [Fact]
    public void SelfTweets()
    {
        var twitter = new DesignTwitter();
        twitter.PostTweet(1, 1);
        twitter.PostTweet(1, 2);
        twitter.PostTweet(1, 3);
        Assert.Equal(new[] { 3, 2, 1 }, twitter.GetNewsFeed(1));
    }

    [Fact]
    public void MaxTenFeed()
    {
        var twitter = new DesignTwitter();
        for (int i = 0; i < 15; i++)
            twitter.PostTweet(1, i);
        var feed = twitter.GetNewsFeed(1);
        Assert.Equal(10, feed.Count);
        Assert.Equal(14, feed[0]);
    }

    [Fact]
    public void FollowUnfollow()
    {
        var twitter = new DesignTwitter();
        twitter.Follow(1, 2);
        twitter.PostTweet(2, 10);
        Assert.Equal(new[] { 10 }, twitter.GetNewsFeed(1));
        twitter.Unfollow(1, 2);
        Assert.Empty(twitter.GetNewsFeed(1));
    }

    [Fact]
    public void UnfollowNonexistent()
    {
        var twitter = new DesignTwitter();
        twitter.Unfollow(1, 2); // Should not crash
        Assert.Empty(twitter.GetNewsFeed(1));
    }
}
