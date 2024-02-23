

using Week6.models;

namespace Week6.repositories {
    public class TagsRepositoryDapperImpl : ITagsRepository {

        private static readonly string GET_USER_TAGS = @"
            SELECT 
                UserTags.TagID,
                UserTags.UserID,
                Tags.TagName 
            FROM
                UserTags
            JOIN 
                Tags
            ON
                UserTags.TagID = Tags.TagID
            WHERE
                UserTags.UserID = @USER_ID";

        private readonly IDbConnection _connection;

        public UsersRepositoryDapperImpl(IDbConnection connection) {
            this._connection = connection;
        }
        public List<Tag> GetTagsByUserId(int UserId) {
            var Params = new {
                USER_ID = UserId
            };
            return this._connection.Query<Tag>(GET_USER_TAGS, Params).ToList();
        }
        
    }

    
}