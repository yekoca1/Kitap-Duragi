using System.Collections.Generic;

public class CommentService
{
    private readonly ICommentRepository _commentRepository;

    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public void AddComment(Comment comment)
    {
        _commentRepository.AddComment(comment);
    }

    public List<Comment> GetCommentsByProductId(int productId)
    {
        return _commentRepository.GetCommentsByProductId(productId);
    }
}
