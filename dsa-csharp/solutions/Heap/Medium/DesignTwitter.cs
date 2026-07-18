// 355. Design Twitter
// https://leetcode.com/problems/design-twitter/
//
// Design a simplified version of Twitter where users can post tweets,
// follow/unfollow another user, and see the 10 most recent tweets in their news feed.
//
// Implement the Twitter class:
// - Twitter() Initializes your twitter object.
// - void PostTweet(int userId, int tweetId) Composes a new tweet.
// - IList<int> GetNewsFeed(int userId) Retrieves the 10 most recent tweet IDs
//   in the user's news feed (from followed users or self, most recent first).
// - void Follow(int followerId, int followeeId) The user follows another user.
// - void Unfollow(int followerId, int followeeId) The user unfollows another user.
//
// Example 1:
//   Input: ["Twitter","postTweet","getNewsFeed","follow","postTweet","getNewsFeed","unfollow","getNewsFeed"]
//          [[],[1,5],[1],[1,2],[2,6],[1],[1,2],[1]]
//   Output: [null,null,[5],null,null,[6,5],null,[5]]
//
// Constraints:
// - 1 <= userId, followerId, followeeId <= 500
// - 0 <= tweetId <= 10^4
// - At most 3 * 10^4 calls will be made.

public class DesignTwitter
{
    public DesignTwitter()
    {
        throw new NotImplementedException();
    }

    public void PostTweet(int userId, int tweetId)
    {
        throw new NotImplementedException();
    }

    public IList<int> GetNewsFeed(int userId)
    {
        throw new NotImplementedException();
    }

    public void Follow(int followerId, int followeeId)
    {
        throw new NotImplementedException();
    }

    public void Unfollow(int followerId, int followeeId)
    {
        throw new NotImplementedException();
    }
}
