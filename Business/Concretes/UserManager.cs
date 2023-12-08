using AutoMapper;
using Business.Abstracts;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concretes;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Dtos;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
      

        public UserManager(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        
        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Add(User user)
        {
            _userRepository.Add(user);
            return new SuccessResult("Kullanıcı oluşturuldu.");
        }

        [CacheAspect]
        [SecuredOperation("admin, mod")]
        public IDataResult<List<UserViewDto>> GetAll()
        {
            var result = _userRepository.GetAll();

            var mapperResult = UserViewsMapper(result);

            return new SuccessDataResult<List<UserViewDto>>(mapperResult);
        }

        public IDataResult<User> GetByMail(string email)
        {
            var result = _userRepository.Get(user => user.Email!.Equals(email));

            if (result == null) return new ErrorDataResult<User>("Kullanıcı bulunamadı");

            return new SuccessDataResult<User>(result);
        }

        public IDataResult<List<UserViewDto>> GetAllByName(string name)
        {
            var result = _userRepository.GetAll(user => user.Name!.Contains(name));
            var mapperResult = UserViewsMapper(result);

            return new SuccessDataResult<List<UserViewDto>>(mapperResult);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var result = _userRepository.GetClaims(user);
            return new SuccessDataResult<List<OperationClaim>>(result);
        }

        public IDataResult<UserViewDto> GetUserById(int id)
        {
            var user = _userRepository.Get(user => user.Id.Equals(id));

            var result = UserViewMapper(user);

            return new SuccessDataResult<UserViewDto>(result);
        }

        [CacheRemoveAspect("IUserService.Get")]
        public IResult Update(User user)
        {
            _userRepository.Update(user);
            return new SuccessResult("Kullanıcı güncellendi.");
        }


        private static UserViewDto UserViewMapper(User user)
        {
            return new UserViewDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Image = user.Image,
                CreatedDate = user.CreatedDate
            };
        }

        private static List<UserViewDto> UserViewsMapper(List<User> users)
        {
            var result = new List<UserViewDto>();
            foreach (var user in users)
            {
                var dto = new UserViewDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Image = user.Image,
                    CreatedDate = user.CreatedDate
                };
                result.Add(dto);
            }

            return result;
            
        }

    }
}
