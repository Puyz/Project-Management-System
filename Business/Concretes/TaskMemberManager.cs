using Business.Abstracts;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskMemberManager : ITaskMemberService
    {
        private readonly ITaskMemberRepository _taskMemberRepository;
        public TaskMemberManager(ITaskMemberRepository taskMemberRepository)
        {
            _taskMemberRepository = taskMemberRepository;
        }

        public IResult Add(List<int> userIds, int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAllByTaskMemberIds(List<int> taskMemberIds)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAllByUserIdsAndTaskId(List<int> userIds, int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteByTaskMemberId(int taskMemberId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteByUserIdAndTaskId(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskMember>> GetAllByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<int>> GetAllIdByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetTaskMembersAsUserByBoardId(int boardId)
        {
            throw new NotImplementedException();
        }
    }
}
