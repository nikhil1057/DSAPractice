from solutions.heap.medium.design_twitter import DesignTwitter


class TestDesignTwitter:
    def test_example1(self):
        twitter = DesignTwitter()
        twitter.post_tweet(1, 5)
        assert twitter.get_news_feed(1) == [5]
        twitter.follow(1, 2)
        twitter.post_tweet(2, 6)
        assert twitter.get_news_feed(1) == [6, 5]
        twitter.unfollow(1, 2)
        assert twitter.get_news_feed(1) == [5]

    def test_empty_feed(self):
        twitter = DesignTwitter()
        assert twitter.get_news_feed(1) == []

    def test_self_tweets(self):
        twitter = DesignTwitter()
        twitter.post_tweet(1, 1)
        twitter.post_tweet(1, 2)
        twitter.post_tweet(1, 3)
        assert twitter.get_news_feed(1) == [3, 2, 1]

    def test_max_ten_feed(self):
        twitter = DesignTwitter()
        for i in range(15):
            twitter.post_tweet(1, i)
        feed = twitter.get_news_feed(1)
        assert len(feed) == 10
        assert feed == list(range(14, 4, -1))

    def test_follow_unfollow(self):
        twitter = DesignTwitter()
        twitter.follow(1, 2)
        twitter.post_tweet(2, 10)
        assert twitter.get_news_feed(1) == [10]
        twitter.unfollow(1, 2)
        assert twitter.get_news_feed(1) == []

    def test_unfollow_nonexistent(self):
        twitter = DesignTwitter()
        twitter.unfollow(1, 2)  # Should not crash
        assert twitter.get_news_feed(1) == []
