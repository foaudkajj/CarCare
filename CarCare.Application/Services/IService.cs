using CarCare.Shared;
using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarCare.Application.Services
{
    public interface IService<T, TDto>
    {
        Task<TDto> GetEntity(int Id);
        LoadResult GetEntities(DataSourceLoadOptions loadOptions);
        Task<TDto> PutEntity(int id, TDto entityDto);
        Task<TDto[]> PostEntities(TDto[] entitiesDto);
        Task<TDto> PostEntity(TDto entityDto);
        Task<TDto> DeleteEntity(int id);
        Task<TDto> FindEntity(int id);
    }
}
