﻿using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class TaskLabelManager : ITaskLabelService
    {
        public IResult Add(List<int> labelIds, int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAllByLabelIdsAndTaskId(List<int> labelIds, int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteAllByTaskLabelIds(List<int> taskLabelIds)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteByLabelIdAndTaskId(int labelId, int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteByTaskLabelId(int taskLabelId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<TaskLabel>> GetAllByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<int>> GetAllIdByTaskId(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
