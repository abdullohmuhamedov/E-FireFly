using E_FoodMarket.Domain.Commons;
using E_FoodMarket.Service.Exceptions;

namespace E_FoodMarket.Service.Extensions; 

public static class CollectionExtension 
{
    public static IQueryable<TEntity> ToPagedList<TEntity>(this IQueryable<TEntity> entities, PaginationParams @params)
            where TEntity : Auditable
    {
        return @params.PageIndex > 0 && @params.PageSize >= 0 ?
            entities.OrderBy(e => e.Id).Skip((@params.PageSize - 1) * @params.PageIndex).Take(@params.PageSize) :
            throw new CustomException(400, "Please, enter valid numbers");
    }
}
