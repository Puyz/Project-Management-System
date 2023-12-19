﻿using Core.Entities.Abstracts;
using Entities.Concretes;

namespace Entities.Dtos.Task
{
    public class TaskTodoListDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<TaskTodo>? TaskTodos { get; set; }
    }
}
