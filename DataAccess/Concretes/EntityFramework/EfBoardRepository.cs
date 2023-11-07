using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Context;
using Entities.Concretes;
using Entities.Dtos;
using Entities.Dtos.Board;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfBoardRepository : EfEntityRepositoryBase<Board, PMSContext>, IBoardRepository
    {
        public List<BoardViewDto> GetAllBoards(int workspaceId, int userId)
        {
            using (var context = new PMSContext())
            {
                var result = (from board in context.Boards
                              join user in context.Users on board.CreatedUserId equals user.Id
                              select new BoardViewDto
                              {
                                  Id = board.Id,
                                  Name = board.Name,
                                  PrivateToWorkspaceMember = board.PrivateToWorkspaceMember,
                                  CreatedDate = board.CreatedDate,
                                  EndDate = board.EndDate,
                                  CreatedUser = new UserViewDto
                                  {
                                      Id = user.Id,
                                      Email = user.Email,
                                      Image = user.Image,
                                      Name = user.Name,
                                  },
                                  BoardMembers = context.BoardMembers
                                                .Where(boardMember => boardMember.BoardId == board.Id)
                                                .Join(context.Users, boardMember => boardMember.UserId, user => user.Id,
                                                    (boardMember, user) => new BoardMemberViewDto
                                                    {
                                                        Id = boardMember.Id,
                                                        UserId = user.Id,
                                                        Email = user.Email,
                                                        Image = user.Image,
                                                        Name = user.Name,
                                                    })
                                                .ToList()
                              }).ToList();

                var boardDtos = result
                    .Where(board => board.WorkspaceId.Equals(workspaceId) &&
                                    (board.PrivateToWorkspaceMember == false ||
                                     board.BoardMembers.Any(boardMember => boardMember.UserId == userId)
                                     || board.CreatedUser.Id.Equals(userId)))
                    .Select(r => new BoardViewDto
                    {
                        Id = r.Id,
                        Name = r.Name,
                        PrivateToWorkspaceMember = r.PrivateToWorkspaceMember,
                        CreatedDate = r.CreatedDate,
                        EndDate = r.EndDate,
                        WorkspaceId = r.WorkspaceId,
                        CreatedUser = r.CreatedUser,
                        BoardMembers = r.BoardMembers
                    }).ToList();

                return boardDtos;
            }
        }

        public BoardViewDto GetBoard(int boardId)
        {
            using (var context = new PMSContext())
            {
                var result = (from board in context.Boards
                              where board.Id.Equals(boardId)
                              join user in context.Users on board.CreatedUserId equals user.Id
                              select new BoardViewDto
                              {
                                  Id = board.Id,
                                  WorkspaceId = board.WorkspaceId,
                                  Name = board.Name,
                                  PrivateToWorkspaceMember = board.PrivateToWorkspaceMember,
                                  CreatedDate = board.CreatedDate,
                                  EndDate = board.EndDate,
                                  CreatedUser = new UserViewDto
                                  {
                                      Id = user.Id,
                                      Email = user.Email,
                                      Image = user.Image,
                                      Name = user.Name,
                                  },
                                  BoardMembers = context.BoardMembers
                                                .Where(boardMember => boardMember.BoardId == board.Id)
                                                .Join(context.Users, boardMember => boardMember.UserId, user => user.Id,
                                                    (boardMember, user) => new BoardMemberViewDto
                                                    {
                                                        Id = boardMember.Id,
                                                        UserId = user.Id,
                                                        Email = user.Email,
                                                        Image = user.Image,
                                                        Name = user.Name,
                                                    })
                                                .ToList()
                              }).SingleOrDefault();

                return result;
            }
        }
    }
}
