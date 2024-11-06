using System.Collections.Generic;

public interface ICommentRepository
{
    void AddComment(Comment comment);
    List<Comment> GetCommentsByProductId(int productId);
}
