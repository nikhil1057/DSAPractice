# 355. Design Twitter
# https://leetcode.com/problems/design-twitter/
#
# Design a simplified version of Twitter where users can post tweets,
# follow/unfollow another user, and is able to see the 10 most recent tweets
# in the user's news feed.
#
# Implement the Twitter class:
# - Twitter() Initializes your twitter object.
# - void postTweet(int userId, int tweetId) Composes a new tweet with ID tweetId
#   by the user userId.
# - List<Integer> getNewsFeed(int userId) Retrieves the 10 most recent tweet IDs
#   in the user's news feed. Each item must be posted by users who the user
#   followed or by the user themselves. Tweets must be ordered from most recent
#   to least recent.
# - void follow(int followerId, int followeeId) The user with ID followerId
#   started following the user with ID followeeId.
# - void unfollow(int followerId, int followeeId) The user with ID followerId
#   started unfollowing the user with ID followeeId.
#
# Example 1:
#   Input: ["Twitter","postTweet","getNewsFeed","follow","postTweet","getNewsFeed","unfollow","getNewsFeed"]
#          [[],[1,5],[1],[1,2],[2,6],[1],[1,2],[1]]
#   Output: [null,null,[5],null,null,[6,5],null,[5]]
#
# Constraints:
# - 1 <= userId, followerId, followeeId <= 500
# - 0 <= tweetId <= 10^4
# - All the tweets have unique IDs.
# - At most 3 * 10^4 calls will be made to postTweet, getNewsFeed, follow, unfollow.


class DesignTwitter:
    def __init__(self):
        pass

    def post_tweet(self, user_id: int, tweet_id: int) -> None:
        pass

    def get_news_feed(self, user_id: int) -> list[int]:
        pass

    def follow(self, follower_id: int, followee_id: int) -> None:
        pass

    def unfollow(self, follower_id: int, followee_id: int) -> None:
        pass
