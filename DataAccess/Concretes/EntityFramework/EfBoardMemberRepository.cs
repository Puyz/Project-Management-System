using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos.Board;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfBoardMemberRepository : EfEntityRepositoryBase<BoardMember, PMSContext>, IBoardMemberRepository
    {
        public List<BoardMemberViewDto> GetAllByBoardIdWithUsers(int boardId)
        {
            using (var context = new PMSContext())
            {
                var result = (from boardMember in context.BoardMembers
                              where boardMember.BoardId == boardId
                              join user in context.Users on boardMember.UserId equals user.Id
                              select new BoardMemberViewDto
                              {
                                  Id = boardMember.Id,
                                  UserId = user.Id,
                                  Name = user.Name!,
                                  Email = user.Email!,
                                  Image = user.Image!
                              }).ToList();
                return result;
            }
        }
    }
}
