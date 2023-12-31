﻿using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Results.Concretes
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }

        public Result(bool success, string message) : this(success)
        {
            this.Message = message;
        }
        public Result(bool success)
        {
            this.Success = success;
        }
    }
}
