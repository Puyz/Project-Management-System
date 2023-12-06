using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Business.File;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<FileManager>().As<IFileService>();

            builder.RegisterType<BoardMemberManager>().As<IBoardMemberService>();
            builder.RegisterType<EfBoardMemberRepository>().As<IBoardMemberRepository>();

            builder.RegisterType<BoardManager>().As<IBoardService>();
            builder.RegisterType<EfBoardRepository>().As<IBoardRepository>();

            builder.RegisterType<LabelManager>().As<ILabelService>();
            builder.RegisterType<EfLabelRepository>().As<ILabelRepository>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimRepository>().As<IOperationClaimRepository>();

            builder.RegisterType<TaskAttachmentManager>().As<ITaskAttachmentService>();
            builder.RegisterType<EfTaskAttachmentRepository>().As<ITaskAttachmentRepository>();

            builder.RegisterType<TaskCommentManager>().As<ITaskCommentService>();
            builder.RegisterType<EfTaskCommentRepository>().As<ITaskCommentRepository>();

            builder.RegisterType<TaskLabelManager>().As<ITaskLabelService>();
            builder.RegisterType<EfTaskLabelRepository>().As<ITaskLabelRepository>();

            builder.RegisterType<TaskListManager>().As<ITaskListService>();
            builder.RegisterType<EfTaskListRepository>().As<ITaskListRepository>();

            builder.RegisterType<TaskMemberManager>().As<ITaskMemberService>();
            builder.RegisterType<EfTaskMemberRepository>().As<ITaskMemberRepository>();

            builder.RegisterType<TaskTodoListManager>().As<ITaskTodoListService>();
            builder.RegisterType<EfTaskTodoListRepository>().As<ITaskTodoListRepository>();

            builder.RegisterType<TaskTodoManager>().As<ITaskTodoService>();
            builder.RegisterType<EfTaskTodoRepository>().As<ITaskTodoRepository>();

            builder.RegisterType<TaskManager>().As<ITaskService>();
            builder.RegisterType<EfTaskRepository>().As<ITaskRepository>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimRepository>().As<IUserOperationClaimRepository>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserRepository>().As<IUserRepository>();

            builder.RegisterType<WorkspaceMemberManager>().As<IWorkspaceMemberService>();
            builder.RegisterType<EfWorkspaceMemberRepository>().As<IWorkspaceMemberRepository>();

            builder.RegisterType<WorkspaceManager>().As<IWorkspaceService>();
            builder.RegisterType<EfWorkspaceRepository>().As<IWorkspaceRepository>();

            builder.RegisterType<WorkspaceTypeManager>().As<IWorkspaceTypeService>();
            builder.RegisterType<EfWorkspaceTypeRepository>().As<IWorkspaceTypeRepository>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                 .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                 {
                     Selector = new AspectInterceptorSelector()
                 }).SingleInstance();
        }
    }
}
