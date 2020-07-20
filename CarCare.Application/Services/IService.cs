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
        Task<TDto> PutEntity(int id, string values);
        Task<TDto[]> PostEntities(string values);
        Task<TDto> PostEntity(TDto entityDto);
        Task<TDto> DeleteEntity(int id);
        Task<TDto> FindEntity(int id);
    }
}
