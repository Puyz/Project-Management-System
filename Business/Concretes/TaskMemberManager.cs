using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;

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
            foreach (var id in userIds)
            {
                var result = _taskMemberRepository.Get(user => user.UserId.Equals(id) && user.TaskId.Equals(taskId));
                if (result == null)
                {
                    TaskMember member = new()
                    {
                        UserId = id,
                        TaskId = taskId
                    };
                    _taskMemberRepository.Add(member);
                }

            }
            return new SuccessResult("Göreve yeni üyeler eklendi.");
        }

        public IResult DeleteAllByTaskMemberIds(List<int> taskMemberIds)
        {
            if (taskMemberIds == null || !taskMemberIds.Any()) return new ErrorResult("Silinmek istenen üyeler bulunamadı.");
            foreach (var memberId in taskMemberIds)
            {
                DeleteByTaskMemberId(memberId);
            }
            return new SuccessResult();
        }

        public IResult DeleteAllByUserIdsAndTaskId(List<int> userIds, int taskId)
        {
            if (userIds == null || !userIds.Any()) return new ErrorResult("Silinmek istenen üyeler bulunamadı.");
            foreach (var userId in userIds)
            {
                DeleteByUserIdAndTaskId(userId, taskId);
            }
            return new SuccessResult();
        }

        public IResult DeleteByTaskMemberId(int taskMemberId)
        {
            var result = _taskMemberRepository.Get(taskMember => taskMember.Id.Equals(taskMemberId));
            if (result == null) return new ErrorResult("Silinmek istenen üye bulunamadı.");

            _taskMemberRepository.Delete(result);
            return new SuccessResult("Görevden üye silindi.");
        }

        public IResult DeleteByUserIdAndTaskId(int userId, int taskId)
        {
            var result = _taskMemberRepository.Get(taskMember => taskMember.UserId.Equals(userId) && taskMember.TaskId.Equals(taskId));
            if (result == null) return new ErrorResult("Silinmek istenen üye bulunamadı.");

            _taskMemberRepository.Delete(result);
            return new SuccessResult("Görevden üye silindi.");
        }

        public IDataResult<List<TaskMember>> GetAllByTaskId(int taskId)
        {
            var result = _taskMemberRepository.GetAll(taskMember => taskMember.TaskId.Equals(taskId));
            return new SuccessDataResult<List<TaskMember>>(result);
        }

        public IDataResult<List<int>> GetAllIdByTaskId(int taskId)
        {
            var result = _taskMemberRepository.GetAll(taskMember => taskMember.TaskId.Equals(taskId)).Select(taskMember => taskMember.Id).ToList();
            return new SuccessDataResult<List<int>>(result);
        }

        public IDataResult<List<UserViewDto>> GetTaskMembersAsUserByBoardId(int boardId)
        {
            var result = _taskMemberRepository.GetTaskMembersAsUserByBoardId(boardId);
            return new SuccessDataResult<List<UserViewDto>>(result);
        }
    }
}
