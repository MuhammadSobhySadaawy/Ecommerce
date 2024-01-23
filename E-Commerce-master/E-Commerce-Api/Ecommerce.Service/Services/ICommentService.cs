using Ecommerce.Api.DTO;
using Ecommerce.Api.Model;

namespace Ecommerce.Api.Reporsitories
{
    public interface ICommentService
    {
        List<Comment> GetAllCommentsProduct(int ProId);
        void AddNew(CommentDTO NewComment);
        IEnumerable<Comment> getALL( );
        void delete( int commentID);

        public List<UserCommentDTO> getCommentsWithUserData(IEnumerable<Comment> AllComment);
        
    }
}
