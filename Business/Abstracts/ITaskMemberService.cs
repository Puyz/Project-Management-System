﻿using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ITaskMemberService
    {
        IResult Add(List<int> userIds, int taskId);

        IResult DeleteByUserIdAndTaskId(int userId, int taskId);
        IResult DeleteAllByUserIdsAndTaskId(List<int> userIds, int taskId);

        IResult DeleteByTaskMemberId(int taskMemberId);
        IResult DeleteAllByTaskMemberIds(List<int> taskMemberIds);

        IDataResult<List<TaskMember>> GetAllByTaskId(int taskId);
        IDataResult<List<int>> GetAllIdByTaskId(int taskId);

        IDataResult<List<User>> GetTaskMembersAsUserByBoardId(int boardId); // user dto
    }
}
