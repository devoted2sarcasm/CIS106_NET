namespace Week6.repositories {
    public interface ITagsRepository {
        public List<Tag> GetTagsByUserId(int UserId);
        }
}