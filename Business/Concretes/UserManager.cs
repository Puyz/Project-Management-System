using AutoMapper;
using Business.Abstracts;
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
        private readonly IMapper _mapper;

        public UserManager(IUserRepository userRepository, IMapper mapper) 
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IResult Add(User user)
        {
            _userRepository.Add(user);
            return new SuccessResult("Kullanıcı oluşturuldu.");
        }

        public IDataResult<List<UserViewDto>> GetAll()
        {
            var result = _userRepository.GetAll();
            var mapperResult = _mapper.Map<List<UserViewDto>>(result);

            return new SuccessDataResult<List<UserViewDto>>(mapperResult);
        }

        public IDataResult<UserViewDto> GetByMail(string email)
        {
            var result = _userRepository.Get(user => user.Email.Equals(email));
            var mapperResult = _mapper.Map<UserViewDto>(result);

            return new SuccessDataResult<UserViewDto>(mapperResult);
        }

        public IDataResult<List<UserViewDto>> GetAllByName(string name)
        {
            var result = _userRepository.GetAll(user => user.Name.Contains(name));
            var mapperResult = _mapper.Map<List<UserViewDto>>(result);

            return new SuccessDataResult<List<UserViewDto>>(mapperResult);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var result = _userRepository.GetClaims(user);
            return new SuccessDataResult<List<OperationClaim>>(result);
        }

        public IDataResult<UserViewDto> GetUserById(int id)
        {
            var result = _userRepository.Get(user => user.Id.Equals(id));
            var mapperResult = _mapper.Map<UserViewDto>(result);

            return new SuccessDataResult<UserViewDto>(mapperResult);
        }

        public IResult Update(User user)
        {
            _userRepository.Update(user);
            return new SuccessResult("Kullanıcı güncellendi.");
        }

        public IResult UserExists(string email)
        {
            var result = _userRepository.Get(user => user.Email.Equals(email));
            return (result != null) ? new SuccessResult() : new ErrorResult();
        }
    }
}
