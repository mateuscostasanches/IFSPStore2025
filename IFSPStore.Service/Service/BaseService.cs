using AutoMapper;
using FluentValidation;
using IFSPStore.Domain.Base;

namespace IFSPStore.Service.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : IBaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        private readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper= mapper;
        }

        public TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Insert(entity);
            return _mapper.Map<TOutputModel>(entity);
         
        }

        private void Validate(TEntity obj, AbstractValidator<TEntity> validator)
        {
            if(obj == null) throw new Exception("Objeto nulo!");
            validator.ValidateAndThrow(obj);
        }

        public void AttachObject(object obj)
        {
            _baseRepository.AttachObject(obj);
        }

        public void Delete(int id)
        {
            _baseRepository.CleanChageTracker();
            _baseRepository.Delete(id);
        }

        public IEnumerable<TOutputModel> Get<TOutputModel>(IList<string> includes = null) where TOutputModel : class
        {
            var entities = _baseRepository.Select(includes);
            return entities.Select(s => _mapper.Map<TOutputModel>(s));
        }

        public TOutputModel GetById<TOutputModel>(int id, IList<string>? includes = null) where TOutputModel : class
        {
            var entity = _baseRepository.Select(id, includes);
            return _mapper.Map<TOutputModel>(entity);
        }

        public TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TInputModel : class
            where TOutputModel : class
            where TValidator : AbstractValidator<TEntity>
        {
            var entity = _mapper.Map<TEntity>(inputModel);
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Update(entity);
            return _mapper.Map<TOutputModel>(entity);
        }
    }
}
