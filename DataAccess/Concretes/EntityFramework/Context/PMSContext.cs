using Core.Entities.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework.Context
{
    public class PMSContext : DbContext
    {
        public PMSContext() { }
        public PMSContext(DbContextOptions<PMSContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=project_management_system;user=root;password=Puyz123.");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<BoardMember> BoardMembers { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Entities.Concretes.Task> Tasks { get; set; }
        public DbSet<TaskAttachment> TaskAttachments { get; set; }
        public DbSet<TaskComment> TaskComments { get; set; }
        public DbSet<TaskLabel> TaskLabels { get; set; }
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<TaskMember> TaskMembers { get; set; }
        public DbSet<TaskTodoList> TaskTodoLists { get; set; }
        public DbSet<TaskTodo> TaskTodos { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<WorkspaceMember> WorkspaceMembers { get; set; }
        public DbSet<WorkspaceType> WorkspaceTypes { get; set; }


    }
}
